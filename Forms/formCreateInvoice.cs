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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InvoiceManagement
{
    public partial class formCreateInvoice : Form
    {
        string connectionString =
                            "Server=MORNINGSTAR\\SQLEXPRESS;" +
                            "Database=InvoiceProject;" +
                            "User Id=dthanh;" +
                            "Password=123321;" +
                            "TrustServerCertificate=True;";
        string queryString = "";
        DataTable prodData = new DataTable();

        public formCreateInvoice()
        {
            InitializeComponent();
        }

        private void formCreateInvoice_Load(object sender, EventArgs e)
        {
            queryString = "getProductData";
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

            DataRow itemRow = prodData.NewRow();
            itemRow["Product Name"] = "Select Product";
            itemRow["Product ID"] = "-1";
            prodData.Rows.InsertAt(itemRow,0);

            AutoCompleteStringCollection nameList = new AutoCompleteStringCollection();
            foreach (DataRow row in prodData.Rows)
            {
                nameList.Add(row["Product Name"].ToString());
            }

            prodComboBox.AutoCompleteCustomSource = nameList;
            prodComboBox.DataSource = prodData;
            prodComboBox.DisplayMember = "Product Name";
            prodComboBox.ValueMember = "Product ID";

            quantityInputBox.GotFocus += new EventHandler(RemoveQuantityText);
            quantityInputBox.LostFocus += new EventHandler(AddQuantityText);

            unitPriceInputBox.GotFocus += new EventHandler(RemovePriceText);
            unitPriceInputBox.LostFocus += new EventHandler(AddPriceText);

            discountInputBox.GotFocus += new EventHandler(RemoveDiscountText);
            discountInputBox.LostFocus += new EventHandler(AddDiscountText);

        }

        private void AddQuantityText(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quantityInputBox.Text) || prodComboBox.SelectedText.Equals("Select Product"))
            {
                quantityInputBox.Text = "Enter quantity ...";
                quantityInputBox.ForeColor = Color.Silver;
            }
        }

        private void RemoveQuantityText(object? sender, EventArgs e)
        {
            if (quantityInputBox.Text == "Enter quantity ...")
            {
                quantityInputBox.Text = "";
                quantityInputBox.ForeColor = Color.Black;
            }
        }

        private void AddPriceText(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unitPriceInputBox.Text))
            {
                unitPriceInputBox.Text = "Enter unit price ...";
                unitPriceInputBox.ForeColor = Color.Silver;
            }
        }

        private void RemovePriceText(object? sender, EventArgs e)
        {
            if (unitPriceInputBox.Text.Equals("Enter unit price ..."))
            {
                unitPriceInputBox.Text = "";
                unitPriceInputBox.ForeColor = Color.Black;
            }
        }

        private void AddDiscountText(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(discountInputBox.Text))
            {
                discountInputBox.Text = "Enter discount (%) ...";
                discountInputBox.ForeColor = Color.Silver;
            }
        }

        private void RemoveDiscountText(object? sender, EventArgs e)
        {
            if (discountInputBox.Text.Equals("Enter discount (%) ..."))
            {
                discountInputBox.Text = "";
                discountInputBox.ForeColor = Color.Black;
            }
        }

        private void addProdButton_Click(object sender, EventArgs e)
        {
            string prodID;
            try
            {
                prodID = prodComboBox.SelectedValue.ToString();
            }
            catch
            {
                MessageBox.Show("Please select a product.", "Error");
                return;
            }
            if (prodID.Equals("-1"))
            {
                MessageBox.Show("Please select a product.", "Error");
            }
            else
            {
                int quantity;
                float price;
                double discount;
                try
                {
                    quantity = int.Parse(quantityInputBox.Text);
                    price = float.Parse(unitPriceInputBox.Text);
                    if (price < 0)
                    {
                        MessageBox.Show("Please enter a valid price.", "Error");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid quantity and price.", "Error");
                    return;
                }
                try
                {
                    discount = int.Parse(discountInputBox.Text) / (100.0);
                    if (discount < 0 || discount > 1)
                    {
                        MessageBox.Show("Please enter a valid discount (0-100).", "Error");
                        return;
                    }
                }
                catch
                {
                    discount = 0;
                }
                int stockQuantity = 0;
                foreach(DataRow row in prodData.Rows)
                {
                    if (row["Product ID"].Equals(prodID))
                    {
                        stockQuantity = (int)(row["Quantity"]);
                        stockLabel.Text = "Stock: " + stockQuantity.ToString();
                    }
                }
                if (quantity > stockQuantity)
                {
                    MessageBox.Show("Not enough item left in stock.");
                    return;
                }
                else
                {
                    foreach (DataRow row in prodData.Rows)
                    {
                        if (row["Product ID"].Equals(prodID))
                            row["Quantity"] = stockQuantity - quantity;
                    }
                    string unit = "";
                    foreach (DataRow row in prodData.Rows)
                    {
                        if (row["Product ID"].Equals(prodID))
                            unit = row["Unit"].ToString();
                    }
                    double amount = (price * quantity * (1 - discount));
                    string[] product = { prodID, prodComboBox.Text, unit, price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture), 
                        quantity.ToString(), (Math.Round(discount*100, 2).ToString()+"%"), amount.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) };
                    var listViewItem = new ListViewItem(product);
                    prodListView.Items.Add(listViewItem);
                    totalAmount.Text = (double.Parse(totalAmount.Text) + amount).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
                }
            }
        }

        private void createInvButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    queryString = "insert into Invoice (DateTime) values (@datetime)";
                    using (SqlCommand cmd = new SqlCommand(queryString, connect))
                    {
                        cmd.Parameters.Add("@datetime", SqlDbType.DateTime).Value = dateInput.Value.ToShortDateString() + " " + timeInput.Value.ToLongTimeString();
                        cmd.ExecuteNonQuery();
                    }
                    queryString = "select top 1 InvID from Invoice order by InvID desc";
                    string invID;
                    using (SqlCommand cmd = new SqlCommand(queryString, connect))
                    {
                        invID = cmd.ExecuteScalar().ToString();
                    }

                    foreach (ListViewItem product in prodListView.Items)
                    {
                        queryString = "insert into Purchase (InvID, ProdID, ProdName, Unit, UnitPrice, Quantity, Discount) " +
                            "values (@invId, @prodId, @prodName, @unit, @unitPrice, @quantity, @discount)";
                        using (SqlCommand cmd = new SqlCommand(queryString, connect))
                        {
                            cmd.Parameters.Add("@invId", SqlDbType.NVarChar).Value = invID;
                            cmd.Parameters.Add("@prodId", SqlDbType.NVarChar).Value = product.SubItems[0].Text;
                            cmd.Parameters.Add("@prodName", SqlDbType.NVarChar).Value = product.SubItems[1].Text;
                            cmd.Parameters.Add("@unit", SqlDbType.NVarChar).Value = product.SubItems[2].Text;
                            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = int.Parse(product.SubItems[4].Text);
                            cmd.Parameters.Add("@discount", SqlDbType.Decimal).Value = (Decimal.Parse(product.SubItems[5].Text.Remove(product.SubItems[5].Text.Length - 1))/100);
                            cmd.Parameters.Add("@unitPrice", SqlDbType.Money).Value = Decimal.Parse(product.SubItems[3].Text);
                            cmd.ExecuteNonQuery();
                        }
                        queryString = "update Product set Quantity = @quantity where ProdID = @prodId";
                        using (SqlCommand cmd = new SqlCommand(queryString, connect))
                        {
                            int quantity = 0;
                            foreach (DataRow row in prodData.Rows)
                            {
                                if (row["Product ID"].Equals(product.SubItems[0].Text))
                                {
                                    quantity = (int)row["Quantity"];
                                }
                            }
                            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                            cmd.Parameters.Add("@prodId", SqlDbType.NVarChar).Value = product.SubItems[0].Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                    return;
                }
                MessageBox.Show("Successfully created!");
                
                this.Close();
            }
        }

        private void prodListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = prodListView.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(prodListView, new Point(e.X, e.Y));
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in prodData.Rows)
            {
                if (row["Product ID"].Equals(prodListView.FocusedItem.SubItems[0].Text))
                {
                    int stockQuantity = (int)row["Quantity"];
                    int quantity = int.Parse(prodListView.FocusedItem.SubItems[4].Text);
                    row["Quantity"] = stockQuantity + quantity;
                    totalAmount.Text = (Double.Parse(totalAmount.Text) - Double.Parse(prodListView.FocusedItem.SubItems[6].Text)).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
                    if (prodListView.FocusedItem.SubItems[0].Text.Equals(prodComboBox.SelectedValue.ToString()))
                        stockLabel.Text = "Stock: " + row["Quantity"].ToString();
                }
            }
            prodListView.Items.Remove(prodListView.FocusedItem);
        }

        private void prodComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (prodComboBox.SelectedValue.ToString().Equals("-1"))
            {
                quantityInputBox.Text = "Enter quantity ...";
                quantityInputBox.ForeColor = Color.Silver;
                unitPriceInputBox.Text = "Enter unit price ...";
                unitPriceInputBox.ForeColor = Color.Silver;
                discountInputBox.Text = "Enter discount (%) ...";
                discountInputBox.ForeColor = Color.Silver;
                stockLabel.Text = "Stock:";
            }
            else
            {
                foreach (DataRow row in prodData.Rows)
                {
                    if (row["Product ID"].Equals(prodComboBox.SelectedValue.ToString())) 
                    {
                        quantityInputBox.Text = "1";
                        quantityInputBox.ForeColor = Color.Black;
                        unitPriceInputBox.Text = row["Unit Price"].ToString();
                        unitPriceInputBox.ForeColor = Color.Black;
                        stockLabel.Text = "Stock: " + row["Quantity"].ToString();
                    }
                }
            }
        }
    }
}
