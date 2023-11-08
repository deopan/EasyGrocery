using EasyGrocery.Common.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace EasyGrocery.Repository.ConnectionFactory
{
    public class SqlDBConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection(string ConnectionString)
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
