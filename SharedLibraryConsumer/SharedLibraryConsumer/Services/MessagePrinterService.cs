using SharedLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibraryConsumer.Services
{
    public class MessagePrinterService : IMessagePrinterService
    {
        private readonly IMessagePrinter _messagePrinter;

        public MessagePrinterService(IMessagePrinter messagePrinter)
        {
            _messagePrinter = messagePrinter;
        }

        public void PrinterService(string message)
        {
            _messagePrinter.PrintContent(message);
        }
    }
}
