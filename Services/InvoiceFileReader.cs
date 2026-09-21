using InvoiceProcessingSystem.Models;

namespace InvoiceProcessingSystem.Services
{
    public class InvoiceFileReader
    {

        // Create a method called ReadInvoices that should accept a file path and return a list of invoices.


        public List<Invoice> ReadInvoices(string filePath)
        {
            List<Invoice> invoices = new List<Invoice>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                bool isAmountValid = decimal.TryParse(data[3], out decimal amount);
                bool isInvoiceDateValid = DateTime.TryParse(data[5], out DateTime invoiceDate);

                bool isDueDateValid = DateTime.TryParse(data[6], out DateTime dueDate);

                Invoice invoice = new Invoice
                {


                    InvoiceId = data[0],

                    CustomerId = data[1],

                    CustomerName = data[2],
                    RawCustomerName = data[2],

                    RawAmount = data[3],
                    Amount = isAmountValid ? amount : null,
                    IsAmountValid = isAmountValid,

                    Status = data[4],
                    RawStatus = data[4],

                    RawInvoiceDate = data[5],
                    InvoiceDate = isInvoiceDateValid ? invoiceDate : null,
                    IsInvoiceDateValid = isInvoiceDateValid,

                    RawDueDate = data[6],
                    DueDate = isDueDateValid ? dueDate : null,
                    IsDueDateValid = isDueDateValid



                };

                invoices.Add(invoice);

            }

            return invoices;

            //check for invalid data.


        }

    }
}
