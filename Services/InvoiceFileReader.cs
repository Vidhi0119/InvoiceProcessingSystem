using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceProcessingSystem.Models;

namespace InvoiceProcessingSystem.Services
{
    internal class InvoiceFileReader
    {

        // Create a method called ReadInvoices that should accept a file path and return a list of invoices.

        
        public List<Invoice> ReadInvoices(string filePath)
        {
            List<Invoice> invoices = new List<Invoice>();
            string[] lines = File.ReadAllLines(filePath);

            for(int i=1; i<lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                Invoice invoice = new Invoice
                {
                    InvoiceId = data[0],
                    CustomerId = data[1],
                    CustomerName = data[2],
                    Amount = decimal.Parse(data[3]),
                    Status = data[4],
                    InvoiceDate = DateTime.Parse(data[5]),
                    DueDate = DateTime.Parse(data[6])
                };

                invoices.Add(invoice);

            }

            return invoices;


        }

    }
}
