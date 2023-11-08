using System.Data;

namespace EasyGrocery.Common.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection(string ConnectionString);
    }
}
