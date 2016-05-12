using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SportsMart.Repository
{
    public class DbService : IDbService
    {
        public readonly string _connectionString = null;

        public DbService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<SqlConnection> GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }
    }
}
