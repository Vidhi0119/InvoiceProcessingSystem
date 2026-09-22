using InvoiceProcessingSystem.Models;
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

            ConfigureValidationLogsGrid();
        }

        private void btnProcessFiles_Click(object sender, EventArgs e)
        {

            string inputFolder =
     Program.Configuration["FileProcessing:InputFolder"] ?? "";

            string validInvoicesFolder =
                Program.Configuration["FileProcessing:ValidInvoicesFolder"] ?? "";

            string errorFolder =
                Program.Configuration["FileProcessing:ErrorFolder"] ?? "";

            try
            {
                InvoiceProcessor processor =
                    new InvoiceProcessor(
                        inputFolder,
                        validInvoicesFolder,
                        errorFolder
                    );

                List<FileProcessingResult> results =
                    processor.ProcessFiles();

                // Clear previous logs
                dgvValidationLogs.Rows.Clear();

                int totalInvoices = 0;
                int successfulInvoices = 0;
                int failedInvoices = 0;

                foreach (FileProcessingResult result in results)
                {
                    // Update summary counts
                    totalInvoices += result.TotalInvoices;
                    successfulInvoices += result.SuccessfulInvoices;
                    failedInvoices += result.FailedInvoices;

                    // Add validation errors to logs
                    foreach (ValidationLog log in result.ValidationLogs)
                    {
                        dgvValidationLogs.Rows.Add(
                            log.FileName,
                            log.InvoiceId,
                            log.ErrorMessage
                        );
                    }
                }

                // Update Processing Summary
                lblTotalInvoices.Text =
                    "Total Invoices: " + totalInvoices;

                lblCompleted.Text =
                    "Successful: " + successfulInvoices;

                lblErrors.Text =
                    "Failed: " + failedInvoices;

                // For now, processing completes at 100%
                lblPercentage.Text = "100%";
                progressBar.Value = 100;

                MessageBox.Show(
                    "Invoice validation completed.",
                    "Validation Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void dgvValidationLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigureValidationLogsGrid()
        {
            dgvValidationLogs.Columns.Clear();

            dgvValidationLogs.Columns.Add(
                "FileName",
                "File Name"
            );

            dgvValidationLogs.Columns.Add(
                "InvoiceId",
                "Invoice ID"
            );

            dgvValidationLogs.Columns.Add(
                "ErrorMessage",
                "Error"
            );

            dgvValidationLogs.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvValidationLogs.AllowUserToAddRows = false;

            dgvValidationLogs.ReadOnly = true;
        }


    }
}