using CommandLine;
using SharedLibraryConsumer.DependencyResolution;
using SharedLibraryConsumer.UI;
using StructureMap;
using System;
using System.Threading.Tasks;

namespace SharedLibraryConsumer
{
    class Program
    {
        private static IContainer _container;
        static async Task Main(string[] args)
        {
            string[] arguments = new[] { "-m DEMO MESSAGE","-c "};

            Console.WriteLine("****** START APPLICATION ******");
            _container = Bootstrapper.GetContainer();

            await Parser.Default.ParseArguments<Options>(arguments)
                .MapResult(async (Options opts) =>
                {
                    await SharedLibraryConsumer(opts);
                },
                errs => Task.FromResult(-1) //Invalid Arguments
                );
            Console.WriteLine("****** END APPLICATION ******");
        }

        private static Task SharedLibraryConsumer(Options options)
        {
            try
            {
                var app = _container.GetInstance<Application>();
                app.Run(options);
                return Task.CompletedTask;
            }
            catch (Exception exc)
            {
                return Task.FromException(exc);
            }
        }
    }
}
