using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessingSystem.Models
{
    internal class Invoice
    {
        // InvoiceId, CustomerIdCustomerName, Amount, Status, InvoiceDate, DueDate

        public string InvoiceId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
