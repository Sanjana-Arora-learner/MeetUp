using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Meetup.Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        // GET: api/<LocationController>
        [HttpGet]
        public IEnumerable<string> GetLocations()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LocationController>/5
        [HttpGet("{id}")]
        public string GetLocation(int id)
        {
            return "value";
        }

        // POST api/<EventController>
        [HttpPost]
        public void AddLocation([FromBody] string value)
        {
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void UpdateLocation(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public void DeleteLocation(int id)
        {
        }
    }
}
