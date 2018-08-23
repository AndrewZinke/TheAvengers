using StockApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StockApplication.Controllers
{
    public class WalletController : ApiController
    {
		List<Wallet> Wallets = new List<Wallet>()
		{
			new Wallet {Id = 1,Customerid = 1,Balance = 100, IsActive = true,
						Customer = new Customer(){Id = 1,FirstName = "Jeremy", LastName = "Ariche", IsActive = true, Email = "Jeremy.Ariche@email.com"}},
			new Wallet {Id = 2,Customerid = 2,Balance = 200, IsActive = true,
						Customer = new Customer(){Id = 2,FirstName = "Jared", LastName = "Ariche", IsActive = true, Email = "Jared.Ariche@email.com"}},
			new Wallet {Id = 3,Customerid = 3,Balance = 300, IsActive = true,
						Customer = new Customer(){Id = 3,FirstName = "Jack", LastName = "Ariche", IsActive = true, Email = "Jack.Ariche@email.com"}},
			new Wallet {Id = 4,Customerid = 4,Balance = 400, IsActive = true,
						Customer = new Customer(){Id = 4,FirstName = "Jill", LastName = "Ariche", IsActive = true, Email = "Jill.Ariche@email.com"}},
		};
		// GET: api/Wallet
		/*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/


		// GET: api/Wallet/5
		// GET Wallet info for current logged in customer
		public Wallet Get(int id)
		{
			//var wallet = Wallets.Where(w => w.Id == id && w.Customerid == {something}).SingleOrDefault();
			var wallet = Wallets.Where(w => w.Id == id).SingleOrDefault();
            return wallet;
        }

        // POST: api/Wallet
		// POST a new wallet if it does not exist for current logged in customer
        public void Post([FromBody]string value)
        {
			
        }

		// POST: api/Wallet
		// POST a new transaction corresponding to wallet operations for current logged in customer
		public void Post([FromBody]string value,int x)
		{

		}

		// PUT: api/Wallet/5
		public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Wallet/5
        /*public void Delete(int id)
        {
        }*/
    }
}
