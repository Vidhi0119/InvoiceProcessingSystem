namespace InvoiceProcessingSystem.Models
{
    internal class ValidationLog
    {
        public string FileName { get; set; } = "";

        public string InvoiceId { get; set; } = "";

        public string ErrorMessage { get; set; } = "";
    }
}