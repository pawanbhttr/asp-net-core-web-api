using ASPNETDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETDemo.Core.Interfaces
{
    public interface IDepartmentService
    {
        string Delete(Department department);
        IEnumerable<Department> Get(Department department);
        string Insert(Department department);
        string Update(Department department);
    }
}
