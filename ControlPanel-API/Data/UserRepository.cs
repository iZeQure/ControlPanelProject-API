using ControlPanel_API.Entities;
using ControlPanel_API.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Data
{
    /// <summary>
    /// CRUD Operations for the User's handlings.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        public void Create(User create)
        {
            throw new NotImplementedException();
        }

        public void Delete(User delete)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void LogIn()
        {
            throw new NotImplementedException();
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        public void Update(User update)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPassword(string emailAddress, string password)
        {
            throw new NotImplementedException();
        }
    }
}
