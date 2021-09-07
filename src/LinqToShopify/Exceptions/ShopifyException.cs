using System;

namespace LinqToShopify.Exceptions
{
	public class ShopifyException : Exception
	{
		public ShopifyException(string message) : base(message)
		{
			
		}
	}
}