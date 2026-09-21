using InvoiceProcessingSystem.Models;
using System.Reflection;

namespace InvoiceProcessingSystem.Services
{
    internal class InvoiceValidator
    {

        public string Validate(Invoice invoice)
        {
            // -------------------------
            // Invoice ID
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.InvoiceId))
            {
                return "Invoice ID should not be empty.";
            }


            // -------------------------
            // Customer ID
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.CustomerId))
            {
                return "Customer ID should not be empty.";
            }


            // -------------------------
            // Customer Name
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.CustomerName))
            {
                return "Customer Name should not be empty.";
            }

            if (invoice.RawCustomerName!.All(char.IsDigit))
            {
                return "Customer Name must contain text.";
            }


            // -------------------------
            // Amount - Empty
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.RawAmount))
            {
                return "Amount should not be empty.";
            }


            // -------------------------
            // Amount - Type Validation
            // -------------------------
            if (!invoice.IsAmountValid)
            {
                return "Amount must be a valid decimal number.";
            }


            // -------------------------
            // Amount - Value Validation
            // -------------------------
            if (invoice.Amount <= 0)
            {
                return "Amount must be greater than zero.";
            }


            // -------------------------
            // Status
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.Status))
            {
                return "Status should not be empty.";
            }

            if (invoice.RawStatus!.All(char.IsDigit))
            {
                return "Status must contain text.";
            }


            // -------------------------
            // Invoice Date - Empty
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.RawInvoiceDate))
            {
                return "Invoice Date should not be empty.";
            }


            // -------------------------
            // Invoice Date - Type Validation
            // -------------------------
            if (!invoice.IsInvoiceDateValid)
            {
                return "Invoice Date must be a valid date.";
            }


            // -------------------------
            // Due Date - Empty
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.RawDueDate))
            {
                return "Due Date should not be empty.";
            }


            // -------------------------
            // Due Date - Type Validation
            // -------------------------
            if (!invoice.IsDueDateValid)
            {
                return "Due Date must be a valid date.";
            }


            // -------------------------
            // Due Date Validation
            // -------------------------
            if (invoice.DueDate < invoice.InvoiceDate)
            {
                return "Due Date cannot be before Invoice Date.";
            }


            // -------------------------
            // Invoice is valid
            // -------------------------
            return "";

        }
    }
}

//check for all types of validation like amount > 0 and type change , TryParse 
