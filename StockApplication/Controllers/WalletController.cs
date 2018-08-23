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
		//Dummy data to test api with in fiddler
		static List<Wallet> Wallets = new List<Wallet>()
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
		public IEnumerable<Wallet> Get()
        {
            return Wallets;
        }

		// GET: api/Wallet/5
		// GET Wallet info for current logged in customer
		public Wallet Get(int id)
		{
			//var wallet = Wallets.Where(w => w.Id == id && w.Customerid == {something}).SingleOrDefault();
			var wallet = Wallets.Where(w => w.Id == id).SingleOrDefault();
			if (wallet == null)
			{
				throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
			}
			return wallet;
        }

        // POST: api/Wallet
		// POST a new wallet if it does not exist for current logged in customer
        public void Post([FromBody]Wallet wallet)
        {
			Wallets.Add(wallet);
        }

		// POST: api/Wallet
		// POST a new transaction corresponding to wallet operations for current logged in customer
		public void Post(int id,[FromBody]Transaction transaction)
		{
			if (id > 0) Wallets[id-1].Transactions.Add(transaction);
		}

		// PUT: api/Wallet/5
		// PUT: Update the wallet's balance
		public void Put(int id, [FromBody]decimal update)
        {
			if(id > 0) Wallets[id-1].Balance += update;
        }
	}
}
