using ASPNETDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETDemo.Core.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> AddUser(User user);
    }
}
