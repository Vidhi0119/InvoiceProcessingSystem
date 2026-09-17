using InvoiceProcessingSystem.Services;
using InvoiceProcessingSystem.Models;

namespace InvoiceProcessingSystem
{
    public partial class InvoiceProcessingForm : Form
    {
        public InvoiceProcessingForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnReadInvoices_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            InvoiceFileReader reader = new InvoiceFileReader();
            List<Invoice> invoices = reader.ReadInvoices(filePath);
            lblTotalInvoices.Text = "Total Invoices: " + invoices.Count;



        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
