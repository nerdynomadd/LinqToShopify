using System;
using System.Net.Http;

namespace LinqToShopify.Exceptions
{
	public class ShopifyHttpException : HttpRequestException
	{
		public ShopifyHttpException()
			: base(null, null)
		{ }

		public ShopifyHttpException(string? message)
			: base(message, null)
		{ }

		public ShopifyHttpException(string? message, Exception? inner)
			: base(message, inner)
		{
			if (inner != null)
			{
				HResult = inner.HResult;
			}
		}
	}
}