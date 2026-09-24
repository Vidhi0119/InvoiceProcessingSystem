using InvoiceProcessingSystem.Models;

namespace InvoiceProcessingSystem.Services
{
    internal class InvoiceValidator
    {
        public List<string> Validate(Invoice invoice)
        {
            List<string> errors = new List<string>();

            // -------------------------
            // Invoice ID
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.InvoiceId))
            {
                errors.Add("Invoice ID should not be empty.");
            }


            // -------------------------
            // Customer ID
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.CustomerId))
            {
                errors.Add("Customer ID should not be empty.");
            }


            // -------------------------
            // Customer Name
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.CustomerName))
            {
                errors.Add("Customer Name should not be empty.");
            }
            else if (invoice.CustomerName.All(char.IsDigit))
            {
                errors.Add("Customer Name must contain text.");
            }


            // -------------------------
            // Amount
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.Amount))
            {
                errors.Add("Amount should not be empty.");
            }
            else if (!decimal.TryParse(
                invoice.Amount,
                out decimal amount))
            {
                errors.Add("Amount must be a valid decimal number.");
            }
            else if (amount <= 0)
            {
                errors.Add("Amount must be greater than zero.");
            }


            // -------------------------
            // Status
            // -------------------------
            if (string.IsNullOrWhiteSpace(invoice.Status))
            {
                errors.Add("Status should not be empty.");
            }
            else if (invoice.Status.All(char.IsDigit))
            {
                errors.Add("Status must contain text.");
            }


            // -------------------------
            // Invoice Date
            // -------------------------
            bool isInvoiceDateValid = false;
            DateTime invoiceDate = default;

            if (string.IsNullOrWhiteSpace(invoice.InvoiceDate))
            {
                errors.Add("Invoice Date should not be empty.");
            }
            else if (!DateTime.TryParse(
                invoice.InvoiceDate,
                out invoiceDate))
            {
                errors.Add("Invoice Date must be a valid date.");
            }
            else
            {
                isInvoiceDateValid = true;
            }


            // -------------------------
            // Due Date
            // -------------------------
            bool isDueDateValid = false;
            DateTime dueDate = default;

            if (string.IsNullOrWhiteSpace(invoice.DueDate))
            {
                errors.Add("Due Date should not be empty.");
            }
            else if (!DateTime.TryParse(
                invoice.DueDate,
                out dueDate))
            {
                errors.Add("Due Date must be a valid date.");
            }
            else
            {
                isDueDateValid = true;
            }


            // -------------------------
            // Due Date Validation
            // -------------------------
            if (isInvoiceDateValid &&
                isDueDateValid &&
                dueDate < invoiceDate)
            {
                errors.Add(
                    "Due Date cannot be before Invoice Date."
                );
            }


            return errors;
        }
    }
}