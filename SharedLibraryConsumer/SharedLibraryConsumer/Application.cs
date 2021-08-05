using SharedLibraryConsumer.Services;
using SharedLibraryConsumer.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibraryConsumer
{
    public class Application
    {
        private readonly IMessagePrinterService _messagePrinterService;
        private readonly IDbConnectionService _dbConnectionService;

        public Application(IMessagePrinterService messagePrinterService, IDbConnectionService dbConnectionService)
        {
            _messagePrinterService = messagePrinterService;
            _dbConnectionService = dbConnectionService;
        }

        public void Run(Options options)
        {
            if (!string.IsNullOrEmpty(options.Message))
            {
                _messagePrinterService.PrinterService(options.Message);
            }

            if (options.ConnectionString)
            {
                _dbConnectionService.GetConnectionStringService();
            }
        }
    }
}
