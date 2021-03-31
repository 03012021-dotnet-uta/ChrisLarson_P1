using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChrisLarson_P1.Models;
using ChrisLarson_p1.Logic;

namespace ChrisLarson_P1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TreeShopController : ControllerBase
    {
        private readonly UserMethods _business;
        public TreeShopController(UserMethods business)
        {
            _business = business;
        }
        [HttpPost("register")]
        public ActionResult<Customer> Register(RawCustomer rawCustomer)
        {
            Customer customer = new Customer();
            if (!ModelState.IsValid)
            {
                return StatusCode(400, "Bad Request");
            }

            if(customer == null)
            {
                return StatusCode(409, "Not Acceptable");
            }
            return customer;
        }

        [HttpGet("login/{username}/{password}")]
        public ActionResult<Customer> Login(string username, string password)
        {
            Customer customer = new Customer();
            if (!ModelState.IsValid)
            {
                return StatusCode(400, "Bad Request");
            }else{
                customer = _business.Login(username, password);
            }


            if(customer == null)
            {
                return StatusCode(404, "User not found");
            }
            return customer;
        }

        public Customer Post([FromBody] Customer obj)
        {
            Console.WriteLine($"{obj.Fname} {obj.Lname} made it into C#");
            Customer customer = _business.Login(obj);
            return customer;
        }


        /************************************* 
         * THE FOLLOWING CODE MAY BE REMOVED *
         *************************************/
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
/*
        [HttpPost]
        public Customer Post([FromBody] Customer obj)
        {
            Console.WriteLine($"{obj.Fname} {obj.Lname} has made it through the Matrix.");

            Person obj1 = business.Login(obj);

            return obj1;
        }
*/
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
