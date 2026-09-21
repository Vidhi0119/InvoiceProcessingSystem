using Microsoft.Extensions.Configuration;

namespace InvoiceProcessingSystem
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; }

        static Program()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile(
                    "appsettings.json",
                    optional: false,
                    reloadOnChange: true)
                .Build();
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new InvoiceProcessingForm());
        }
    }
}