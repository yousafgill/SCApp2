using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartAppUnitTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void AddFiveProducts()
		{
			//Expected Result
			decimal expected = (decimal)199.95;

			ShoppingCartApp.ShoppingCart cart = new ShoppingCartApp.ShoppingCart();
			// Add 5 Dove Soaps to Shopping Cart
			for (int i = 0; i < 5; i++)
			{
				ShoppingCartApp.Product p = new ShoppingCartApp.Product("Dove Soap", (decimal)39.99);
				cart.AddProduct(p, 1);
			}
			//Actual Result after adding 5 Dove Soap of Unit Price 39.99
			decimal actual = cart.TotalCartAmount();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void AddFiveAndThreeProducts()
		{

			//Expected Result
			decimal expected = (decimal)319.92;
			ShoppingCartApp.ShoppingCart cart = new ShoppingCartApp.ShoppingCart();

			// Add 5 Dove Soaps to Shopping Cart
			for (int i = 0; i < 5; i++)
			{
				ShoppingCartApp.Product p = new ShoppingCartApp.Product("Dove Soap", (decimal)39.99);
				cart.AddProduct(p, 1);
			}

			// Add 3 Dove Soaps to Shopping Cart
			for (int i = 0; i < 3; i++)
			{
				ShoppingCartApp.Product p = new ShoppingCartApp.Product("Dove Soap", (decimal)39.99);
				cart.AddProduct(p, 1);
			}
			//Actual Result after adding 8 Dove Soap of Unit Price 39.99
			decimal actual = cart.TotalCartAmount();
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CartAmountWithTax()
		{

			//Expected Result
			decimal expected = (decimal)314.96;

			//New ShoppingCart Object
			ShoppingCartApp.ShoppingCart cart = new ShoppingCartApp.ShoppingCart();

			// Add 5 Dove Soaps to Shopping Cart
			for (int i = 0; i < 2; i++)
			{
				ShoppingCartApp.Product p = new ShoppingCartApp.Product("Dove Soap", (decimal)39.99);
				cart.AddProduct(p, 1);
			}

			// Add 2 Axe Deo's to Shopping Cart
			for (int x = 0; x < 2; x++)
			{
				ShoppingCartApp.Product p1 = new ShoppingCartApp.Product("Axe Deo's", (decimal)99.99);
				cart.AddProduct(p1, 1);
			}

			//Actual Result after adding 2 Dove Soaps & 2 Axe Deos Plus Tax Rate 12.5
			decimal tax = (decimal)12.5;
			decimal actual = cart.TotalCartAmountIncTax(tax);

			Assert.AreEqual(expected, actual);
		}
	}
}
