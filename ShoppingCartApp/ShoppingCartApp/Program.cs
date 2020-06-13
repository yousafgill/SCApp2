using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Shopping Cart Application");
		}
	}

	//Product Class
	public class Product
	{
		//Constructor
		public Product(string name, decimal rate)
		{
			this.ProductName = name;
			this.UnitPrice = rate;
		}
		public string ProductName { get; set; }
		public decimal UnitPrice { get; set; }
	}

	//ShoppingCart Class
	public class ShoppingCart
	{

		//Properties
		public Product CartItem { get; set; }
		public decimal Quantity { get; set; }



		//Return Price of 1 Cart Item
		public decimal Price
		{
			get
			{
				decimal total = Math.Round(CartItem.UnitPrice * Quantity, 2);
				return total;
			}
		}

		//Local List of Items
		private List<ShoppingCart> CartItems = new List<ShoppingCart>();


		//Method to Add Products
		public void AddProduct(Product p, decimal quantity)
		{
			ShoppingCart cartitem = new ShoppingCart() { CartItem = p, Quantity = quantity };
			CartItems.Add(cartitem);
		}


		//Total Cart Value Exclusive Tax
		public decimal TotalCartAmount()
		{
			return CartItems.Sum(d => d.Price);
		}


		//Total Cart Value Inclusive Tax
		public decimal TotalCartAmountIncTax(decimal taxrate)
		{
			decimal extax = CartItems.Sum(d => d.Price);
			decimal taxamt = Math.Round(((extax / 100) * taxrate), 2);
			return extax + taxamt;
		}
	}
}
