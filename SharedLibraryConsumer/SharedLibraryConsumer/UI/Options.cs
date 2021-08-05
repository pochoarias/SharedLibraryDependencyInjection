using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibraryConsumer.UI
{
    public class Options
    {
        [Option(shortName: 'm', longName: "message", Required = false, Default = "(Default Message)", HelpText = "Prints a message")]
        public string Message { get; set; }

        [Option(shortName: 'c', longName: "connection string", Default = false, Required = false, HelpText = "Gets the connection string")]
        public bool ConnectionString { get; set; }
    }
}
