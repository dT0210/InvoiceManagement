namespace InvoiceManagement
{
    partial class formImportHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplyDateButton = new System.Windows.Forms.Button();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.importDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApplyDateButton);
            this.groupBox1.Controls.Add(this.toDateLabel);
            this.groupBox1.Controls.Add(this.fromDateLabel);
            this.groupBox1.Controls.Add(this.toDatePicker);
            this.groupBox1.Controls.Add(this.fromDatePicker);
            this.groupBox1.Controls.Add(this.importDataGrid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 398);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import History";
            // 
            // ApplyDateButton
            // 
            this.ApplyDateButton.Location = new System.Drawing.Point(520, 367);
            this.ApplyDateButton.Name = "ApplyDateButton";
            this.ApplyDateButton.Size = new System.Drawing.Size(69, 25);
            this.ApplyDateButton.TabIndex = 7;
            this.ApplyDateButton.Text = "Apply";
            this.ApplyDateButton.UseVisualStyleBackColor = true;
            this.ApplyDateButton.Click += new System.EventHandler(this.ApplyDateButton_Click);
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDateLabel.Location = new System.Drawing.Point(298, 371);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(28, 20);
            this.toDateLabel.TabIndex = 6;
            this.toDateLabel.Text = "To:";
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromDateLabel.Location = new System.Drawing.Point(6, 372);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(46, 20);
            this.fromDateLabel.TabIndex = 5;
            this.fromDateLabel.Text = "From:";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(334, 367);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(106, 25);
            this.toDatePicker.TabIndex = 4;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(58, 368);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(106, 25);
            this.fromDatePicker.TabIndex = 3;
            // 
            // importDataGrid
            // 
            this.importDataGrid.AllowUserToAddRows = false;
            this.importDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importDataGrid.Location = new System.Drawing.Point(6, 22);
            this.importDataGrid.MultiSelect = false;
            this.importDataGrid.Name = "importDataGrid";
            this.importDataGrid.ReadOnly = true;
            this.importDataGrid.RowTemplate.Height = 25;
            this.importDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.importDataGrid.Size = new System.Drawing.Size(583, 326);
            this.importDataGrid.TabIndex = 2;
            this.importDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.importDataGrid_CellDoubleClick);
            // 
            // formImportHistory
            // 
            this.ClientSize = new System.Drawing.Size(646, 440);
            this.Controls.Add(this.groupBox1);
            this.Name = "formImportHistory";
            this.Text = "Import History";
            this.Load += new System.EventHandler(this.formImportHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button ApplyDateButton;
        private Label toDateLabel;
        private Label fromDateLabel;
        private DateTimePicker toDatePicker;
        private DateTimePicker fromDatePicker;
        private DataGridView importDataGrid;
    }
}