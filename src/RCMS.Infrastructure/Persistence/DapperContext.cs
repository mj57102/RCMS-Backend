
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using RCMS.Infrastructure.Config;
using System.Data;

namespace RCMS.Infrastructure.Persistence
{
    /// <summary>کانتکست Dapper برای اتصال به SQL Server</summary>
    public class DapperContext
    {
        private readonly string _conn;
        public DapperContext(IOptions<DbOptions> options) => _conn = options.Value.ConnectionString;
        public IDbConnection CreateConnection() => new SqlConnection(_conn);
    }
}
