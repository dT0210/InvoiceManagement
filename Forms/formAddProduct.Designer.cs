namespace InvoiceManagement
{
    partial class formAddProduct
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
            this.idInputBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitInputBox = new System.Windows.Forms.TextBox();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.unitPriceInputBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityInputBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idInputBox
            // 
            this.idInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idInputBox.Location = new System.Drawing.Point(170, 66);
            this.idInputBox.Name = "idInputBox";
            this.idInputBox.Size = new System.Drawing.Size(114, 29);
            this.idInputBox.TabIndex = 0;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(54, 69);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(83, 21);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Product ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(54, 140);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 21);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Product Name";
            // 
            // nameInputBox
            // 
            this.nameInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInputBox.Location = new System.Drawing.Point(170, 137);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(184, 29);
            this.nameInputBox.TabIndex = 2;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitLabel.Location = new System.Drawing.Point(399, 69);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(39, 21);
            this.unitLabel.TabIndex = 5;
            this.unitLabel.Text = "Unit";
            // 
            // unitInputBox
            // 
            this.unitInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitInputBox.Location = new System.Drawing.Point(515, 66);
            this.unitInputBox.Name = "unitInputBox";
            this.unitInputBox.Size = new System.Drawing.Size(114, 29);
            this.unitInputBox.TabIndex = 4;
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitPriceLabel.Location = new System.Drawing.Point(399, 140);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(77, 21);
            this.unitPriceLabel.TabIndex = 7;
            this.unitPriceLabel.Text = "Unit Price";
            // 
            // unitPriceInputBox
            // 
            this.unitPriceInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitPriceInputBox.Location = new System.Drawing.Point(515, 137);
            this.unitPriceInputBox.Name = "unitPriceInputBox";
            this.unitPriceInputBox.Size = new System.Drawing.Size(114, 29);
            this.unitPriceInputBox.TabIndex = 6;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(54, 214);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(70, 21);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityInputBox
            // 
            this.quantityInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityInputBox.Location = new System.Drawing.Point(170, 211);
            this.quantityInputBox.Name = "quantityInputBox";
            this.quantityInputBox.ReadOnly = true;
            this.quantityInputBox.Size = new System.Drawing.Size(114, 29);
            this.quantityInputBox.TabIndex = 8;
            this.quantityInputBox.Text = "0";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(170, 277);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(89, 42);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(399, 277);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 42);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // formAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 356);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityInputBox);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.unitPriceInputBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.unitInputBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idInputBox);
            this.Name = "formAddProduct";
            this.Text = "Add product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox idInputBox;
        private Label idLabel;
        private Label nameLabel;
        private TextBox nameInputBox;
        private Label unitLabel;
        private TextBox unitInputBox;
        private Label unitPriceLabel;
        private TextBox unitPriceInputBox;
        private Label quantityLabel;
        private TextBox quantityInputBox;
        private Button AddBtn;
        private Button cancelBtn;
    }
}