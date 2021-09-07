using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CountryCode;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Inputs
{
	public class InventoryItemUpdateInput
	{
		/// <summary>
		/// Unit cost associated with the inventory item, the currency is the shop's default currency.
		/// </summary>
		public decimal Cost { get; set; }
		
		/// <summary>
		/// The ISO code of the country of origin.
		/// </summary>
		public CountryCode CountryCodeOfOrigin { get; set; }
		
		/// <summary>
		/// List of country-specific harmonized system codes.
		/// </summary>
		[GraphName("countryHarmonizedSystemCodes")]
		public List<CountryHarmonizedSystemCodeInput> CountryHarmonizedSystemCodes { get; set; }
		
		/// <summary>
		/// The harmonized system code of the inventory item.
		/// </summary>
		[GraphName("harmonizedSystemCode")]
		public string HarmonizedSystemCode { get; set; }
		
		/// <summary>
		/// The ISO code of the province of origin.
		/// </summary>
		[GraphName("provinceCodeOfOrigin")]
		public string ProvinceCodeOfOrigin { get; set; }
		
		/// <summary>
		/// Whether the inventory item is tracked.
		/// </summary>
		[GraphName("tracked")]
		public bool Tracked { get; set; }
	}
}