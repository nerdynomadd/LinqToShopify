namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum.Variant
{
	/// <summary>
	/// The set of valid sort keys for the ProductVariant query.
	/// https://shopify.dev/api/admin/graphql/reference/products-and-collections/productvariantsortkeys
	/// </summary>
	public enum ProductVariantSortKeys
	{
		FULL_TITLE,
		ID,
		INVENTORY_LEVELS_AVAILABLE,
		INVENTORY_MANAGEMENT,
		INVENTORY_QUANTITY,
		NAME,
		POPULAR,
		POSITION,
		RELEVANCE,
		SKU,
		TITLE
	}
}