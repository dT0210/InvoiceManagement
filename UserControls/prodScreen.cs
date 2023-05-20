using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class prodScreen : UserControl
    {

        public prodScreen()
        {
            InitializeComponent();
        }

        private void prodScreen_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            string connectionString =
                            "Server=MORNINGSTAR\\SQLEXPRESS;" +
                            "Database=InvoiceProject;" +
                            "User Id=dthanh;" +
                            "Password=123321;" +
                            "TrustServerCertificate=True;";
            string queryString = "getProductData";
            DataTable prodData = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(queryString, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        prodData.Load(reader);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
            prodDataGrid.DataSource = prodData;
            prodDataGrid.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prodDataGrid.Columns["Product Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prodDataGrid.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prodDataGrid.Columns["Unit Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prodDataGrid.Columns["Unit Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prodDataGrid.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prodDataGrid.Columns["Unit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prodDataGrid.Columns[0].Width = 95;
            prodDataGrid.Columns[1].Width = 175;
            prodDataGrid.Columns[3].Width = 110;
            prodDataGrid.Columns[4].Width = 60;
        }

        private void prodData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, name, unit, unitPrice, quantity;
            id = prodDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            name = prodDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            unit = prodDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            unitPrice = prodDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            quantity = prodDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            prodDetails details = new prodDetails(id, name, unit, unitPrice, quantity);
            details.ShowDialog();
            loadData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            formImportProducts f = new formImportProducts();
            f.ShowDialog();
            loadData();
        }

        private void importHistoryButton_Click(object sender, EventArgs e)
        {
            formImportHistory f = new formImportHistory();
            f.ShowDialog();
        }
    }
}
