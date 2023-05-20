namespace InvoiceManagement
{
    partial class prodScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prodDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.importButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.importHistoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodDataGrid
            // 
            this.prodDataGrid.AllowUserToAddRows = false;
            this.prodDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGrid.Location = new System.Drawing.Point(6, 22);
            this.prodDataGrid.MultiSelect = false;
            this.prodDataGrid.Name = "prodDataGrid";
            this.prodDataGrid.ReadOnly = true;
            this.prodDataGrid.RowTemplate.Height = 25;
            this.prodDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDataGrid.Size = new System.Drawing.Size(583, 314);
            this.prodDataGrid.TabIndex = 1;
            this.prodDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodData_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prodDataGrid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(34, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(61, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 60);
            this.panel1.TabIndex = 4;
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importButton.Location = new System.Drawing.Point(483, 14);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(134, 36);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import Product";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product";
            // 
            // importHistoryButton
            // 
            this.importHistoryButton.Location = new System.Drawing.Point(520, 435);
            this.importHistoryButton.Name = "importHistoryButton";
            this.importHistoryButton.Size = new System.Drawing.Size(97, 23);
            this.importHistoryButton.TabIndex = 5;
            this.importHistoryButton.Text = "Import History";
            this.importHistoryButton.UseVisualStyleBackColor = true;
            this.importHistoryButton.Click += new System.EventHandler(this.importHistoryButton_Click);
            // 
            // prodScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.importHistoryButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "prodScreen";
            this.Size = new System.Drawing.Size(656, 477);
            this.Load += new System.EventHandler(this.prodScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView prodDataGrid;
        private GroupBox groupBox1;
        private Button backButton;
        private Panel panel1;
        private Label label1;
        private Button importButton;
        private Button importHistoryButton;
    }
}
