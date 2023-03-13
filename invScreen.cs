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
    [ToolboxItem(true)]
    public partial class invScreen : UserControl
    {
        DataTable allData = new DataTable();
        public invScreen()
        {
            InitializeComponent();
        }

        private void invScreen_Load(object sender, EventArgs e)
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
            string queryString = "getAllInvoice";
            allData.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(queryString, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        allData.Load(reader);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
            DataView dv = new DataView(allData);
            DateTime today = DateTime.Today;
            fromDatePicker.Value = today;
            toDatePicker.Value = today;
            dv.RowFilter = string.Format("[Date and time] >= #{0:yyyy/MM/dd}# And [Date and time] <= #{1:yyyy/MM/dd}#", today, today.AddDays(1));
            invData.DataSource = dv;
            invData.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            invData.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            invData.Columns[1].Width = 250;
            invData.Columns[2].Width = 190;
        }

        private void invData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            iDetails details = new iDetails("Invoice", invData.SelectedRows[0].Cells[0].Value.ToString(), invData.SelectedRows[0].Cells[1].Value.ToString());
            details.ShowDialog();
            loadData();
        }

        private void createInvBtn_Click(object sender, EventArgs e)
        {
            formCreateInvoice f = new formCreateInvoice();
            f.ShowDialog();
            loadData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void ApplyDateButton_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(allData);
            dv.RowFilter = string.Format("[Date and time] >= #{0:yyyy/MM/dd}# And [Date and time] <= #{1:yyyy/MM/dd}#", fromDatePicker.Value, toDatePicker.Value.AddDays(1));
            invData.DataSource = dv;
            invData.Refresh();
        }
    }
}
