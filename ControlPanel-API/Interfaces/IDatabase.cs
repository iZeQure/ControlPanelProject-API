﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Interfaces
{
    interface IDatabase
    {
        /// <summary>
        /// Open a new connection to database.
        /// </summary>
        void OpenConnection();

        /// <summary>
        /// Close current connection to database.
        /// </summary>
        void CloseConnection();

        /// <summary>
        /// Get the current state of the connection.
        /// </summary>
        /// <returns></returns>
        ConnectionState GetConnectionState();

        /// <summary>
        /// Check if the server is alive.
        /// </summary>
        /// <returns></returns>
        bool PingServer();
    }
}
