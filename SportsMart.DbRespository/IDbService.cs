using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SportsMart.Repository
{
    public interface IDbService
    {
        Task<SqlConnection> GetConnection();
    }
}