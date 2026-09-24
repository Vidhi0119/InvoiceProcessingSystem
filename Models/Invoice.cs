namespace InvoiceProcessingSystem.Models
{
    public class Invoice
    {
        public string? InvoiceId { get; set; }

        public string? CustomerId { get; set; }

        public string? CustomerName { get; set; }

        public string? Amount { get; set; }

        public string? Status { get; set; }

        public string? InvoiceDate { get; set; }

        public string? DueDate { get; set; }
    }
}