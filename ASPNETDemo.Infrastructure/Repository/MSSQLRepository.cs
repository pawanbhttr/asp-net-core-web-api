using ASPNETDemo.Shared.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;

namespace ASPNETDemo.Infrastructure.Repository
{
    public class MSSQLRepository : IRepository
    {
        readonly SqlConnection _connection;
        readonly IConfiguration _configuration;
        public MSSQLRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(GetConnectionString());
        }

        string GetConnectionString()
        {
            return _configuration.GetConnectionString("DbContext");
        }

        public IEnumerable<T> List<T>(string query, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            return _connection.Query<T>(sql: query, param: parameters, commandType: commandType);
        }

        public T First<T>(string query, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            return _connection.QueryFirstOrDefault<T>(sql: query, param: parameters, commandType: commandType);
        }

        public T ExecuteScalar<T>(string query, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            return _connection.ExecuteScalar<T>(sql: query, param: parameters, commandType: commandType);
        }

        public int ExecuteNonQuery(string query, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            return _connection.Execute(sql: query, param: parameters, commandType: commandType);
        }

        ~MSSQLRepository()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            _connection?.Dispose();
        }
    }
}
