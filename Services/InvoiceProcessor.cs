using InvoiceProcessingSystem.Models;

namespace InvoiceProcessingSystem.Services
{
    internal class InvoiceProcessor
    {
        private readonly string inputFolder;
        private readonly string validInvoicesFolder;
        private readonly string errorFolder;

        private readonly Action<string> log;
        private readonly Action<int> updateProgress;

        public InvoiceProcessor(
            string inputFolder,
            Action<string> log,
            Action<int> updateProgress)
        {
            this.inputFolder =
                Path.GetFullPath(inputFolder);

            string parentFolder =
                Directory.GetParent(this.inputFolder)?.FullName
                ?? throw new DirectoryNotFoundException(
                    "Parent folder of Input folder could not be found."
                );

            validInvoicesFolder =
                Path.Combine(parentFolder, "ValidInvoices");

            errorFolder =
                Path.Combine(parentFolder, "Error");

            this.log = log;
            this.updateProgress = updateProgress;
        }

        public List<FileProcessingResult> ProcessFiles()
        {
            List<FileProcessingResult> results =
                new List<FileProcessingResult>();

            log("Application started.");

            // --------------------------------
            // Check Input Folder
            // --------------------------------

            log("Checking Input folder...");

            if (!Directory.Exists(inputFolder))
            {
                log(
                    "Input folder not found. Please create the Input folder and configure its path in appsettings.json."
                );

                return results;
            }

            log("Input folder found.");

            // --------------------------------
            // Create ValidInvoices folder
            // --------------------------------

            log("Checking ValidInvoices folder...");

            Directory.CreateDirectory(validInvoicesFolder);

            log("ValidInvoices folder is ready.");

            // --------------------------------
            // Create Error folder
            // --------------------------------

            log("Checking Error folder...");

            Directory.CreateDirectory(errorFolder);

            log("Error folder is ready.");

            // --------------------------------
            // Look for CSV files
            // --------------------------------

            log("Looking for CSV files in the Input folder...");

            string[] csvFiles =
                Directory.GetFiles(
                    inputFolder,
                    "*.csv"
                );

            if (csvFiles.Length == 0)
            {
                log(
                    "CSV file not found. Please input a CSV file into the Input folder."
                );

                return results;
            }

            log(
                $"{csvFiles.Length} CSV file(s) found."
            );

            // --------------------------------
            // Process files
            // --------------------------------

            updateProgress(0);

            for (int fileIndex = 0;
                 fileIndex < csvFiles.Length;
                 fileIndex++)
            {
                string filePath =
                    csvFiles[fileIndex];

                FileProcessingResult result =
                    ProcessFile(filePath);

                results.Add(result);

                int progress =
                    (int)(((fileIndex + 1) /
                    (double)csvFiles.Length) * 100);

                updateProgress(progress);
            }

            log("Processing completed.");

            return results;
        }

        private FileProcessingResult ProcessFile(
            string filePath)
        {
            string fileName =
                Path.GetFileName(filePath);

            log($"Processing file: {fileName}");

            log("Validating invoice file...");

            InvoiceFileReader reader =
                new InvoiceFileReader();

            List<Invoice> invoices =
                reader.ReadInvoices(filePath);

            log(
                $"{invoices.Count} invoice record(s) found in {fileName}."
            );

            InvoiceValidator validator =
                new InvoiceValidator();

            FileProcessingResult result =
                new FileProcessingResult();

            result.FileName = fileName;
            result.TotalInvoices = invoices.Count;

            for (int i = 0; i < invoices.Count; i++)
            {
                Invoice invoice =
                    invoices[i];

                List<string> errors =
                    validator.Validate(invoice);

                if (errors.Count > 0)
                {
                    result.FailedInvoices++;

                    foreach (string error in errors)
                    {
                        result.ValidationLogs.Add(
                            new ValidationError
                            {
                                FileName = fileName,

                                InvoiceId =
                                    invoice.InvoiceId ?? "",

                                ErrorMessage = error
                            }
                        );
                    }

                    log(
                        $"Invoice {invoice.InvoiceId} has {errors.Count} validation error(s)."
                    );
                }
                else
                {
                    result.SuccessfulInvoices++;

                    log(
                        $"Invoice {invoice.InvoiceId} validated successfully."
                    );
                }

                // Progress based on invoices
                int invoiceProgress =
                    (int)(((i + 1) /
                    (double)invoices.Count) * 100);

                updateProgress(invoiceProgress);
            }

            // --------------------------------
            // Move complete CSV
            // --------------------------------

            if (result.FailedInvoices == 0)
            {
                result.Status = "Valid";

                string destination =
                    Path.Combine(
                        validInvoicesFolder,
                        fileName
                    );

                File.Move(
                    filePath,
                    destination,
                    true
                );

                log(
                    $"{fileName} is valid. File moved to ValidInvoices."
                );
            }
            else
            {
                result.Status = "Error";

                string destination =
                    Path.Combine(
                        errorFolder,
                        fileName
                    );

                File.Move(
                    filePath,
                    destination,
                    true
                );

                log(
                    $"{fileName} contains validation errors. File moved to Error."
                );
            }

            return result;
        }
    }
}