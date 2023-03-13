namespace InvoiceManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            prodScreen1.loadData();
            prodScreen1.BringToFront();
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            invScreen1.BringToFront();
        }
    }
}