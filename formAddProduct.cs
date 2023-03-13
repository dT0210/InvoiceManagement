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
    public partial class formAddProduct : Form
    {
        public formAddProduct()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (idInputBox.Text == "")
            {
                MessageBox.Show("Product ID is missing!", "Error");
            }
            else if (nameInputBox.Text == "")
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
                        int quantity = string.IsNullOrEmpty(quantityInputBox.Text) ? 0 : int.Parse(quantityInputBox.Text);
                        string connectionString =
                            "Server=MORNINGSTAR\\SQLEXPRESS;" +
                            "Database=InvoiceProject;" +
                            "User Id=dthanh;" +
                            "Password=123321;" +
                            "TrustServerCertificate=True;";
                        string queryString = "insert into Product values(@id, @name, @unit, @unitPrice, @quantity)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            try
                            {
                                connection.Open();

                                using (SqlCommand cmd = new SqlCommand(queryString, connection))
                                {
                                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = idInputBox.Text;
                                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nameInputBox.Text;
                                    cmd.Parameters.Add("@unit", SqlDbType.NVarChar).Value = unitInputBox.Text;
                                    cmd.Parameters.Add("@unitPrice", SqlDbType.Money).Value = price;
                                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                                    int rowsAdded = cmd.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        MessageBox.Show("Product added!", "Product");
                                        idInputBox.Clear();
                                        nameInputBox.Clear();
                                        unitInputBox.Clear();
                                        unitPriceInputBox.Clear();
                                        quantityInputBox.Clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to add product!");
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
