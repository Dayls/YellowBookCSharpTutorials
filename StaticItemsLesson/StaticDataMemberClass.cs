using System;
namespace MemberClass
{
	public class Account
	{
		public decimal Balance;
		public static decimal InterestRateCharged;

		private static decimal minIncome = 10_000;
		private static int minAge = 18;

		public static bool AccountAllowed ( decimal income, int age )
		{
			if( income >= minIncome && age >= minAge )
				return true;
			else
				return false;
		}
	}

	class Bank
	{
		public static void Main()
		{
			Account RobsAccount = new Account();
			RobsAccount.Balance = 100;
			Account.InterestRateCharged = 10;	// changing the static member of Account class by
												// writing <class name>.<member> = <data>; not <class instance name>
			if ( Account.AccountAllowed ( 25000, 17 ) )
				Console.WriteLine("Allowed account");
			else
				Console.WriteLine("Not allowed account");
		}
	}
}