using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input
{
	/// <summary>
	/// Specifies the product to delete.
	/// </summary>
	public class ProductDeleteInput
	{
		/// <summary>
		/// The ID of the product.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
	}
}