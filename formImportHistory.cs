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
    public partial class formImportHistory : Form
    {
        DataTable importData = new DataTable();
        public formImportHistory()
        {
            InitializeComponent();
        }

        private void formImportHistory_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string connectionString =
                            "Server=MORNINGSTAR\\SQLEXPRESS;" +
                            "Database=InvoiceProject;" +
                            "User Id=dthanh;" +
                            "Password=123321;" +
                            "TrustServerCertificate=True;";
            string queryString = "getImportHistory";
            importData.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(queryString, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        importData.Load(reader);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
            DataView dv = new DataView(importData);
            DateTime today = DateTime.Today;
            fromDatePicker.Value = today;
            toDatePicker.Value = today;
            dv.RowFilter = string.Format("[Date and time] >= #{0:yyyy/MM/dd}# And [Date and time] <= #{1:yyyy/MM/dd}#", today, today.AddDays(1));
            importDataGrid.DataSource = dv;
            importDataGrid.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            importDataGrid.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            importDataGrid.Columns[1].Width = 250;
            importDataGrid.Columns[2].Width = 190;
        }

        private void ApplyDateButton_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(importData);
            dv.RowFilter = string.Format("[Date and time] >= #{0:yyyy/MM/dd}# And [Date and time] <= #{1:yyyy/MM/dd}#", fromDatePicker.Value, toDatePicker.Value.AddDays(1));
            importDataGrid.DataSource = dv;
            importDataGrid.Refresh();
        }

        private void importDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            iDetails details = new iDetails("Import", importDataGrid.SelectedRows[0].Cells[0].Value.ToString(), importDataGrid.SelectedRows[0].Cells[1].Value.ToString());
            details.ShowDialog();
            loadData();
        }
    }
}
