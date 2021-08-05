using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibraryConsumer.Services
{
    public class DbConnectionService : IDbConnectionService
    {
        private readonly IDbConnection _dbConnectionService;
        public DbConnectionService(IDbConnection dbConnectionService)
        {
            _dbConnectionService = dbConnectionService;
        }
        public void GetConnectionStringService()
        {
            var connectionString = _dbConnectionService.GetConnectionString();
            Console.WriteLine(connectionString);
        }
    }
}
