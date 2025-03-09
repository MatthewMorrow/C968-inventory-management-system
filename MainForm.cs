using System;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class MainForm : Form
    {
        private readonly Inventory inventory;
        private static int partIdCounter = 0;
        private static int productIdCounter = 0;

        public MainForm()
        {
            InitializeComponent();

            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsDataGridView.MultiSelect = false;
            partsDataGridView.AllowUserToAddRows = false;

            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.MultiSelect = false;
            productsDataGridView.AllowUserToAddRows = false;

            inventory = new Inventory(); 
            AddSampleData();
            ConfigureButtonStyles();

            partsDataGridView.DataSource = inventory.AllParts;
            productsDataGridView.DataSource = inventory.Products;

            this.Load += MainForm_Load;
            this.Click += MainForm_Click;

        }

        private void ConfigureButtonStyles()
        {
            void ConfigureButton(Control control)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Standard;
                    button.BackColor = SystemColors.Control;
                    button.UseVisualStyleBackColor = true;
                }

                foreach (Control child in control.Controls)
                {
                    ConfigureButton(child);
                }
            }

            foreach (Control control in this.Controls)
            {
                ConfigureButton(control);
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void AddSampleData()
        {
            var wheel = new Inhouse
            {
                PartID = GeneratePartId(),
                Name = "Wheel",
                Price = 12.11m,
                InStock = 15,
                Min = 5,
                Max = 25,
                MachineID = 110
            };
            inventory.AddPart(wheel);

            var chain = new Inhouse
            {
                PartID = GeneratePartId(),
                Name = "Chain",
                Price = 8.33m,
                InStock = 12,
                Min = 2,
                Max = 25,
                MachineID = 120
            };
            inventory.AddPart(chain);

            var pedal = new Outsourced
            {
                PartID = GeneratePartId(),
                Name = "Pedal",
                Price = 6.50m,
                InStock = 6,
                Min = 1,
                Max = 10,
                CompanyName = "ProPedal Inc."
            };
            inventory.AddPart(pedal);

            var brake = new Outsourced
            {
                PartID = GeneratePartId(),
                Name = "Brake",
                Price = 10.00m,
                InStock = 9,
                Min = 2,
                Max = 20,
                CompanyName = "BrakeMasters"
            };
            inventory.AddPart(brake);

            var redBike = new Product
            {
                ProductID = GenerateProductId(),
                Name = "Red Bicycle",
                Price = 99.99m,
                InStock = 5,
                Min = 1,
                Max = 10
            };
            redBike.AddAssociatedPart(wheel);
            redBike.AddAssociatedPart(pedal);
            inventory.AddProduct(redBike);

            var blueBike = new Product
            {
                ProductID = GenerateProductId(),
                Name = "Blue Bicycle",
                Price = 79.50m,
                InStock = 3,
                Min = 1,
                Max = 8
            };
            blueBike.AddAssociatedPart(chain);
            inventory.AddProduct(blueBike);

            var helmet = new Product
            {
                ProductID = GenerateProductId(),
                Name = "Safety Helmet",
                Price = 29.99m,
                InStock = 10,
                Min = 1,
                Max = 50
            };
            inventory.AddProduct(helmet);
        }

        private static int GeneratePartId() => ++partIdCounter;
        private static int GenerateProductId() => ++productIdCounter;

        private void MainForm_Load(object sender, EventArgs e)
        {
            partsDataGridView.ClearSelection();
            productsDataGridView.ClearSelection();
        }
        private void AddPartButton_Click(object sender, EventArgs e)
        {

            var addPartForm = new AddPartForm(inventory);
            addPartForm.ShowDialog();

            if (addPartForm.DialogResult == DialogResult.OK)
            {
                partsDataGridView.Refresh();
            }
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count > 0 && partsDataGridView.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var modifyPartForm = new ModifyPartForm(selectedPart, inventory);
                modifyPartForm.ShowDialog();
                if (modifyPartForm.DialogResult == DialogResult.OK)
                {
                    partsDataGridView.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to modify.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count > 0 && partsDataGridView.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                foreach (Product product in inventory.Products)
                {
                    if (product.AssociatedParts.Contains(selectedPart))
                    {
                        MessageBox.Show("Cannot delete a part that is associated with a product.",
                            "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                var result = MessageBox.Show("Are you sure you want to delete this part?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    inventory.DeletePart(selectedPart);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPartsButton_Click(object sender, EventArgs e)
        {
 
            string searchTerm = searchPartsTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm)) return;

            Part foundPart = null;
            if (int.TryParse(searchTerm, out int partId))
            {
                foundPart = inventory.LookupPart(partId);
            }

            if (foundPart == null)
            {
                foundPart = inventory.AllParts.FirstOrDefault(p => p.Name.ToLower().Contains(searchTerm.ToLower()));
            }


            if (foundPart != null)
            {
                partsDataGridView.ClearSelection();
                int index = inventory.AllParts.IndexOf(foundPart);
                partsDataGridView.Rows[index].Selected = true;
            }
            else
            {
                MessageBox.Show("No matching parts found.", "Search Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPartsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchPartsTextBox.Text))
            {
                partsDataGridView.ClearSelection();
            }
        }

        private void SearchPartsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchPartsButton.PerformClick(); 
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm(inventory);
            addProductForm.ShowDialog();

            if (addProductForm.DialogResult == DialogResult.OK)
            {
                productsDataGridView.Refresh();
            }
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0 && productsDataGridView.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                var modifyProductForm = new ModifyProductForm(selectedProduct, inventory);
                modifyProductForm.ShowDialog();

                if (modifyProductForm.DialogResult == DialogResult.OK)
                {
                    productsDataGridView.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to modify.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0 && productsDataGridView.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                if (selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product that has associated parts.",
                        "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this product?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    inventory.RemoveProduct(selectedProduct.ProductID);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.",
                    "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchProductsButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchProductsTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm)) return;

            Product foundProduct = null;
            if (int.TryParse(searchTerm, out int productId))
            {
                foundProduct = inventory.LookupProduct(productId);
            }

            if (foundProduct == null)
            {
                foundProduct = inventory.Products.FirstOrDefault(p => p.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            if (foundProduct != null)
            {
                productsDataGridView.ClearSelection();
                int index = inventory.Products.IndexOf(foundProduct);
                productsDataGridView.Rows[index].Selected = true;
            }
            else
            {
                MessageBox.Show("No matching products found.", "Search Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchProductsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchProductsTextBox.Text))
            {
                productsDataGridView.ClearSelection();
            }
        }

        private void SearchProductsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchProductsButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}