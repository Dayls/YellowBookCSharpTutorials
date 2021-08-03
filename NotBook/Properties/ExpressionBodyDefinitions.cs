using System;

namespace Expression
{
	class Person
	{
		private string _lastName;
		private string _firstName;

		public Person ( string first, string last )
		{
			_firstName = first;
			_lastName = last;
		}

		// => replaces return for shorter method
		public string Name => $"{_firstName} {_lastName}";
	}

	public class Example
	{
		public static void Main()
		{
			var Person = new Person("Daniil", "Mohonko");
			Console.WriteLine(Person.Name);
		}
	}	// output: Daniil Mohonko
}