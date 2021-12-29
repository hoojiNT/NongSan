using NongSan.API.Domain.Models;
using NongSan.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.UserService
{
    public class UserService : IUserService
    {
        private IRepository<User> repo;
        public UserService(IRepository<User> repo)
        {
            this.repo = repo;
        }
        public void DeleteUser(int id)
        {
            User User = GetUser(id);
            repo.Delete(User);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return repo.GetAll();
        }

        public User GetUser(int id)
        {
            return repo.Get(id);
        }

        public void InsertUser(User User)
        {

            repo.Insert(User);
        }

        public void UpdateUser(User User)
        {
            repo.Update(User);
        }
    }
}
