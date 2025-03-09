using System;
using System.Drawing;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;


namespace InventorySystem
{
    public partial class ModifyPartForm : Form
    {
        private readonly Inventory inventory;
        private readonly Part selectedPart;
        private string companyNameValue; // Saves the original value, allowing the user to switch between the "In-House" and "Outsourced" buttons
        private int machineIdValue; // Saves the original value, allowing the user to switch between the "In-House" and "Outsourced" buttons

        public ModifyPartForm(Part selectedPart, Inventory inventory)
        {
            InitializeComponent();
            ConfigureForm();

            this.inventory = inventory;
            this.selectedPart = selectedPart;
            SetupRequiredFields();
            PopulateFields();
            ConfigureButtonStyles();
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

        private void ConfigureForm()
        {
            this.Text = "Part";

            IdTextBox.ReadOnly = true;
            saveButton.Enabled = false;
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

        private void PopulateFields()
        {
            IdTextBox.Text = selectedPart.PartID.ToString();
            partNameTextBox.Text = selectedPart.Name.ToString();
            inventoryTextBox.Text = selectedPart.InStock.ToString();
            priceCostTextBox.Text = selectedPart.Price.ToString();
            minTextBox.Text = selectedPart.Min.ToString();
            maxTextBox.Text = selectedPart.Max.ToString();

            if (selectedPart is Inhouse inhousePart)
            {
                inHouseRadioButton.Checked = true;
                machineIdValue = inhousePart.MachineID;
                machineIdTextBox.Text = machineIdValue.ToString();
            }
            else if (selectedPart is Outsourced outsourcedPart)
            {
                outsourcedRadioButton.Checked = true;
                companyNameValue = outsourcedPart.CompanyName;
                companyNameTextBox.Text = companyNameValue;
            }
        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadioButton.Checked)
            {
                machineIdLabel.Show();
                machineIdTextBox.Show();
                companyNameLabel.Hide();
                companyNameTextBox.Hide();
                companyNameTextBox.Text = string.Empty;
                if (machineIdValue != 0)
                    machineIdTextBox.Text = machineIdValue.ToString();
                ValidateFields();
            }
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourcedRadioButton.Checked)
            {
                machineIdLabel.Hide();
                machineIdTextBox.Hide();
                companyNameLabel.Show();
                companyNameTextBox.Show();
                machineIdTextBox.Text = string.Empty;
                if (!string.IsNullOrEmpty(companyNameValue))
                    companyNameTextBox.Text = companyNameValue;
                ValidateFields();
            }
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
            saveButton.Enabled = isValid;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(partNameTextBox.Text))
                {
                    MessageBox.Show("Part Name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (int.TryParse(partNameTextBox.Text, out _))
                {
                    MessageBox.Show("Part Name cannot be a number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(priceCostTextBox.Text, out decimal price))
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

                Part updatedPart;
                if (inHouseRadioButton.Checked)
                {
                    if (!int.TryParse(machineIdTextBox.Text, out int machineId))
                        throw new Exception("Machine ID must be a valid number.");

                    updatedPart = new Inhouse
                    {
                        PartID = selectedPart.PartID,
                        Name = partNameTextBox.Text,
                        Price = price,
                        InStock = inventory,
                        Min = min,
                        Max = max,
                        MachineID = machineId
                    };
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(companyNameTextBox.Text))
                        throw new Exception("Company Name is required.");

                    updatedPart = new Outsourced
                    {
                        PartID = selectedPart.PartID,
                        Name = partNameTextBox.Text,
                        Price = price,
                        InStock = inventory,
                        Min = min,
                        Max = max,
                        CompanyName = companyNameTextBox.Text
                    };
                }

                this.inventory.UpdatePart(selectedPart.PartID, updatedPart);
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = string.IsNullOrWhiteSpace(textBox.Text) ? Color.Salmon : Color.White;
            ValidateFields();
        }

        private void PartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void PriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void MinTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void MaxTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void MachineIdTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void CompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }
    }
}