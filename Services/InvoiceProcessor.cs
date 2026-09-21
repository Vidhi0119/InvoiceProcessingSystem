using InvoiceProcessingSystem.Models;

namespace InvoiceProcessingSystem.Services
{
    internal class InvoiceProcessor
    {
        private readonly string inputFolder;

        public InvoiceProcessor(string inputFolder)
        {
            string projectFolder = FindProjectFolder();

            this.inputFolder = Path.GetFullPath(
                Path.Combine(projectFolder, inputFolder)
            );
        }

        private string FindProjectFolder()
        {
            DirectoryInfo? directory =
                new DirectoryInfo(AppContext.BaseDirectory);

            while (directory != null)
            {
                string[] projectFiles =
                    Directory.GetFiles(directory.FullName, "*.csproj");

                if (projectFiles.Length > 0)
                {
                    return directory.FullName;
                }

                directory = directory.Parent;
            }

            throw new DirectoryNotFoundException(
                "Project folder could not be found."
            );
        }

        public void ProcessFiles()
        {
            if (!Directory.Exists(inputFolder))
            {
                throw new DirectoryNotFoundException(
                    $"Input folder does not exist: {inputFolder}"
                );
            }

            string[] csvFiles = Directory.GetFiles(
                inputFolder,
                "*.csv"
            );

            foreach (string filePath in csvFiles)
            {
                ProcessFile(filePath);
            }
        }

        private void ProcessFile(string filePath)
        {
            InvoiceFileReader reader =
                new InvoiceFileReader();

            List<Invoice> invoices =
                reader.ReadInvoices(filePath);

            InvoiceValidator validator =
                new InvoiceValidator();

            foreach (Invoice invoice in invoices)
            {
                string error =
                    validator.Validate(invoice);

                if (error != "")
                {
                    continue;
                }

                // Valid invoice
                // File movement will be added next
            }
        }
    }
}