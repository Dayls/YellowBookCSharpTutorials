// Audo-Implemented properties can be used when get and accessors just assign a value to or
// retrueve a value from backing field withoud including any other additional logic

using System;

namespace Start
{
	public class SaleItem
	{
	   public string Name
	   { get; set; }	// just { get; set; } and that's it

	   public decimal Price
	   { get; set; }
	}

	class Program
	{
	   static void Main(string[] args)
	   {
	      var item = new SaleItem{ Name = "Shoes", Price = 19.95m };
	      Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
	   }
	}
	// The example displays output like the following:
	//       Shoes: sells for £19.95
}
