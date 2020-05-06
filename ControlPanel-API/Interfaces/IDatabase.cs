using System;
using System.Collections.Generic;
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
    }
}
