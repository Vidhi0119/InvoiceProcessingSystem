using Microsoft.Extensions.Configuration;

namespace InvoiceProcessingSystem
{
    public partial class InvoiceProcessingForm : Form
    {
        public InvoiceProcessingForm()
        {
            InitializeComponent();

            // Load Input Folder from appsettings.json
            txtInputFolder.Text =
                Program.Configuration["FileProcessing:InputFolder"] ?? "";

            // Initial UI values
            lblTotalInvoices.Text = "Total Invoices: 0";
            lblCompleted.Text = "Successful: 0";
            lblErrors.Text = "Failed: 0";
            lblPercentage.Text = "0%";

            progressBar.Value = 0;
        }

        private void btnProcessFiles_Click(object sender, EventArgs e)
        {
            // Processing logic will be added next.
            MessageBox.Show("Process Files button clicked.");
        }
    }
}