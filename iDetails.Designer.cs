namespace InvoiceManagement
{
    partial class iDetails
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
            this.invDetailsGrid = new System.Windows.Forms.DataGridView();
            this.IDLabel = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invDetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // invDetailsGrid
            // 
            this.invDetailsGrid.AllowUserToAddRows = false;
            this.invDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invDetailsGrid.Location = new System.Drawing.Point(37, 59);
            this.invDetailsGrid.Name = "invDetailsGrid";
            this.invDetailsGrid.ReadOnly = true;
            this.invDetailsGrid.RowTemplate.Height = 25;
            this.invDetailsGrid.Size = new System.Drawing.Size(694, 265);
            this.invDetailsGrid.TabIndex = 0;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(37, 18);
            this.IDLabel.Name = "invIDLabel";
            this.IDLabel.Size = new System.Drawing.Size(95, 25);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "Invoice ID";
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimeLabel.Location = new System.Drawing.Point(253, 18);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(134, 25);
            this.DateTimeLabel.TabIndex = 2;
            this.DateTimeLabel.Text = "Date and Time";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(653, 16);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(78, 30);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(37, 322);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(595, 25);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Total";
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TotalValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalValueLabel.Location = new System.Drawing.Point(631, 322);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalValueLabel.Size = new System.Drawing.Size(100, 25);
            this.TotalValueLabel.TabIndex = 5;
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportButton.Location = new System.Drawing.Point(554, 16);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(78, 30);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // invDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(759, 366);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.TotalValueLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.invDetailsGrid);
            this.Name = "invDetails";
            this.Text = "invDetails";
            this.Load += new System.EventHandler(this.invDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invDetailsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView invDetailsGrid;
        private Label IDLabel;
        private Label DateTimeLabel;
        private Button DeleteBtn;
        private Label TotalLabel;
        private Label TotalValueLabel;
        private Button exportButton;
    }
}