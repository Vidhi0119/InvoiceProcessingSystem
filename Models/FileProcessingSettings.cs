using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessingSystem.Models
{
    internal class FileProcessingSettings
    {
        public string InputFolder { get; set; } = "";
        public string ValidInvoicesFolder { get; set; } = "";
        public string ErrorFolder { get; set; } = "";
    }
}
