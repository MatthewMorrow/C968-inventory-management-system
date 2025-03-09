namespace InventorySystem
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text = "Part";
            this.inHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceCostTextBox = new System.Windows.Forms.TextBox();
            this.priceCostLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.machineIdTextBox = new System.Windows.Forms.TextBox();
            this.machineIdLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // inHouseRadioButton
            // 
            this.inHouseRadioButton.AutoSize = true;
            this.inHouseRadioButton.Checked = true;
            this.inHouseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inHouseRadioButton.Location = new System.Drawing.Point(173, 7);
            this.inHouseRadioButton.Name = "inHouseRadioButton";
            this.inHouseRadioButton.Size = new System.Drawing.Size(93, 24);
            this.inHouseRadioButton.TabIndex = 0;
            this.inHouseRadioButton.TabStop = true;
            this.inHouseRadioButton.Text = "In-House";
            this.inHouseRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inHouseRadioButton.UseVisualStyleBackColor = true;
            this.inHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outsourcedRadioButton.Location = new System.Drawing.Point(311, 7);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(110, 24);
            this.outsourcedRadioButton.TabIndex = 1;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addPartLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(79, 20);
            this.addPartLabel.TabIndex = 2;
            this.addPartLabel.Text = "Add Part";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDLabel.Location = new System.Drawing.Point(118, 79);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 20);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(194, 69);
            this.IdTextBox.Multiline = true;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(175, 30);
            this.IdTextBox.TabIndex = 5;
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.BackColor = System.Drawing.Color.Salmon;
            this.partNameTextBox.Location = new System.Drawing.Point(194, 117);
            this.partNameTextBox.Multiline = true;
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(175, 30);
            this.partNameTextBox.TabIndex = 7;
            this.partNameTextBox.TextChanged += new System.EventHandler(this.PartNameTextBox_TextChanged);
            this.partNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partNameLabel.Location = new System.Drawing.Point(93, 127);
            this.partNameLabel.Name = "nameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(51, 20);
            this.partNameLabel.TabIndex = 6;
            this.partNameLabel.Text = "Name";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            this.inventoryTextBox.Location = new System.Drawing.Point(194, 165);
            this.inventoryTextBox.Multiline = true;
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(175, 30);
            this.inventoryTextBox.TabIndex = 9;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.InventoryTextBox_TextChanged);
            this.inventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inventoryLabel.Location = new System.Drawing.Point(70, 175);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.inventoryLabel.TabIndex = 8;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceCostTextBox
            // 
            this.priceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            this.priceCostTextBox.Location = new System.Drawing.Point(194, 213);
            this.priceCostTextBox.Multiline = true;
            this.priceCostTextBox.Name = "priceCostTextBox";
            this.priceCostTextBox.Size = new System.Drawing.Size(175, 30);
            this.priceCostTextBox.TabIndex = 11;
            this.priceCostTextBox.TextChanged += new System.EventHandler(this.PriceCostTextBox_TextChanged);
            this.priceCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // priceCostLabel
            // 
            this.priceCostLabel.AutoSize = true;
            this.priceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceCostLabel.Location = new System.Drawing.Point(55, 223);
            this.priceCostLabel.Name = "priceCostLabel";
            this.priceCostLabel.Size = new System.Drawing.Size(89, 20);
            this.priceCostLabel.TabIndex = 10;
            this.priceCostLabel.Text = "Price / Cost";
            // 
            // minTextBox
            // 
            this.minTextBox.BackColor = System.Drawing.Color.Salmon;
            this.minTextBox.Location = new System.Drawing.Point(396, 261);
            this.minTextBox.Multiline = true;
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(86, 30);
            this.minTextBox.TabIndex = 13;
            this.minTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
            this.minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minLabel.Location = new System.Drawing.Point(317, 271);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(34, 20);
            this.minLabel.TabIndex = 12;
            this.minLabel.Text = "Min";
            // 
            // maxTextBox
            // 
            this.maxTextBox.BackColor = System.Drawing.Color.Salmon;
            this.maxTextBox.Location = new System.Drawing.Point(194, 261);
            this.maxTextBox.Multiline = true;
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(86, 30);
            this.maxTextBox.TabIndex = 15;
            this.maxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxLabel.Location = new System.Drawing.Point(106, 271);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(38, 20);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max";
            // 
            // machineIdTextBox
            // 
            this.machineIdTextBox.BackColor = System.Drawing.Color.Salmon;
            this.machineIdTextBox.Location = new System.Drawing.Point(194, 309);
            this.machineIdTextBox.Multiline = true;
            this.machineIdTextBox.Name = "machineIdTextBox";
            this.machineIdTextBox.Size = new System.Drawing.Size(175, 30);
            this.machineIdTextBox.TabIndex = 17;
            this.machineIdTextBox.TextChanged += new System.EventHandler(this.MachineIdTextBox_TextChanged);
            this.machineIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // machineIdLabel
            // 
            this.machineIdLabel.AutoSize = true;
            this.machineIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.machineIdLabel.Location = new System.Drawing.Point(54, 319);
            this.machineIdLabel.Name = "machineIdLabel";
            this.machineIdLabel.Size = new System.Drawing.Size(90, 20);
            this.machineIdLabel.TabIndex = 16;
            this.machineIdLabel.Text = "Machine ID";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(294, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 40);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.Location = new System.Drawing.Point(407, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 40);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.BackColor = System.Drawing.Color.Salmon;
            this.companyNameTextBox.Location = new System.Drawing.Point(194, 309);
            this.companyNameTextBox.Multiline = true;
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(175, 30);
            this.companyNameTextBox.TabIndex = 21;
            this.companyNameTextBox.Visible = false;
            this.companyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.companyNameTextBox.TextChanged += new System.EventHandler(this.CompanyNameTextBox_TextChanged);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.companyNameLabel.Location = new System.Drawing.Point(22, 319);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(122, 20);
            this.companyNameLabel.TabIndex = 20;
            this.companyNameLabel.Text = "Company Name";
            this.companyNameLabel.Visible = false;
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 449);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.machineIdTextBox);
            this.Controls.Add(this.machineIdLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceCostTextBox);
            this.Controls.Add(this.priceCostLabel);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.addPartLabel);
            this.Controls.Add(this.outsourcedRadioButton);
            this.Controls.Add(this.inHouseRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inHouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox priceCostTextBox;
        private System.Windows.Forms.Label priceCostLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox machineIdTextBox;
        private System.Windows.Forms.Label machineIdLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label companyNameLabel;
    }
}