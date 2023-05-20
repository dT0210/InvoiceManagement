namespace InvoiceManagement
{
    partial class prodDetails
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityInputBox = new System.Windows.Forms.TextBox();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.unitPriceInputBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitInputBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.productImportBox = new System.Windows.Forms.GroupBox();
            this.productImportDataGrid = new System.Windows.Forms.DataGridView();
            this.productGroupBox.SuspendLayout();
            this.productImportBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(440, 328);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 30);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(116, 328);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(89, 30);
            this.UpdateBtn.TabIndex = 22;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(38, 86);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(70, 21);
            this.quantityLabel.TabIndex = 21;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityInputBox
            // 
            this.quantityInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityInputBox.Location = new System.Drawing.Point(154, 83);
            this.quantityInputBox.Name = "quantityInputBox";
            this.quantityInputBox.ReadOnly = true;
            this.quantityInputBox.Size = new System.Drawing.Size(114, 29);
            this.quantityInputBox.TabIndex = 20;
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitPriceLabel.Location = new System.Drawing.Point(366, 86);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(77, 21);
            this.unitPriceLabel.TabIndex = 19;
            this.unitPriceLabel.Text = "Unit Price";
            // 
            // unitPriceInputBox
            // 
            this.unitPriceInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitPriceInputBox.Location = new System.Drawing.Point(461, 83);
            this.unitPriceInputBox.Name = "unitPriceInputBox";
            this.unitPriceInputBox.Size = new System.Drawing.Size(69, 29);
            this.unitPriceInputBox.TabIndex = 18;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitLabel.Location = new System.Drawing.Point(366, 36);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(39, 21);
            this.unitLabel.TabIndex = 17;
            this.unitLabel.Text = "Unit";
            // 
            // unitInputBox
            // 
            this.unitInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitInputBox.Location = new System.Drawing.Point(461, 33);
            this.unitInputBox.Name = "unitInputBox";
            this.unitInputBox.Size = new System.Drawing.Size(114, 29);
            this.unitInputBox.TabIndex = 16;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(38, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 21);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Product Name";
            // 
            // nameInputBox
            // 
            this.nameInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInputBox.Location = new System.Drawing.Point(154, 33);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(184, 29);
            this.nameInputBox.TabIndex = 14;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(278, 328);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(89, 30);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.nameInputBox);
            this.productGroupBox.Controls.Add(this.nameLabel);
            this.productGroupBox.Controls.Add(this.unitLabel);
            this.productGroupBox.Controls.Add(this.unitInputBox);
            this.productGroupBox.Controls.Add(this.quantityLabel);
            this.productGroupBox.Controls.Add(this.unitPriceInputBox);
            this.productGroupBox.Controls.Add(this.quantityInputBox);
            this.productGroupBox.Controls.Add(this.unitPriceLabel);
            this.productGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productGroupBox.Location = new System.Drawing.Point(12, 12);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(644, 131);
            this.productGroupBox.TabIndex = 25;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product ID";
            // 
            // productImportBox
            // 
            this.productImportBox.Controls.Add(this.productImportDataGrid);
            this.productImportBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productImportBox.Location = new System.Drawing.Point(12, 161);
            this.productImportBox.Name = "productImportBox";
            this.productImportBox.Size = new System.Drawing.Size(644, 151);
            this.productImportBox.TabIndex = 26;
            this.productImportBox.TabStop = false;
            this.productImportBox.Text = "Import History";
            // 
            // productImportDataGrid
            // 
            this.productImportDataGrid.AllowUserToAddRows = false;
            this.productImportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productImportDataGrid.Location = new System.Drawing.Point(6, 26);
            this.productImportDataGrid.Name = "productImportDataGrid";
            this.productImportDataGrid.ReadOnly = true;
            this.productImportDataGrid.RowTemplate.Height = 25;
            this.productImportDataGrid.Size = new System.Drawing.Size(632, 119);
            this.productImportDataGrid.TabIndex = 0;
            // 
            // prodDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 370);
            this.Controls.Add(this.productImportBox);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Name = "prodDetails";
            this.Text = "Product details";
            this.Load += new System.EventHandler(this.prodDetails_Load);
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            this.productImportBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productImportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button cancelBtn;
        private Button UpdateBtn;
        private Label quantityLabel;
        private TextBox quantityInputBox;
        private Label unitPriceLabel;
        private TextBox unitPriceInputBox;
        private Label unitLabel;
        private TextBox unitInputBox;
        private Label nameLabel;
        private TextBox nameInputBox;
        private Button DeleteBtn;
        private GroupBox productGroupBox;
        private GroupBox productImportBox;
        private DataGridView productImportDataGrid;
    }
}