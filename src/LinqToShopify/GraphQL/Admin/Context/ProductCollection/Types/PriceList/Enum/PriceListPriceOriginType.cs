namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Enum
{
	/// <summary>
	/// Represents the origin of a price, either fixed (defined on the price list) or relative (calculated using an adjustment via a price list parent configuration).
	/// </summary>
	public enum PriceListPriceOriginType
	{
		FIXED,
		RELATIVE
	}
}