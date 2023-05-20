namespace InvoiceManagement
{
    partial class invScreen
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
            this.invData = new System.Windows.Forms.DataGridView();
            this.createInvBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplyDateButton = new System.Windows.Forms.Button();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // invData
            // 
            this.invData.AllowUserToAddRows = false;
            this.invData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invData.Location = new System.Drawing.Point(6, 22);
            this.invData.MultiSelect = false;
            this.invData.Name = "invData";
            this.invData.ReadOnly = true;
            this.invData.RowTemplate.Height = 25;
            this.invData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invData.Size = new System.Drawing.Size(583, 326);
            this.invData.TabIndex = 2;
            this.invData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invData_CellDoubleClick);
            // 
            // createInvBtn
            // 
            this.createInvBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createInvBtn.Location = new System.Drawing.Point(492, 14);
            this.createInvBtn.Name = "createInvBtn";
            this.createInvBtn.Size = new System.Drawing.Size(118, 36);
            this.createInvBtn.TabIndex = 3;
            this.createInvBtn.Text = "Create Invoice";
            this.createInvBtn.UseVisualStyleBackColor = true;
            this.createInvBtn.Click += new System.EventHandler(this.createInvBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApplyDateButton);
            this.groupBox1.Controls.Add(this.toDateLabel);
            this.groupBox1.Controls.Add(this.fromDateLabel);
            this.groupBox1.Controls.Add(this.toDatePicker);
            this.groupBox1.Controls.Add(this.fromDatePicker);
            this.groupBox1.Controls.Add(this.invData);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(21, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 398);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice list";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.createInvBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 60);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Invoice";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(27, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(61, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // invScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "invScreen";
            this.Size = new System.Drawing.Size(656, 477);
            this.Load += new System.EventHandler(this.invScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView invData;
        private Button createInvBtn;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button backButton;
        private Label label1;
        private Button ApplyDateButton;
        private Label toDateLabel;
        private Label fromDateLabel;
        private DateTimePicker toDatePicker;
        private DateTimePicker fromDatePicker;
    }
}
