using ASPNETDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETDemo.Core.Interfaces
{
    public interface IEmployeeService
    {
        int ExecuteNonQuery(User info);
        Employee ExecuteScalar(User info);
        Employee First(User info);
        IEnumerable<Employee> List(User info);
    }
}
