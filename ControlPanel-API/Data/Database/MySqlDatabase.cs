using ControlPanel_API.Interfaces;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Data.Database
{
    public class MySqlDatabase : IDatabase
    {
        #region Attributes
        private IConfiguration _configuration;
        private static MySqlDatabase instance = null;
        private MySqlConnection mySqlConnection;
        private string connectionString;
        #endregion

        #region Properties
        /// <summary>
        /// Get the instance of the MySqlConnection.
        /// </summary>
        public MySqlConnection GetMySqlConnection { get { return mySqlConnection; } }

        /// <summary>
        /// Initialize new instance of MySqlConnection.
        /// </summary>
        private MySqlConnection SetMySqlConnection { set { mySqlConnection = value; } }

        /// <summary>
        /// Get the instance of the Database.
        /// </summary>
        public static MySqlDatabase Instance
        {
            get
            {
                if (instance == null) return new MySqlDatabase();

                return instance;
            }
        }

        /// <summary>
        /// Set the connection string to the database.
        /// </summary>
        private string SetConnectionString { set { connectionString = value; } }
        #endregion

        #region Constructors
        /// <summary>
        /// Empty Constructor for object.
        /// </summary>
        public MySqlDatabase()
        {
            // Try to assign connection string from configuration.
            try
           {
                // Set connection string.
                SetConnectionString = $"Server=localhost;Database=debug;Uid=root;Pwd=;";
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            // Try to create a new instance of the MySqlConnection.
            try
            {
                // Set MySqlConnection.
                SetMySqlConnection = new MySqlConnection(connectionString);
            }
            catch (MySqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Set the configuration parameters for the Database.
        /// </summary>
        /// <param name="configuration"></param>
        public MySqlDatabase(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        public void OpenConnection()
        {
            try
            {
                // Check if the connection string is valid.
                if (GetMySqlConnection.ConnectionString == null) return;

                // Check if connection is already open.
                if (GetMySqlConnection.State == ConnectionState.Open) return;

                // If validated, open connection.
                GetMySqlConnection.Open();
                Debug.WriteLine($"########## Should open connection: [{GetMySqlConnection.State}] <{GetMySqlConnection.Ping()}> ##########");
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (MySqlException)
            {
                throw;
            } 
            catch (Exception)
            {
                throw;
            }
        }

        public void CloseConnection()
        {
            try
            {
                // Check if the connection is closed.
                if (GetMySqlConnection.State == ConnectionState.Closed)
                {
                    // If connection is open, then close it.
                    if (GetMySqlConnection.State == ConnectionState.Open) GetMySqlConnection.Close();
                }
                // Return if closed.
                else { return; }
            }
            catch (MySqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ConnectionState GetConnectionState()
        {
            // Return the current state of the connection.
            return GetMySqlConnection.State;
        }
    }
}
