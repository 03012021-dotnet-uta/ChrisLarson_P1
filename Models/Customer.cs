using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TreeShop.Models;

namespace ChrisLarson_P1.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; } = Guid.NewGuid();
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime memberSince { get; set; } = DateTime.Now;

        ICollection<Order> Orders { get; set; } = new List<Order>();
        
    }
}