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
                Program.Configuration["FileProcessing:InputFolder"]
                ?? "";

            dgvValidationLogs.Rows.Clear();

            txtProcessingLogs.Clear();

            lblTotalInvoices.Text =
                "Total Invoices: 0";

            lblCompleted.Text =
                "Successful: 0";

            lblErrors.Text =
                "Failed: 0";

            lblPercentage.Text =
                "0%";

            progressBar.Value = 0;

            try
            {
                InvoiceProcessor processor =
                    new InvoiceProcessor(
                        inputFolder,
                        AddProcessingLog,
                        UpdateProgress
                    );

                List<FileProcessingResult> results =
                    processor.ProcessFiles();

                int totalInvoices = 0;
                int successfulInvoices = 0;
                int failedInvoices = 0;

                foreach (FileProcessingResult result in results)
                {
                    totalInvoices +=
                        result.TotalInvoices;

                    successfulInvoices +=
                        result.SuccessfulInvoices;

                    failedInvoices +=
                        result.FailedInvoices;

                    foreach (ValidationError error
                             in result.ValidationLogs)
                    {
                        dgvValidationLogs.Rows.Add(
                            error.FileName,
                            error.InvoiceId,
                            error.ErrorMessage
                        );
                    }
                }

                lblTotalInvoices.Text =
                    "Total Invoices: " + totalInvoices;

                lblCompleted.Text =
                    "Successful: " + successfulInvoices;

                lblErrors.Text =
                    "Failed: " + failedInvoices;

                if (results.Count > 0)
                {
                    UpdateProgress(100);

                    AddProcessingLog(
                        "All files processed successfully."
                    );
                }
            }
            catch (Exception ex)
            {
                AddProcessingLog(
                    "Processing failed: " + ex.Message
                );

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

        private void grpValidationLogs_Enter(object sender, EventArgs e)
        {

        }

        private void AddProcessingLog(string message)
        {
            txtProcessingLogs.AppendText(
                $"{DateTime.Now:HH:mm:ss} - {message}"
                + Environment.NewLine
            );

            txtProcessingLogs.SelectionStart =
                txtProcessingLogs.Text.Length;

            txtProcessingLogs.ScrollToCaret();
        }

        private void UpdateProgress(int percentage)
        {
            if (percentage < 0)
                percentage = 0;

            if (percentage > 100)
                percentage = 100;

            progressBar.Value = percentage;

            lblPercentage.Text =
                percentage + "%";

            Application.DoEvents();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}