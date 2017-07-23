using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyQuotesApp.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyQuotesApp.api
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return new List<Quote>
            {
                new Quote {Id = 1, Content = "Happiness is not somthing ready", Author = "Dalai Lama"},
                new Quote {Id = 2, Content = "The best way to pay for a lovely", Author = "Richard Bach"},
                new Quote {Id = 3, Content = "If you want to be happy, be", Author = "Leo Tolstoy"}
            };
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
