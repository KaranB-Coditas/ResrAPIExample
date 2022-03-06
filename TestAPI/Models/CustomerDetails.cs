using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class CustomerDetails
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}