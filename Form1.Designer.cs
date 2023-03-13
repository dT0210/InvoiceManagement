namespace InvoiceManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.invoiceBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.invScreen1 = new InvoiceManagement.invScreen();
            this.prodScreen1 = new InvoiceManagement.prodScreen();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.invoiceBtn);
            this.mainPanel.Controls.Add(this.productBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(656, 477);
            this.mainPanel.TabIndex = 2;
            // 
            // invoiceBtn
            // 
            this.invoiceBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.invoiceBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invoiceBtn.Location = new System.Drawing.Point(349, 46);
            this.invoiceBtn.Name = "invoiceBtn";
            this.invoiceBtn.Size = new System.Drawing.Size(276, 391);
            this.invoiceBtn.TabIndex = 1;
            this.invoiceBtn.Text = "Invoice";
            this.invoiceBtn.UseVisualStyleBackColor = false;
            this.invoiceBtn.Click += new System.EventHandler(this.invoiceBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.productBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productBtn.Location = new System.Drawing.Point(35, 46);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(276, 391);
            this.productBtn.TabIndex = 0;
            this.productBtn.Text = "Product";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // invScreen1
            // 
            this.invScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invScreen1.Location = new System.Drawing.Point(0, 0);
            this.invScreen1.Name = "invScreen1";
            this.invScreen1.Size = new System.Drawing.Size(656, 477);
            this.invScreen1.TabIndex = 2;
            // 
            // prodScreen1
            // 
            this.prodScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodScreen1.Location = new System.Drawing.Point(0, 0);
            this.prodScreen1.Name = "prodScreen1";
            this.prodScreen1.Size = new System.Drawing.Size(656, 477);
            this.prodScreen1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 477);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.invScreen1);
            this.Controls.Add(this.prodScreen1);
            this.Name = "Form1";
            this.Text = "Products Management";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel mainPanel;
        private Button invoiceBtn;
        private Button productBtn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private invScreen invScreen1;
        private prodScreen prodScreen1;
    }
}