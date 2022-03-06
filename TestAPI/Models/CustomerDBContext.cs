using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class CustomerDBContext : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CustomerDetails> CustomerDetails { get; set; }
    }
}