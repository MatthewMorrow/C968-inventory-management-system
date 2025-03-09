using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace InventorySystem
{
    public partial class ModifyProductForm : Form
    {
        private readonly Inventory _inventory;
        private Product _selectedProduct;
        private BindingList<Part> _associatedParts = new BindingList<Part>();

        public ModifyProductForm(Product selectedProduct, Inventory inventory)
        {
            InitializeComponent();
            ConfigureDataGridView();
            this.Text = "Modify Product";

            _selectedProduct = selectedProduct;
            _inventory = inventory;

            SetupRequiredFields();
            BindDataGrids();
            PopulateProductFields();
            ConfigureButtonStyles();

            this.Load += ModifyProductForm_Load;
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

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            candidatePartsDataGridView.ClearSelection();
            associatedPartsDataGridView.ClearSelection();
        }

        private void BindDataGrids()
        {
            candidatePartsDataGridView.DataSource = _inventory.AllParts;

            foreach (var part in _selectedProduct.AssociatedParts)
            {
                _associatedParts.Add(part);
            }
            associatedPartsDataGridView.DataSource = _associatedParts;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            candidatePartsDataGridView.ClearSelection();
            associatedPartsDataGridView.ClearSelection();
        }

        private void PopulateProductFields()
        {
            IdTextBox.Text = _selectedProduct.ProductID.ToString();
            IdTextBox.ReadOnly = true;
            productNameTextBox.Text = _selectedProduct.Name;
            inventoryTextBox.Text = _selectedProduct.InStock.ToString();
            priceTextBox.Text = _selectedProduct.Price.ToString();
            minTextBox.Text = _selectedProduct.Min.ToString();
            maxTextBox.Text = _selectedProduct.Max.ToString();
        }

        private bool ValidateInventoryLevels(int inventory, int min, int max)
        {
            if (min > max)
            {
                MessageBox.Show(
                    $"Minimum ({min}) cannot be greater than Maximum ({max}).",
                    "Invalid Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show(
                    $"Inventory level ({inventory}) must be between Minimum ({min}) and Maximum ({max}).",
                    "Invalid Inventory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveModifiedProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(productNameTextBox.Text))
                {
                    MessageBox.Show("Product Name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (int.TryParse(productNameTextBox.Text, out _))
                {
                    MessageBox.Show("Product Name cannot be a number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(priceTextBox.Text, out decimal price))
                {
                    MessageBox.Show("Price must be a valid number.\nExample: 10.99",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (decimal.Round(price, 2) != price)
                {
                    MessageBox.Show("Price cannot have more than 2 decimal places.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(inventoryTextBox.Text, out int inventory))
                {
                    MessageBox.Show("Inventory must be a whole number.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(minTextBox.Text, out int min))
                {
                    MessageBox.Show("Minimum must be a whole number.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(maxTextBox.Text, out int max))
                {
                    MessageBox.Show("Maximum must be a whole number.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidateInventoryLevels(inventory, min, max))
                {
                    return;
                }

                _selectedProduct.Name = productNameTextBox.Text;
                _selectedProduct.InStock = inventory;
                _selectedProduct.Price = price;
                _selectedProduct.Min = min;
                _selectedProduct.Max = max;
                _selectedProduct.AssociatedParts.Clear();

                foreach (var part in _associatedParts)
                {
                    _selectedProduct.AddAssociatedPart(part);
                }

                _inventory.UpdateProduct(_selectedProduct.ProductID, _selectedProduct);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values where required.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelModifiedProductButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddAssociatedPartButton_Click(object sender, EventArgs e)
        {
            if (candidatePartsDataGridView.SelectedRows.Count > 0 &&
                candidatePartsDataGridView.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                _associatedParts.Add(selectedPart);
                candidatePartsDataGridView.ClearSelection();
                associatedPartsDataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select a part to add.",
                    "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            if (associatedPartsDataGridView.SelectedRows.Count > 0 &&
                associatedPartsDataGridView.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to remove this associated part?",
                    "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _selectedProduct.RemoveAssociatedPart(selectedPart.PartID);
                    _associatedParts.Remove(selectedPart);
                    associatedPartsDataGridView.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to remove.",
                    "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchCandidatePartsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = searchCandidatePartsTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    candidatePartsDataGridView.ClearSelection();
                    return;
                }

                Part foundPart = null;
                if (int.TryParse(searchTerm, out int partId))
                {
                    foundPart = _inventory.LookupPart(partId);
                }

                if (foundPart == null)
                {
                    foundPart = _inventory.AllParts
                        .FirstOrDefault(p => p.Name.ToLower()
                        .Contains(searchTerm.ToLower()));
                }

                if (foundPart != null)
                {
                    candidatePartsDataGridView.ClearSelection();
                    int index = _inventory.AllParts.IndexOf(foundPart);
                    if (index >= 0)
                    {
                        candidatePartsDataGridView.Rows[index].Selected = true;
                        candidatePartsDataGridView.FirstDisplayedScrollingRowIndex = index;
                    }
                }
                else
                {
                    MessageBox.Show("No matching parts found.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCandidatePartsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchCandidatePartsTextBox.Text))
            {
                candidatePartsDataGridView.ClearSelection();
            }
        }

        private void SearchCandidatePartsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchCandidatePartsButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SetupRequiredFields()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox != IdTextBox)
                {
                    textBox.BackColor = Color.Salmon;
                    textBox.TextChanged += TextBox_TextChanged;
                }
            }
        }

        private void ValidateFields()
        {
            bool isValid = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox &&
                    textBox != IdTextBox &&
                    textBox.Visible &&
                    string.IsNullOrWhiteSpace(textBox.Text))
                {
                    isValid = false;
                    break;
                }
            }
            saveModifiedProduct.Enabled = isValid;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = string.IsNullOrWhiteSpace(textBox.Text) ? Color.Salmon : Color.White;
            ValidateFields();
        }

        private void ConfigureDataGridView()
        {
            candidatePartsDataGridView.AutoGenerateColumns = false;
            candidatePartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candidatePartsDataGridView.MultiSelect = false;
            candidatePartsDataGridView.AllowUserToAddRows = false;
            candidatePartsDataGridView.ReadOnly = true;
            candidatePartsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

            candidatePartIDColumn.DataPropertyName = "PartID";
            candidatePartNameColumn.DataPropertyName = "Name";
            candidatePartInventoryColumn.DataPropertyName = "InStock";
            candidatePartPriceColumn.DataPropertyName = "Price";
            candidatePartMinColumn.DataPropertyName = "Min";
            candidatePartMaxColumn.DataPropertyName = "Max";

            associatedPartsDataGridView.AutoGenerateColumns = false;
            associatedPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedPartsDataGridView.MultiSelect = false;
            associatedPartsDataGridView.AllowUserToAddRows = false;
            associatedPartsDataGridView.ReadOnly = true;
            associatedPartsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

            associatedPartIdColumn.DataPropertyName = "PartID";
            associatedPartNameColumn.DataPropertyName = "Name";
            associatedPartInventoryColumn.DataPropertyName = "InStock";
            associatedPartPriceColumn.DataPropertyName = "Price";
            associatedPartMinColumn.DataPropertyName = "Min";
            associatedPartMaxColumn.DataPropertyName = "Max";
        }
    }
}
