using System;

namespace Objects
{
	class Account
	{
		public string Name;
		public Account()
		{
			// this is default constructor. It is not nessesary to add default constructor
		}
	};

	class StructsAndObjectsDemo
	{
		public static void Main(string[] args)
		{
			Account RobsAccount;
			RobsAccount = new Account();	// this is an object. And this is should be remembered ->
											// ->	An object is an instance of a class.
			RobsAccount.Name = "Rob";
			Console.WriteLine( RobsAccount.Name );
			RobsAccount = new Account();
			RobsAccount.Name = "Jim";
			Console.WriteLine( RobsAccount.Name );
			Account Temp;
			Temp = RobsAccount;
			Temp.Name = "Paul";	// setting instance's Name using the Temp tag
								// robsAccount and Temp are holding the same instance
			Console.WriteLine( RobsAccount.Name );

			Account localVar;
			localVar = new Account();
			localVar.Name = "local";
			Console.WriteLine("localVar - " + localVar.Name + "\nTemp - " + Temp.Name);

			// when you hold a reference you do not hold an instance,
			// you hold a tag which is tied onto an instance...
		}
	}
}
