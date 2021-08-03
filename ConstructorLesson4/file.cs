using System;
namespace Constructors
{
	public class Account
	{
		// private member data
		private string name;
		private string address;
		private decimal balance;

		// constructor is a method that will invoke automatically whenever an instance of class or struct is created
		public Account( string inName, string inAdress,
						decimal inBalance )		// this is a constructor
		{
			name = inName;
			address = inAdress;
			balance = inBalance;

			Console.WriteLine(name + " live in " + address + " and has " + balance + " dollars");
		}

		public Account(string inName, string inAddress )	// this is overload constructor
		{
			name = inName;
			address = inAddress;
			balance = 0;
			Console.WriteLine( name + " " + address + " " + balance );
		}

		public static string Name(Account someone)
		{
			return someone.name;
		}
	}

	class Bank
	{
		public static void Main()
		{
			Account robsAccount;
			string name = Console.ReadLine();
			robsAccount = new Account(name, $"{name}'s house", 100_000);	// creating class instance that has your own constructor

			Account overloadAccount;
			overloadAccount = new Account("Overload", "Overload's house");
			Console.WriteLine(Account.Name(robsAccount));
		}
	}
}