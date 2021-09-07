using System;
using System.Collections.Generic;
using LinqToGraphQL.Context;
using LinqToShopify.Exceptions;

namespace LinqToShopify.GraphQL
{
	public class ShopifyContext : GraphContext
	{
		public ShopifyContext(Dictionary<string, object> contextArguments) : base(contextArguments)
		{
			
		}

		protected static Uri BuildShopUri(string myShopifyUrl)
		{
			if (Uri.IsWellFormedUriString(myShopifyUrl, UriKind.Absolute) == false)
			{
				//Shopify typically returns the shop URL without a scheme. If the user is storing that as-is, the uri will not be well formed.
				//Try to fix that by adding a scheme and checking again.
				if (Uri.IsWellFormedUriString("https://" + myShopifyUrl, UriKind.Absolute) == false)
				{
					throw new ShopifyException($"The given {nameof(myShopifyUrl)} cannot be converted into a well-formed URI.");
				}

				myShopifyUrl = "https://" + myShopifyUrl;
			}

			var builder = new UriBuilder(myShopifyUrl)
			{
				Scheme = "https:",
				Port = 443,
				Path = "admin/api/2021-07/graphql.json"
			};

			return builder.Uri;
		}
	}
}