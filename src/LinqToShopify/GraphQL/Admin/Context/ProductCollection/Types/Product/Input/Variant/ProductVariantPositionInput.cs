using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Variant
{
	/// <summary>
	/// Represents a product variant position.
	/// </summary>
	public class ProductVariantPositionInput
	{
		/// <summary>
		/// Represents a product variant position.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// The order of the product variant in the list of product variants. The first position in the list is 1.
		/// </summary>
		[GraphName("position")]
		public int Position { get; set; }
	}
}