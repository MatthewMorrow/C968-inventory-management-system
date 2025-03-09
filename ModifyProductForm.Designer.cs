namespace InventorySystem
{
    partial class ModifyProductForm
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



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modifyProductLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.saveModifiedProduct = new System.Windows.Forms.Button();
            this.deleteAssociatedPart = new System.Windows.Forms.Button();
            this.cancelModifyProduct = new System.Windows.Forms.Button();
            this.candidatePartsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchCandidatePartsTextBox = new System.Windows.Forms.TextBox();
            this.searchCandidatePartsButton = new System.Windows.Forms.Button();
            this.addAssociatedPartButton = new System.Windows.Forms.Button();
            this.candidatePartsDataGridView = new System.Windows.Forms.DataGridView();
            this.candidatePartIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartMinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartMaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsGroupBox = new System.Windows.Forms.GroupBox();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.associatedPartIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartMinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartMaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.candidatePartsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGridView)).BeginInit();
            this.associatedPartsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modifyProductLabel.Location = new System.Drawing.Point(31, 30);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(128, 20);
            this.modifyProductLabel.TabIndex = 2;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDLabel.Location = new System.Drawing.Point(49, 277);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 20);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IdTextBox.Location = new System.Drawing.Point(188, 267);
            this.IdTextBox.Multiline = true;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(175, 30);
            this.IdTextBox.TabIndex = 5;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.Color.White;
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productNameTextBox.Location = new System.Drawing.Point(188, 315);
            this.productNameTextBox.Multiline = true;
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(175, 30);
            this.productNameTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(49, 325);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.BackColor = System.Drawing.Color.White;
            this.inventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inventoryTextBox.Location = new System.Drawing.Point(188, 363);
            this.inventoryTextBox.Multiline = true;
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(175, 30);
            this.inventoryTextBox.TabIndex = 9;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inventoryLabel.Location = new System.Drawing.Point(49, 373);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.inventoryLabel.TabIndex = 8;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.White;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceTextBox.Location = new System.Drawing.Point(188, 411);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(175, 30);
            this.priceTextBox.TabIndex = 11;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceLabel.Location = new System.Drawing.Point(49, 421);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price";
            // 
            // minTextBox
            // 
            this.minTextBox.BackColor = System.Drawing.Color.White;
            this.minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minTextBox.Location = new System.Drawing.Point(319, 459);
            this.minTextBox.Multiline = true;
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(86, 30);
            this.minTextBox.TabIndex = 13;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minLabel.Location = new System.Drawing.Point(255, 469);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(34, 20);
            this.minLabel.TabIndex = 12;
            this.minLabel.Text = "Min";
            // 
            // maxTextBox
            // 
            this.maxTextBox.BackColor = System.Drawing.Color.White;
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxTextBox.Location = new System.Drawing.Point(122, 459);
            this.maxTextBox.Multiline = true;
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(86, 30);
            this.maxTextBox.TabIndex = 15;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxLabel.Location = new System.Drawing.Point(49, 469);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(38, 20);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max";
            // 
            // saveModifiedProduct
            // 
            this.saveModifiedProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveModifiedProduct.Enabled = false;
            this.saveModifiedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveModifiedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveModifiedProduct.Location = new System.Drawing.Point(1014, 815);
            this.saveModifiedProduct.Name = "saveModifiedProduct";
            this.saveModifiedProduct.Size = new System.Drawing.Size(75, 40);
            this.saveModifiedProduct.TabIndex = 18;
            this.saveModifiedProduct.Text = "Save";
            this.saveModifiedProduct.UseVisualStyleBackColor = false;
            this.saveModifiedProduct.Click += new System.EventHandler(this.SaveModifiedProductButton_Click);
            // 
            // deleteAssociatedPart
            // 
            this.deleteAssociatedPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteAssociatedPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAssociatedPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteAssociatedPart.Location = new System.Drawing.Point(656, 308);
            this.deleteAssociatedPart.Name = "deleteAssociatedPart";
            this.deleteAssociatedPart.Size = new System.Drawing.Size(75, 40);
            this.deleteAssociatedPart.TabIndex = 19;
            this.deleteAssociatedPart.Text = "Delete";
            this.deleteAssociatedPart.UseVisualStyleBackColor = false;
            this.deleteAssociatedPart.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // cancelModifyProduct
            // 
            this.cancelModifyProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelModifyProduct.Location = new System.Drawing.Point(1120, 815);
            this.cancelModifyProduct.Name = "cancelModifyProduct";
            this.cancelModifyProduct.Size = new System.Drawing.Size(75, 40);
            this.cancelModifyProduct.TabIndex = 19;
            this.cancelModifyProduct.Text = "Cancel";
            this.cancelModifyProduct.UseVisualStyleBackColor = false;
            this.cancelModifyProduct.Click += new System.EventHandler(this.CancelModifiedProductButton_Click);
            // 
            // candidatePartsGroupBox
            // 
            this.candidatePartsGroupBox.AutoSize = true;
            this.candidatePartsGroupBox.Controls.Add(this.searchCandidatePartsTextBox);
            this.candidatePartsGroupBox.Controls.Add(this.searchCandidatePartsButton);
            this.candidatePartsGroupBox.Controls.Add(this.addAssociatedPartButton);
            this.candidatePartsGroupBox.Controls.Add(this.candidatePartsDataGridView);
            this.candidatePartsGroupBox.Controls.Add(this.candidatePartsLabel);
            this.candidatePartsGroupBox.Location = new System.Drawing.Point(464, 12);
            this.candidatePartsGroupBox.Name = "candidatePartsGroupBox";
            this.candidatePartsGroupBox.Size = new System.Drawing.Size(749, 367);
            this.candidatePartsGroupBox.TabIndex = 1;
            this.candidatePartsGroupBox.TabStop = false;
            // 
            // searchCandidatePartsTextBox
            // 
            this.searchCandidatePartsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchCandidatePartsTextBox.Location = new System.Drawing.Point(439, 21);
            this.searchCandidatePartsTextBox.Multiline = true;
            this.searchCandidatePartsTextBox.Name = "searchCandidatePartsTextBox";
            this.searchCandidatePartsTextBox.Size = new System.Drawing.Size(292, 28);
            this.searchCandidatePartsTextBox.TabIndex = 9;
            this.searchCandidatePartsTextBox.TextChanged += new System.EventHandler(this.SearchCandidatePartsTextBox_TextChanged);
            this.searchCandidatePartsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCandidatePartsTextBox_KeyDown);
            // 
            // searchCandidatePartsButton
            // 
            this.searchCandidatePartsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchCandidatePartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCandidatePartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchCandidatePartsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchCandidatePartsButton.Location = new System.Drawing.Point(368, 21);
            this.searchCandidatePartsButton.Name = "searchCandidatePartsButton";
            this.searchCandidatePartsButton.Size = new System.Drawing.Size(65, 30);
            this.searchCandidatePartsButton.TabIndex = 8;
            this.searchCandidatePartsButton.Text = "Search";
            this.searchCandidatePartsButton.UseVisualStyleBackColor = false;
            this.searchCandidatePartsButton.Click += new System.EventHandler(this.SearchCandidatePartsButton_Click);
            // 
            // addAssociatedPartButton
            // 
            this.addAssociatedPartButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addAssociatedPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssociatedPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addAssociatedPartButton.Location = new System.Drawing.Point(656, 308);
            this.addAssociatedPartButton.Name = "addAssociatedPartButton";
            this.addAssociatedPartButton.Size = new System.Drawing.Size(75, 40);
            this.addAssociatedPartButton.TabIndex = 19;
            this.addAssociatedPartButton.Text = "Add";
            this.addAssociatedPartButton.UseVisualStyleBackColor = false;
            this.addAssociatedPartButton.Click += new System.EventHandler(this.AddAssociatedPartButton_Click);
            // 
            // candidatePartsDataGridView
            // 
            this.candidatePartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidatePartIDColumn,
            this.candidatePartNameColumn,
            this.candidatePartInventoryColumn,
            this.candidatePartPriceColumn,
            this.candidatePartMinColumn,
            this.candidatePartMaxColumn});
            this.candidatePartsDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.candidatePartsDataGridView.Location = new System.Drawing.Point(0, 67);
            this.candidatePartsDataGridView.Name = "candidatePartsDataGridView";
            this.candidatePartsDataGridView.RowHeadersVisible = false;
            this.candidatePartsDataGridView.RowHeadersWidth = 51;
            this.candidatePartsDataGridView.Size = new System.Drawing.Size(743, 235);
            this.candidatePartsDataGridView.TabIndex = 0;
            // 
            // candidatePartIDColumn
            // 
            this.candidatePartIDColumn.HeaderText = "Part ID";
            this.candidatePartIDColumn.MinimumWidth = 6;
            this.candidatePartIDColumn.Name = "candidatePartIDColumn";
            this.candidatePartIDColumn.Width = 105;
            // 
            // candidatePartNameColumn
            // 
            this.candidatePartNameColumn.HeaderText = "Name";
            this.candidatePartNameColumn.MinimumWidth = 6;
            this.candidatePartNameColumn.Name = "candidatePartNameColumn";
            this.candidatePartNameColumn.Width = 215;
            // 
            // candidatePartInventoryColumn
            // 
            this.candidatePartInventoryColumn.HeaderText = "Inventory";
            this.candidatePartInventoryColumn.MinimumWidth = 6;
            this.candidatePartInventoryColumn.Name = "candidatePartInventoryColumn";
            this.candidatePartInventoryColumn.Width = 105;
            // 
            // candidatePartPriceColumn
            // 
            this.candidatePartPriceColumn.HeaderText = "Price";
            this.candidatePartPriceColumn.MinimumWidth = 6;
            this.candidatePartPriceColumn.Name = "candidatePartPriceColumn";
            this.candidatePartPriceColumn.Width = 105;
            // 
            // candidatePartMinColumn
            // 
            this.candidatePartMinColumn.HeaderText = "Min";
            this.candidatePartMinColumn.MinimumWidth = 6;
            this.candidatePartMinColumn.Name = "candidatePartMinColumn";
            this.candidatePartMinColumn.Width = 105;
            // 
            // candidatePartMaxColumn
            // 
            this.candidatePartMaxColumn.HeaderText = "Max";
            this.candidatePartMaxColumn.MinimumWidth = 6;
            this.candidatePartMaxColumn.Name = "candidatePartMaxColumn";
            this.candidatePartMaxColumn.Width = 105;
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.candidatePartsLabel.Location = new System.Drawing.Point(6, 28);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(144, 20);
            this.candidatePartsLabel.TabIndex = 0;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // associatedPartsGroupBox
            // 
            this.associatedPartsGroupBox.AutoSize = true;
            this.associatedPartsGroupBox.Controls.Add(this.associatedPartsDataGridView);
            this.associatedPartsGroupBox.Controls.Add(this.deleteAssociatedPart);
            this.associatedPartsGroupBox.Controls.Add(this.associatedPartsLabel);
            this.associatedPartsGroupBox.Location = new System.Drawing.Point(464, 392);
            this.associatedPartsGroupBox.Name = "associatedPartsGroupBox";
            this.associatedPartsGroupBox.Size = new System.Drawing.Size(749, 367);
            this.associatedPartsGroupBox.TabIndex = 20;
            this.associatedPartsGroupBox.TabStop = false;
            // 
            // associatedPartsDataGridView
            // 
            this.associatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.associatedPartIdColumn,
            this.associatedPartNameColumn,
            this.associatedPartInventoryColumn,
            this.associatedPartPriceColumn,
            this.associatedPartMinColumn,
            this.associatedPartMaxColumn});
            this.associatedPartsDataGridView.EnableHeadersVisualStyles = false;
            this.associatedPartsDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.associatedPartsDataGridView.Location = new System.Drawing.Point(0, 67);
            this.associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            this.associatedPartsDataGridView.RowHeadersVisible = false;
            this.associatedPartsDataGridView.RowHeadersWidth = 51;
            this.associatedPartsDataGridView.Size = new System.Drawing.Size(743, 235);
            this.associatedPartsDataGridView.TabIndex = 0;
            // 
            // associatedPartIdColumn
            // 
            this.associatedPartIdColumn.HeaderText = "Part ID";
            this.associatedPartIdColumn.MinimumWidth = 6;
            this.associatedPartIdColumn.Name = "associatedPartIdColumn";
            this.associatedPartIdColumn.Width = 105;
            // 
            // associatedPartNameColumn
            // 
            this.associatedPartNameColumn.HeaderText = "Name";
            this.associatedPartNameColumn.MinimumWidth = 6;
            this.associatedPartNameColumn.Name = "associatedPartNameColumn";
            this.associatedPartNameColumn.Width = 215;
            // 
            // associatedPartInventoryColumn
            // 
            this.associatedPartInventoryColumn.HeaderText = "Inventory";
            this.associatedPartInventoryColumn.MinimumWidth = 6;
            this.associatedPartInventoryColumn.Name = "associatedPartInventoryColumn";
            this.associatedPartInventoryColumn.Width = 105;
            // 
            // associatedPartPriceColumn
            // 
            this.associatedPartPriceColumn.HeaderText = "Price";
            this.associatedPartPriceColumn.MinimumWidth = 6;
            this.associatedPartPriceColumn.Name = "associatedPartPriceColumn";
            this.associatedPartPriceColumn.Width = 105;
            // 
            // associatedPartMinColumn
            // 
            this.associatedPartMinColumn.HeaderText = "Min";
            this.associatedPartMinColumn.MinimumWidth = 6;
            this.associatedPartMinColumn.Name = "associatedPartMinColumn";
            this.associatedPartMinColumn.Width = 105;
            // 
            // associatedPartMaxColumn
            // 
            this.associatedPartMaxColumn.HeaderText = "Max";
            this.associatedPartMaxColumn.MinimumWidth = 6;
            this.associatedPartMaxColumn.Name = "associatedPartMaxColumn";
            this.associatedPartMaxColumn.Width = 105;
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.associatedPartsLabel.Location = new System.Drawing.Point(6, 28);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(247, 20);
            this.associatedPartsLabel.TabIndex = 0;
            this.associatedPartsLabel.Text = "Parts Associated with the Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 877);
            this.Controls.Add(this.associatedPartsGroupBox);
            this.Controls.Add(this.candidatePartsGroupBox);
            this.Controls.Add(this.cancelModifyProduct);
            this.Controls.Add(this.saveModifiedProduct);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.modifyProductLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.candidatePartsGroupBox.ResumeLayout(false);
            this.candidatePartsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGridView)).EndInit();
            this.associatedPartsGroupBox.ResumeLayout(false);
            this.associatedPartsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        // Candidate Parts Container
        private System.Windows.Forms.GroupBox candidatePartsGroupBox;
        private System.Windows.Forms.Label candidatePartsLabel;

        // Candidate Parts Search
        private System.Windows.Forms.TextBox searchCandidatePartsTextBox;
        private System.Windows.Forms.Button searchCandidatePartsButton;

        // Candidate Parts Action Buttons  
        private System.Windows.Forms.Button addAssociatedPartButton;

        // Candidate Parts DataGrid
        private System.Windows.Forms.DataGridView candidatePartsDataGridView;

        // Others
        private System.Windows.Forms.Label modifyProductLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Button saveModifiedProduct;
        private System.Windows.Forms.Button deleteAssociatedPart;
        private System.Windows.Forms.Button cancelModifyProduct;
        private System.Windows.Forms.GroupBox associatedPartsGroupBox;
        private System.Windows.Forms.DataGridView associatedPartsDataGridView;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatePartIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatePartNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatePartInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatePartPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatePartMinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatePartMaxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn associatedPartIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn associatedPartNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn associatedPartInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn associatedPartPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn associatedPartMinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn associatedPartMaxColumn;
    }
}