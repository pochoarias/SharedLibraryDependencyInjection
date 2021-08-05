using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibraryConsumer.Services
{
    public interface IMessagePrinterService
    {
        void PrinterService(string message);
    }
}
