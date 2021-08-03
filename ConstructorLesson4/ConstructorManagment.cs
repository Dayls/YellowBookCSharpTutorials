using System;
namespace Banking
{
	class Account
	{
		private string name;
		private string address;
		private decimal balance;

		public Account( string inName, decimal inBalance, string inAddress )
		{
			name = inName;
			address = inAddress;
			balance = inBalance;
		}

		public Account ( string inName, string inAddress ):
			this ( inName, 0, inAddress )	// passes parameters that are supplied and 
											// along with any default values that we created, on to the "proper" constructor to deal with.
		{	// since the call of this does all the work, the body of the constructor can be empty.
		}
		public Account ( string inName ):
			this ( inName, 0, "Not supplied" )
		{
		}
	}

	class Bank
	{
		public static void Main()
		{
			const int MAX_CUST = 100;
			Account[] Accounts = new Account[MAX_CUST];
			Accounts[0] = new Account("Rob", 100000, "Rob's house");

			Accounts[1] = new Account("Jim", "Jim's house");
			Accounts[2] = new Account("Fred");
		}
	}
}