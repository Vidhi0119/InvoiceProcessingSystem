namespace InvoiceProcessingSystem.Models
{
    public class Invoice
    {
        // InvoiceId, CustomerIdCustomerName, Amount, Status, InvoiceDate, DueDate

        public string? InvoiceId { get; set; }
        

        public string? CustomerId { get; set; }
        
        

        public string? CustomerName { get; set; }
        public string? RawCustomerName { get; set; }

        
        public decimal? Amount { get; set; }
        public string? RawAmount { get; set; }
        public bool IsAmountValid { get; set; }


        public string? Status { get; set; }
        public string? RawStatus { get; set; }


        public DateTime? InvoiceDate { get; set; }
        public string? RawInvoiceDate { get; set; }
        public bool IsInvoiceDateValid { get; set; }


        public DateTime? DueDate { get; set; }
        public string? RawDueDate { get; set; }
        public bool IsDueDateValid { get; set; }




    }
}

//ctrl + KE for cleaning code
