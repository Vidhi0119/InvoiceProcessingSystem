using InvoiceProcessingSystem.Services;
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

            string inputFolder =
        Program.Configuration["FileProcessing:InputFolder"] ?? "";

            if (string.IsNullOrWhiteSpace(inputFolder))
            {
                MessageBox.Show("Input folder is not configured.");
                return;
            }

            try
            {
                InvoiceProcessor processor =
                    new InvoiceProcessor(inputFolder);

                processor.ProcessFiles();

                MessageBox.Show("File validation completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}