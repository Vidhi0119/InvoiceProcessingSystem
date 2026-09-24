using InvoiceProcessingSystem.Models;

namespace InvoiceProcessingSystem.Services
{
    public class InvoiceFileReader
    {
        public List<Invoice> ReadInvoices(string filePath)
        {
            List<Invoice> invoices = new List<Invoice>();

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                if (data.Length < 7)
                {
                    continue;
                }

                Invoice invoice = new Invoice
                {
                    InvoiceId = data[0],
                    CustomerId = data[1],
                    CustomerName = data[2],
                    Amount = data[3],
                    Status = data[4],
                    InvoiceDate = data[5],
                    DueDate = data[6]
                };

                invoices.Add(invoice);
            }

            return invoices;
        }
    }
}