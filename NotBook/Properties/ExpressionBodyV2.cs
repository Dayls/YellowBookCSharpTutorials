using System;

namespace Start
{
	public class SaleItem
	{
		string _name;
		decimal _cost;

		public SaleItem(string name, decimal cost)
		{
			_name = name;
			_cost = cost;
		}

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public decimal Price
		{
			get => _cost;
			set => _cost = value;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var item = new SaleItem( "Shoes", 19.59m );
			Console.WriteLine($"{item.Name}: sells for {item.Price}");
		}
	}	// output: Shoes: sells for 19.59
}