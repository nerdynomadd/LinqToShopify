using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CountryCode;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Input
{
	/// <summary>
	/// The context that the price list applies to.
	/// </summary>
	public class PriceListContextRuleInput
	{
		[GraphName("countries")]
		public List<CountryCode> Countries { get; set; }
	}
}