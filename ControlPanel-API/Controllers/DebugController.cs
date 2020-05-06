using System;
using System.Collections.Generic;
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
        // GET: api/Debug
        [HttpGet]
        public IEnumerable<string> Get()
        {
            MySqlDatabase.Instance.OpenConnection();

            try
            {
                return new string[] { $"Connection :", $"{MySqlDatabase.Instance.GetMySqlConnection.State}" };
            }
            catch (MySqlException)
            {
                return new string[] { $"Error: ", $"Could not open connection." };
            }
            catch (Exception)
            {
                throw;
            }
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
