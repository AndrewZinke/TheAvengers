using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIs.Models;

namespace WebAPIs.Repositories
{
    public class CustomerRepo : DbContext
    {
        public CustomerRepo()
            :base("name = DefaultString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}