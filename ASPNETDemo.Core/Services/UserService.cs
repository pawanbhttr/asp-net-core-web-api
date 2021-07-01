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
    public class UserService : IUserService
    {
        private readonly IRepository _repository;
        public UserService(IRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<User> AddUser(User user)
        {
            return new List<User>();
        }
    }
}
