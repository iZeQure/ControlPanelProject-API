using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPanel_API.Data.Database;
using ControlPanel_API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace ControlPanel_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DebugController : ControllerBase
    {
        // GET: verify
        [HttpGet("v")]
        public IEnumerable<string> VerifyConnection()
        {
            //MySqlDatabase.Instance.OpenConnection();
            IDatabase db = MySqlDatabase.Instance;

            try
            {
                db.OpenConnection();

                return new string[] { $"Connection: {db.GetConnectionState()}", $"Ping: {db.PingServer()}" };
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
