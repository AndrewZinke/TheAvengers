using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    public class CustomersController : ApiController
    {
        //creates a list of customers to use in the methods
        private List<Customer> _customers;

        // GET: api/Customers
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

        // GET: api/Customers/5
        public Customer Get(int id)
        {
            var customer = _customers.ToList().Where(c => c.Id == id).First();
            return customer;
        }

        // POST: api/Customers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customers/5
        public void Put([FromBody]Customer customer)
        {
            _customers.Add(customer);
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
