using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class iDetails : Form
    {
        string connectionString =
                            "Server=MORNINGSTAR\\SQLEXPRESS;" +
                            "Database=InvoiceProject;" +
                            "User Id=dthanh;" +
                            "Password=123321;" +
                            "TrustServerCertificate=True;";
        string queryString = "";
        DataTable data = new DataTable();
        string type = string.Empty;
        public iDetails(string type, string ID, string dateTime)
        {
            InitializeComponent();
            this.type = type;
            IDLabel.Text = ID;
            DateTimeLabel.Text = dateTime;
            this.Text = type + " details";
        }

        private void invDetails_Load(object sender, EventArgs e)
        {
            queryString = "get" + type;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(queryString, connection))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = IDLabel.Text;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        data.Load(reader);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            invDetailsGrid.DataSource = data;
            invDetailsGrid.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            invDetailsGrid.Columns["Amount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            invDetailsGrid.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invDetailsGrid.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invDetailsGrid.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invDetailsGrid.Columns["Unit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invDetailsGrid.Columns["Unit Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            invDetailsGrid.Columns["Unit Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invDetailsGrid.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invDetailsGrid.Columns["Discount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invDetailsGrid.Columns["Product ID"].Width = 90;
            invDetailsGrid.Columns["Product Name"].Width = 150;
            invDetailsGrid.Columns[2].Width = 80;
            invDetailsGrid.Columns[4].Width = 60;
            invDetailsGrid.Columns[5].Width = 70;
            float total = 0;
            foreach (DataGridViewRow row in invDetailsGrid.Rows)
            {
                Decimal discount = (Decimal)row.Cells["Discount"].Value;
                row.Cells["Discount"].Value = Math.Round(discount * 100);
                total += float.Parse(row.Cells["Amount"].Value.ToString());
            }
            TotalValueLabel.Text = total.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                queryString = "delete" + type;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(queryString, connection))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = IDLabel.Text;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                }
                MessageBox.Show("Successfully deleted.");
                this.Close();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = type + " " + IDLabel.Text + " - " + DateTimeLabel.Text + ".xlsx";
                savefile.Filter = "Excel Files|*.xlsx;*.xlsm;*.xltx;*.xltm";
                if (data.Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(data, type + " " + IDLabel.Text);
                                workbook.SaveAs(savefile.FileName);
                            }
                            MessageBox.Show("Successfully exported to an excel file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
