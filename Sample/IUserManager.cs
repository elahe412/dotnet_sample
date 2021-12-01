using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample
{
    public interface IUserManager
    {
        public Task<bool> AddUser(UserModel userModel);
        public Task<List<UserModel>> GetUsers();
    }
}
