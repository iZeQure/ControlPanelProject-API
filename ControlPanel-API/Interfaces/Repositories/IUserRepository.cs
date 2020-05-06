using ControlPanel_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Interfaces.Repositories
{
    interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Verify the user credentials on Login.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool VerifyPassword(string emailAddress, string password);

        /// <summary>
        /// Login the user.
        /// </summary>
        void LogIn();

        /// <summary>
        /// Logout the user.
        /// </summary>
        void LogOut();
    }
}
