using SharedLibrary;
using SharedLibrary.Interfaces;
using StructureMap;
using StructureMap.Graph;
using System.Configuration;

namespace SharedLibraryConsumer.DependencyResolution
{
    public class ExternalRegistry : Registry
    {

        public ExternalRegistry()
        {
            Scan(scan =>
            {
                AddAssemblies(scan);
                scan.WithDefaultConventions();
            });

            var connectionString = ConfigurationManager.ConnectionStrings["MockDB"].ConnectionString;
            For<IDbConnection>().Use<DbConnection>().Ctor<string>().Is(connectionString);
        }
        private static void AddAssemblies(IAssemblyScanner assemblyScanner)
        {
            assemblyScanner.AssemblyContainingType<IMessagePrinter>();
            assemblyScanner.AssemblyContainingType<IDbConnection>();
        }
    }
}
