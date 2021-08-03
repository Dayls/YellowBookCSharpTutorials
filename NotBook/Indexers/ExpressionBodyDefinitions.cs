using System;

namespace Start
{
	class SampleCollection<T>
	{
		// Declare an array to store the data members
		private T[] arr = new T[100];
		int nextIndex = 0;

		// Define indexer to allow client code use [] notation
		public T this[int i] => arr[i];	// read-only indexer withs simplified syntax

		public void Add( T value )
		{
			if (nextIndex >= arr.Length)
				throw new IndexOutOfRangeException($"The collection can only hold {arr.Length} elements.");
			arr[nextIndex++] = value;
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