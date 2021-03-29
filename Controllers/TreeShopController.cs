using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;


namespace TreeShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TreeShopController : ControllerBase
    {
        private readonly UserMethods business;
        public TreeShopController(UserMethods business)
        {
            this.business = business;
        }
        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Chris", "Larson"};
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public Person Post([FromBody] Person obj)
        {
            Console.WriteLine($"{obj.Fname} {obj.Lname} has made it through the Matrix.");

            Person obj1 = business.Login(obj);

            return obj1;
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
