namespace InvoiceProcessingSystem.Models
{
    internal class FileProcessingResult
    {
        public string FileName { get; set; } = "";

        public int TotalInvoices { get; set; }

        public int SuccessfulInvoices { get; set; }

        public int FailedInvoices { get; set; }

        public string Status { get; set; } = "";

        public List<ValidationLog> ValidationLogs { get; set; }
            = new List<ValidationLog>();
    }
}