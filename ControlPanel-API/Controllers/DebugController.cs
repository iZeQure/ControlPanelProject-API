using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public IEnumerable<string> Verify()
        {
            //MySqlDatabase.Instance.OpenConnection();
            IDatabase db = MySqlDatabase.Instance;

            try
            {
                db.OpenConnection();

                ConnectionState getState = db.GetConnectionState();

                return new string[] { $"Connection :", $"{getState}" };
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // GET: api/Debug
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Cookies", "Sandwiches", "Melons", "Cabbages" };
        }

        // GET: api/Debug/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Debug
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Debug/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
