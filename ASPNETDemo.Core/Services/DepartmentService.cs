using ASPNETDemo.Core.Entities;
using ASPNETDemo.Core.Interfaces;
using ASPNETDemo.Shared.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETDemo.Core.Services
{
    public class DepartmentService : IDepartmentService
    {
        readonly IRepository _repository;
        public DepartmentService(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Department> Get(Department department)
        {
            const string query = @"SELECT
	                                    [DepartmentID],
	                                    [Name] AS [DepartmentName],
	                                    [GroupName],
	                                    [ModifiedDate]
                                    FROM [HumanResources].[Department]
                                    WHERE ([DepartmentID] = @DepartmentID OR @DepartmentID IS NULL)
                                    AND ([Name] = @DepartmentName OR @DepartmentName IS NULL)
                                    AND ([GroupName] = @GroupName OR @GroupName IS NULL)";

            return _repository.List<Department>(query, department, System.Data.CommandType.Text);
        }

        public string Insert(Department department)
        {
            const string query = @"
                INSERT INTO HumanResources.Department ([Name], GroupName, ModifiedDate)
                VALUES(@DepartmentName, @GroupName, @ModifiedDate)
            ";
            var result = _repository.ExecuteNonQuery(query, department, System.Data.CommandType.Text);
            return (result > 0) ? "Department saved successfully" : "Oops! Something went wrong.";
        }

        public string Update(Department department)
        {
            const string query = @"
                UPDATE HumanResources.Department
                SET
	                [Name] = @DepartmentName,
	                GroupName = @GroupName,
	                ModifiedDate = @ModifiedDate
                WHERE DepartmentID = @DepartmentID
            ";
            var result = _repository.ExecuteNonQuery(query, department, System.Data.CommandType.Text);
            return (result > 0) ? "Department updated successfully" : "Oops! Something went wrong.";
        }

        public string Delete(Department department)
        {
            const string query = @"
                DELETE FROM HumanResources.Department
                WHERE DepartmentID = @DepartmentID
            ";
            var result = _repository.ExecuteNonQuery(query, department, System.Data.CommandType.Text);
            return (result > 0) ? "Department deleted successfully" : "Oops! Something went wrong.";
        }
    }
}
