using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockApplication.Models
{
	public class Wallet
	{
		
		private Customer _customer = new Customer();
		private List<Transaction> _transactions = new List<Transaction>();

		//Wallet Id
		public int Id { get; set; }

		//Customer Id who owns this wallet 
		public int Customerid { get; set; }

		//Amount of Money available in this wallet
		public decimal Balance { get; set; }

		//State of Wallet {Active Wallet/Inactive Wallet}
		public bool IsActive { get; set; }

		//Customer details for this wallet
		public Customer Customer
		{
			get { return _customer; }
			set { }
		}

		//Transactions that occured for this wallet
		public List<Transaction> Transactions
		{
			get { return _transactions; }
			set { }
		}
	}

	//Delete this from wallet Class once we gain access to customer and transaction class from Lance and Andrew
	public class Customer
	{
		private Wallet _wallet = new Wallet();
		private List<Share> _shares = new List<Share>();

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsActive { get; set; }
		public string Email { get; set; }

		public Wallet MyWallet
		{
			get { return _wallet; }
			set { }
		}
		public List<Share> Shares
		{
			get { return _shares; }
			set { }
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