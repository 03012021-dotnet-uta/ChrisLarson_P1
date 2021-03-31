using System;
using System.Linq;
using ChrisLarson_P1.Models;
using Models;

namespace ChrisLarson_P1.Repository
{
    public class TreeShopRepo
    {
        private readonly TreeShopContext _context;
        public TreeShopRepo() { } //Created so that it can be tested without having to create a context and repo
        public TreeShopRepo(TreeShopContext context)
        {
            _context = context;
        }

        /* 
        !! May be unnecessary !!
        */
        public Customer Login(Customer user)
        {
            //Customer user = _context.Customer.FirstOrDefault(p => p.Fname == user.Fname && p.Lname == user.Lname);
            
            return user;
        }

        //newCustomer1 may be unnecessary
        public Customer Register(Customer newCustomer)
        {
            var newCustomer1 = _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return _context.Customers.FirstOrDefault(c => c.CustomerId == newCustomer.CustomerId);
        }

        public Customer GetCustomerByUsername(string username)
        {
            return _context.Customers.FirstOrDefault(c => c.Username == username);
        }

        

    }
}