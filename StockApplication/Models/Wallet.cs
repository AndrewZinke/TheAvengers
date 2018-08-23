using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockApplication.Models
{
	public class Wallet
	{
		//Wallet Id
		public int Id { get; set; }

		//Customer Id who owns this wallet 
		public int Customerid { get; set; }

		//Amount of Money available in this wallet
		public decimal Balance { get; set; }

		//State of Wallet {Active Wallet/Inactive Wallet}
		public bool IsActive { get; set; }

		//Customer details for this wallet
		public Customer Customer { get; set; }

		//Transactions that occured for this wallet
		public List<Transaction> Transactions { get; set; }

		public Wallet()
		{
			Customer = new Customer();
			Transactions = new List<Transaction>();
		}
	}

	//Delete this from wallet Class once we gain access to customer and transaction class from Lance and Andrew
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsActive { get; set; }
		public string Email { get; set; }

		public Wallet MyWallet { get; set; }
		public List<Share> Shares { get; set; }

		public Customer()
		{
			this.Shares = new List<Share>();
		}
	}
	public class Transaction
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int WalletId { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }
	}
	public class Share
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int StockId { get; set; }
		public decimal Price { get; set; }
	}
	public class Stock
	{
		public int Id { get; set; }
		public string Symbol { get; set; }
		public decimal Price { get; set; }
		public int AmountOfShares { get; set; }
		public decimal Change { get; set; }
		public double PercentChange { get; set; }
		public decimal Low { get; set; }
		public decimal High { get; set; }
	}
}