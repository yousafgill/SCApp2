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
	}
}
