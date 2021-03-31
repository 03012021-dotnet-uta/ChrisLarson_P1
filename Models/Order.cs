using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeShop.Models
{
    public class Order
    {
        public object CustomerId { get; internal set; }
        public object TreeId { get; internal set; }
    }
}
