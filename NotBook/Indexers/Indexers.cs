using System;

namespace Start
{
	class SampleCollection<T> // generic class
	{
		// Declare an array to store the data elements.
		private T[] arr = new T[100];

		// Define the indexer to allow client code to use [] notation.
		public T this[int i]
		{
			get { return arr[i]; }
			set { arr[i] = value; }
		}
	}

	class Program
	{
		public static void Main()
		{
			var stringCollection = new SampleCollection<string>();
			stringCollection[0] = "Hello, World!";
			Console.WriteLine(stringCollection[0]);
		}
	}	// output: Hello, World!
}