using System;
namespace DesigningWithObjects
{
	class Account
	{
		private decimal balance = 0;		// balance is a class propertie. It is also inaccesible in other world

		public bool WithdrawFunds( decimal amount )
		{
			if ( balance < amount )
			{
				return false;
			}
			balance = balance - amount;
			return true;
		}

		public void PayInFunds ( decimal amount )
		{
			balance = balance + amount;
		}

		public decimal GetBalance()	// you can read balance but can not acces it
		{
			return balance;
		}
	}

	class Bank
	{
		public static void Main()
		{
			Account RobsAccount;
			RobsAccount = new Account();
			if ( RobsAccount.WithdrawFunds ( 5 ) )
				Console.WriteLine( "Cash withdrawn" );
			else
				Console.WriteLine( "Insufficient Funds" );
		}
	}
}