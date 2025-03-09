using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InventorySystem
{
    partial class MainForm
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
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchPartsTextBox = new System.Windows.Forms.TextBox();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.partIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchProductsTextBox = new System.Windows.Forms.TextBox();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.productIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.partsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.Location = new System.Drawing.Point(3, 9);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(256, 20);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "Inventory Management System\r\n";
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.AutoSize = true;
            this.partsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.partsGroupBox.Controls.Add(this.searchPartsTextBox);
            this.partsGroupBox.Controls.Add(this.searchPartsButton);
            this.partsGroupBox.Controls.Add(this.deletePartButton);
            this.partsGroupBox.Controls.Add(this.modifyPartButton);
            this.partsGroupBox.Controls.Add(this.addPartButton);
            this.partsGroupBox.Controls.Add(this.partsDataGridView);
            this.partsGroupBox.Controls.Add(this.partsLabel);
            this.partsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partsGroupBox.Location = new System.Drawing.Point(7, 47);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(616, 372);
            this.partsGroupBox.TabIndex = 1;
            this.partsGroupBox.TabStop = false;
            // 
            // searchPartsTextBox
            // 
            this.searchPartsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchPartsTextBox.Location = new System.Drawing.Point(394, 20);
            this.searchPartsTextBox.Multiline = true;
            this.searchPartsTextBox.Name = "searchPartsTextBox";
            this.searchPartsTextBox.Size = new System.Drawing.Size(216, 28);
            this.searchPartsTextBox.TabIndex = 9;
            this.searchPartsTextBox.TextChanged += new System.EventHandler(this.SearchPartsTextBox_TextChanged);
            this.searchPartsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchPartsTextBox_KeyDown);
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchPartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchPartsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchPartsButton.Location = new System.Drawing.Point(323, 19);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(65, 30);
            this.searchPartsButton.TabIndex = 8;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = false;
            this.searchPartsButton.Click += new System.EventHandler(this.SearchPartsButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deletePartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletePartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deletePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deletePartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deletePartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletePartButton.Location = new System.Drawing.Point(544, 323);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(65, 30);
            this.deletePartButton.TabIndex = 7;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = false;
            this.deletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifyPartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.modifyPartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.modifyPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.modifyPartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modifyPartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modifyPartButton.Location = new System.Drawing.Point(473, 323);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(65, 30);
            this.modifyPartButton.TabIndex = 6;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = false;
            this.modifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addPartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addPartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addPartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPartButton.Location = new System.Drawing.Point(402, 323);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(65, 30);
            this.addPartButton.TabIndex = 5;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = false;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDColumn,
            this.partNameColumn,
            this.partInventoryColumn,
            this.partPriceColumn,
            this.partMinColumn,
            this.partMaxColumn});
            this.partsDataGridView.Location = new System.Drawing.Point(5, 69);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidth = 51;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(605, 235);
            this.partsDataGridView.TabIndex = 0;
            // 
            // partIDColumn
            // 
            this.partIDColumn.DataPropertyName = "PartID";
            this.partIDColumn.HeaderText = "Part ID";
            this.partIDColumn.MinimumWidth = 6;
            this.partIDColumn.Name = "partIDColumn";
            this.partIDColumn.ReadOnly = true;
            this.partIDColumn.Width = 90;
            // 
            // partNameColumn
            // 
            this.partNameColumn.DataPropertyName = "Name";
            this.partNameColumn.HeaderText = "Name";
            this.partNameColumn.MinimumWidth = 6;
            this.partNameColumn.Name = "partNameColumn";
            this.partNameColumn.ReadOnly = true;
            this.partNameColumn.Width = 152;
            // 
            // partInventoryColumn
            // 
            this.partInventoryColumn.DataPropertyName = "InStock";
            this.partInventoryColumn.HeaderText = "Inventory";
            this.partInventoryColumn.MinimumWidth = 6;
            this.partInventoryColumn.Name = "partInventoryColumn";
            this.partInventoryColumn.ReadOnly = true;
            this.partInventoryColumn.Width = 90;
            // 
            // partPriceColumn
            // 
            this.partPriceColumn.DataPropertyName = "Price";
            this.partPriceColumn.HeaderText = "Price";
            this.partPriceColumn.MinimumWidth = 6;
            this.partPriceColumn.Name = "partPriceColumn";
            this.partPriceColumn.ReadOnly = true;
            this.partPriceColumn.Width = 90;
            // 
            // partMinColumn
            // 
            this.partMinColumn.DataPropertyName = "Min";
            this.partMinColumn.HeaderText = "Min";
            this.partMinColumn.MinimumWidth = 6;
            this.partMinColumn.Name = "partMinColumn";
            this.partMinColumn.ReadOnly = true;
            this.partMinColumn.Width = 90;
            // 
            // partMaxColumn
            // 
            this.partMaxColumn.DataPropertyName = "Max";
            this.partMaxColumn.HeaderText = "Max";
            this.partMaxColumn.MinimumWidth = 6;
            this.partMaxColumn.Name = "partMaxColumn";
            this.partMaxColumn.ReadOnly = true;
            this.partMaxColumn.Width = 90;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partsLabel.Location = new System.Drawing.Point(1, 37);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 20);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts";
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.AutoSize = true;
            this.productsGroupBox.Controls.Add(this.searchProductsTextBox);
            this.productsGroupBox.Controls.Add(this.searchProductsButton);
            this.productsGroupBox.Controls.Add(this.deleteProductButton);
            this.productsGroupBox.Controls.Add(this.modifyProductButton);
            this.productsGroupBox.Controls.Add(this.addProductButton);
            this.productsGroupBox.Controls.Add(this.productsDataGridView);
            this.productsGroupBox.Controls.Add(this.productsLabel);
            this.productsGroupBox.Location = new System.Drawing.Point(653, 47);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(616, 372);
            this.productsGroupBox.TabIndex = 2;
            this.productsGroupBox.TabStop = false;
            // 
            // searchProductsTextBox
            // 
            this.searchProductsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchProductsTextBox.Location = new System.Drawing.Point(394, 24);
            this.searchProductsTextBox.Multiline = true;
            this.searchProductsTextBox.Name = "searchProductsTextBox";
            this.searchProductsTextBox.Size = new System.Drawing.Size(215, 27);
            this.searchProductsTextBox.TabIndex = 12;
            this.searchProductsTextBox.TextChanged += new System.EventHandler(this.SearchProductsTextBox_TextChanged);
            this.searchProductsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductsTextBox_KeyDown);
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchProductsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchProductsButton.Location = new System.Drawing.Point(323, 23);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(65, 30);
            this.searchProductsButton.TabIndex = 11;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = false;
            this.searchProductsButton.Click += new System.EventHandler(this.SearchProductsButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteProductButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteProductButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteProductButton.Location = new System.Drawing.Point(544, 323);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(65, 30);
            this.deleteProductButton.TabIndex = 10;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifyProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.modifyProductButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.modifyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.modifyProductButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modifyProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modifyProductButton.Location = new System.Drawing.Point(473, 323);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(65, 30);
            this.modifyProductButton.TabIndex = 9;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = false;
            this.modifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addProductButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addProductButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addProductButton.Location = new System.Drawing.Point(402, 323);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(65, 30);
            this.addProductButton.TabIndex = 8;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDColumn,
            this.productNameColumn,
            this.productInventoryColumn,
            this.productPriceColumn,
            this.productMinColumn,
            this.productMaxColumn});
            this.productsDataGridView.Location = new System.Drawing.Point(6, 69);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(603, 235);
            this.productsDataGridView.TabIndex = 0;
            // 
            // productIDColumn
            // 
            this.productIDColumn.DataPropertyName = "ProductID";
            this.productIDColumn.HeaderText = "Product ID";
            this.productIDColumn.MinimumWidth = 6;
            this.productIDColumn.Name = "productIDColumn";
            this.productIDColumn.ReadOnly = true;
            this.productIDColumn.Width = 90;
            // 
            // productNameColumn
            // 
            this.productNameColumn.DataPropertyName = "Name";
            this.productNameColumn.HeaderText = "Name";
            this.productNameColumn.MinimumWidth = 6;
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.ReadOnly = true;
            this.productNameColumn.Width = 156;
            // 
            // productInventoryColumn
            // 
            this.productInventoryColumn.DataPropertyName = "InStock";
            this.productInventoryColumn.HeaderText = "Inventory";
            this.productInventoryColumn.MinimumWidth = 6;
            this.productInventoryColumn.Name = "productInventoryColumn";
            this.productInventoryColumn.ReadOnly = true;
            this.productInventoryColumn.Width = 90;
            // 
            // productPriceColumn
            // 
            this.productPriceColumn.DataPropertyName = "Price";
            this.productPriceColumn.HeaderText = "Price";
            this.productPriceColumn.MinimumWidth = 6;
            this.productPriceColumn.Name = "productPriceColumn";
            this.productPriceColumn.ReadOnly = true;
            this.productPriceColumn.Width = 90;
            // 
            // productMinColumn
            // 
            this.productMinColumn.DataPropertyName = "Min";
            this.productMinColumn.HeaderText = "Min";
            this.productMinColumn.MinimumWidth = 6;
            this.productMinColumn.Name = "productMinColumn";
            this.productMinColumn.ReadOnly = true;
            this.productMinColumn.Width = 90;
            // 
            // productMaxColumn
            // 
            this.productMaxColumn.DataPropertyName = "Max";
            this.productMaxColumn.HeaderText = "Max";
            this.productMaxColumn.MinimumWidth = 6;
            this.productMaxColumn.Name = "productMaxColumn";
            this.productMaxColumn.ReadOnly = true;
            this.productMaxColumn.Width = 84;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productsLabel.Location = new System.Drawing.Point(2, 37);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(72, 20);
            this.productsLabel.TabIndex = 3;
            this.productsLabel.Text = "Products";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.Location = new System.Drawing.Point(1197, 441);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 30);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1275, 482);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productsGroupBox);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.mainTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.productsGroupBox.ResumeLayout(false);
            this.productsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Main Form Title
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Button exitButton;


        // Parts Container
        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.Label partsLabel;

        // Parts Search
        private System.Windows.Forms.TextBox searchPartsTextBox;
        private System.Windows.Forms.Button searchPartsButton;

        // Parts Action Buttons  
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button deletePartButton;

        // Parts DataGrid
        private System.Windows.Forms.DataGridView partsDataGridView;


        // Products Container  
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.Label productsLabel;

        // Products Search
        private System.Windows.Forms.TextBox searchProductsTextBox;
        private System.Windows.Forms.Button searchProductsButton;

        // Products Action Buttons
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button deleteProductButton;

        // Products DataGrid
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMaxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn partIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMaxColumn;

    }
}