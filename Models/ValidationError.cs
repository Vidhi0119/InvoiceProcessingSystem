namespace InvoiceProcessingSystem.Models
{
    internal class ValidationError
    {
        public string FileName { get; set; } = "";

        public string InvoiceId { get; set; } = "";

        public string ErrorMessage { get; set; } = "";
    }
}  
