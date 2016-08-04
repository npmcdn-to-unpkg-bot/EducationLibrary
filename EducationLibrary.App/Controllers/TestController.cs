using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EducationLibrary.App.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EducationLibrary.App.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private List<Test> _local = new List<Test> {
                new Test {Id = 1, Name = "First", Description = "Something about One" },
                new Test {Id = 2, Name = "Second", Description = "Something about Two" },
                new Test {Id = 3, Name = "Third", Description = "Something about Three" }
            };

        // GET: api/values
        [HttpGet]
        public IEnumerable<Test> Get()
        {
            return (_local);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
