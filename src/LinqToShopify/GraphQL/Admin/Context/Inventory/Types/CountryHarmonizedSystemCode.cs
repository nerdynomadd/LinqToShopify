using LinqToShopify.GraphQL.Admin.Context.Common.Types.CountryCode;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types
{
	/// <summary>
	/// Holds the country specific harmonized system code and the country ISO code.
	/// </summary>
	public class CountryHarmonizedSystemCode
	{
		/// <summary>
		/// Country ISO code.
		/// </summary>
		public CountryCode CountryCode { get; set; }
		
		/// <summary>
		/// Country specific harmonized system code.
		/// </summary>
		public string HarmonizedSystemCode { get; set; }
	}
}