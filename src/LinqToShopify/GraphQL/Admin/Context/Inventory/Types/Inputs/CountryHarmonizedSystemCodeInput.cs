using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CountryCode;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Inputs
{
	public class CountryHarmonizedSystemCodeInput
	{
		/// <summary>
		/// Country ISO code.
		/// </summary>
		[GraphName("countryCode")]
		public CountryCode CountryCode { get; set; }
		
		/// <summary>
		/// Country specific harmonized system code.
		/// </summary>
		[GraphName("harmonizedSystemCode")]
		public string HarmonizedSystemCode { get; set; }
	}
}