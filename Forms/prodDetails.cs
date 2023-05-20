using DocumentFormat.OpenXml.Vml;
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
    public partial class prodDetails : Form
    {
        DataTable importData = new DataTable();
        string connectionString =
                            "Server=MORNINGSTAR\\SQLEXPRESS;" +
                            "Database=InvoiceProject;" +
                            "User Id=dthanh;" +
                            "Password=123321;" +
                            "TrustServerCertificate=True;";
        string queryString = "";
        public prodDetails(string id, string name, string unit, string unitPrice, string quantity)
        {
            InitializeComponent();
            productGroupBox.Text = id;
            nameInputBox.Text = name;
            unitInputBox.Text = unit;
            unitPriceInputBox.Text = unitPrice;
            quantityInputBox.Text = quantity;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (nameInputBox.Text == "")
            {
                MessageBox.Show("Product name is missing!", "Error");
            }
            else
            {
                try
                {
                    float price = float.Parse(unitPriceInputBox.Text);
                    try
                    {
                        queryString =
                            "update Product " +
                            "set prodName = @name, unit = @unit, unitPrice = @unitPrice " +
                            "where prodID = @id";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            try
                            {
                                connection.Open();

                                using (SqlCommand cmd = new SqlCommand(queryString, connection))
                                {
                                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nameInputBox.Text;
                                    cmd.Parameters.Add("@unit", SqlDbType.NVarChar).Value = unitInputBox.Text;
                                    cmd.Parameters.Add("@unitPrice", SqlDbType.Money).Value = price;
                                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = productGroupBox.Text;

                                    int rowsAdded = cmd.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        MessageBox.Show("Product updated!", "Product");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to update product!");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR: " + ex.Message);
                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Please input a valid quantity.");
                    }
                }
                catch
                {
                    MessageBox.Show("Please input valid unit price.", "Error");
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                queryString = "delete from Product where prodID = @id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand(queryString, connection))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = productGroupBox.Text;

                            int rowsAdded = cmd.ExecuteNonQuery();
                            if (rowsAdded > 0)
                            {
                                MessageBox.Show("Product deleted!", "Product");
                            }
                            else
                            {
                                MessageBox.Show("Unable to delete product!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                }
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prodDetails_Load(object sender, EventArgs e)
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
            string queryString = "getProductImport";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(queryString, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = productGroupBox.Text;
                        SqlDataReader reader = cmd.ExecuteReader();
                        importData.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
            productImportDataGrid.DataSource = importData;
            productImportDataGrid.Columns["Date and time"].Width = 140;
            productImportDataGrid.Columns["Quantity"].Width = 80;
            productImportDataGrid.Columns["Unit Price"].Width = 100;
            productImportDataGrid.Columns["Discount"].Width = 80;
            productImportDataGrid.Columns["Amount"].Width = 89;
            productImportDataGrid.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productImportDataGrid.Columns["Amount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            productImportDataGrid.Columns["Unit Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productImportDataGrid.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productImportDataGrid.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productImportDataGrid.Columns["Unit Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productImportDataGrid.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewRow row in productImportDataGrid.Rows)
            {
                Decimal discount = (Decimal)row.Cells["Discount"].Value;
                row.Cells["Discount"].Value = Math.Round(discount * 100);
            }
        }
    }
}
