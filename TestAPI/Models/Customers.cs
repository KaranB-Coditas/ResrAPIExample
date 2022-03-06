using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public CustomerDetails Detail { get; set; }
    }
}