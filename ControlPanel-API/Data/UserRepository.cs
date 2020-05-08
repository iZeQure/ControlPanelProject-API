using ControlPanel_API.Data.Database;
using ControlPanel_API.Entities;
using ControlPanel_API.Interfaces;
using ControlPanel_API.Interfaces.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
            MySqlDatabase mySqlDB = MySqlDatabase.Instance;
            User newUser = new User();

            using (mySqlDB.GetMySqlConnection)
            {
                using MySqlCommand command = new MySqlCommand()
                {
                    Connection = mySqlDB.GetMySqlConnection,
                    CommandText = "CreateNewUser",
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 30
                };

                command.Parameters.AddWithValue("firstName", newUser.FirstName);
                command.Parameters.AddWithValue("lastName", newUser.LastName);
                command.Parameters.AddWithValue("phoneNumber", newUser.PhoneNumber);
                command.Parameters.AddWithValue("emailAddress", newUser.EmailAddress);
                command.Parameters.AddWithValue("password", newUser.Password);
                command.Parameters.AddWithValue("onlineStatus", newUser.OnlineStatus);
                command.Parameters.AddWithValue("isDisabled", newUser.IsDisabled);

                try
                {
                    mySqlDB.OpenConnection();
                    Int32 rowsAffected = (int)command.ExecuteNonQuery();                    
                    Debug.WriteLine($"########## Created User : <{rowsAffected}> ##########");
                }
                catch (Exception)
                {
                    throw new Exception($"Error creating new user.");
                }
            }
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
