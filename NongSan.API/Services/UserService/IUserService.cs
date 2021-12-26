using NongSan.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.UserService
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(string id);
        void InsertUser(User User);
        void UpdateUser(User User);
        void DeleteUser(string id);
    }
}
