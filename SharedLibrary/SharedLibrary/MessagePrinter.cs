using SharedLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Class
{
    public class MessagePrinter : IMessagePrinter
    {
        private const string prettyFormat = "       ->";
        public void PrintContent(string message)
        {
            var result = prettyFormat + message;
            Console.WriteLine(result);
        }
    }
}
