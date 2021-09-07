using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CountryCode;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList
{
	/// <summary>
	/// Represents a set of facts about the customer used to determine price list eligibility.
	/// </summary>
	public class PriceListContextRule
	{
		/// <summary>
		/// A list of two letter country codes that determines price list eligibility.
		/// </summary>
		[GraphName("countries")]
		public List<CountryCode> Countries { get; set; }
	}
}