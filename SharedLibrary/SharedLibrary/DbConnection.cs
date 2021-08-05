using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class DbConnection : IDbConnection
    {
        private readonly string ConnectionString;
        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetConnectionString()
        {
            var connectionStringFormatted = "Current Connection: " + ConnectionString;
            return connectionStringFormatted;
        }
    }
}
