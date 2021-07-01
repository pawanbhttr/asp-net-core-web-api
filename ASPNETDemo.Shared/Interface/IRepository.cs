using System.Collections.Generic;
using System.Data;

namespace ASPNETDemo.Shared.Interface
{
    public interface IRepository
    {
        int ExecuteNonQuery(string query, object parameters = null, CommandType commandType = CommandType.StoredProcedure);
        T ExecuteScalar<T>(string query, object parameters = null, CommandType commandType = CommandType.StoredProcedure);
        T First<T>(string query, object parameters = null, CommandType commandType = CommandType.StoredProcedure);
        IEnumerable<T> List<T>(string query, object parameters = null, CommandType commandType = CommandType.StoredProcedure);
    }
}
