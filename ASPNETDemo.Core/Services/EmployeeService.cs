using ASPNETDemo.Core.Entities;
using ASPNETDemo.Core.Interfaces;
using ASPNETDemo.Shared.Interface;
using System.Collections.Generic;

namespace ASPNETDemo.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        readonly IRepository _repository;
        public EmployeeService(IRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Employee> List(User info)
        {
            const string query = @"SELECT * FROM HumanResources.vEmployee
                                    WHERE (FirstName = @FirstName OR @FirstName IS NULL)";
            return _repository.List<Employee>(query, info, System.Data.CommandType.Text);
        }

        public Employee First(User info)
        {
            const string query = @"SELECT * FROM HumanResources.vEmployee
                                    WHERE (FirstName = @FirstName OR @FirstName IS NULL)";
            return _repository.First<Employee>(query, info, System.Data.CommandType.Text);
        }

        public Employee ExecuteScalar(User info)
        {
            const string query = @"INSERT INTO HumanResources.Department ([Name],GroupName,ModifiedDate)
                                    VALUES(@FirstName, 'Research and Development', CURRENT_TIMESTAMP);
                                    SELECT * FROM HumanResources.Department WHERE DepartmentID = SCOPE_IDENTITY();";
            return _repository.ExecuteScalar<Employee>(query, info, System.Data.CommandType.Text);
        }

        public int ExecuteNonQuery(User info)
        {
            const string query = @"INSERT INTO HumanResources.Department ([Name],GroupName,ModifiedDate)
                                    VALUES(@FirstName, 'Research and Development', CURRENT_TIMESTAMP)";
            return _repository.ExecuteNonQuery(query, info, System.Data.CommandType.Text);
        }
    }
}
