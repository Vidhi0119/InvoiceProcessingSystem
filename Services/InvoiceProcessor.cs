using InvoiceProcessingSystem.Models;

namespace InvoiceProcessingSystem.Services
{
    internal class InvoiceProcessor
    {
        private readonly string inputFolder;
        private readonly string validInvoicesFolder;
        private readonly string errorFolder;

        public InvoiceProcessor(
            string inputFolder,
            string validInvoicesFolder,
            string errorFolder)
        {
            string projectFolder = FindProjectFolder();

            this.inputFolder = Path.GetFullPath(
                Path.Combine(projectFolder, inputFolder)
            );

            this.validInvoicesFolder = Path.GetFullPath(
                Path.Combine(projectFolder, validInvoicesFolder)
            );

            this.errorFolder = Path.GetFullPath(
                Path.Combine(projectFolder, errorFolder)
            );
        }

        private string FindProjectFolder()
        {
            DirectoryInfo? directory =
                new DirectoryInfo(AppContext.BaseDirectory);

            while (directory != null)
            {
                string[] projectFiles =
                    Directory.GetFiles(
                        directory.FullName,
                        "*.csproj"
                    );

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

        public List<FileProcessingResult> ProcessFiles()
        {
            List<FileProcessingResult> results =
                new List<FileProcessingResult>();

            if (!Directory.Exists(inputFolder))
            {
                throw new DirectoryNotFoundException(
                    $"Input folder does not exist: {inputFolder}"
                );
            }

            // Make sure destination folders exist
            Directory.CreateDirectory(validInvoicesFolder);
            Directory.CreateDirectory(errorFolder);

            string[] csvFiles =
                Directory.GetFiles(
                    inputFolder,
                    "*.csv"
                );

            foreach (string filePath in csvFiles)
            {
                FileProcessingResult result =
                    ProcessFile(filePath);

                results.Add(result);
            }

            return results;
        }

        private FileProcessingResult ProcessFile(string filePath)
        {
            InvoiceFileReader reader =
                new InvoiceFileReader();

            List<Invoice> invoices =
                reader.ReadInvoices(filePath);

            InvoiceValidator validator =
                new InvoiceValidator();

            FileProcessingResult result =
                new FileProcessingResult();

            result.FileName =
                Path.GetFileName(filePath);

            result.TotalInvoices =
                invoices.Count;

            foreach (Invoice invoice in invoices)
            {
                string error =
                    validator.Validate(invoice);

                if (error != "")
                {
                    result.FailedInvoices++;

                    result.ValidationLogs.Add(
                        new ValidationLog
                        {
                            FileName =
                                Path.GetFileName(filePath),

                            InvoiceId =
                                invoice.InvoiceId ?? "",

                            ErrorMessage =
                                error
                        }
                    );
                }
                else
                {
                    result.SuccessfulInvoices++;
                }
            }

            // Move the entire CSV based on validation result
            if (result.FailedInvoices == 0)
            {
                result.Status = "Valid";

                string destination =
                    Path.Combine(
                        validInvoicesFolder,
                        Path.GetFileName(filePath)
                    );

                File.Move(
                    filePath,
                    destination,
                    true
                );
            }
            else
            {
                result.Status = "Error";

                string destination =
                    Path.Combine(
                        errorFolder,
                        Path.GetFileName(filePath)
                    );

                File.Move(
                    filePath,
                    destination,
                    true
                );
            }

            return result;
        }
    }
}