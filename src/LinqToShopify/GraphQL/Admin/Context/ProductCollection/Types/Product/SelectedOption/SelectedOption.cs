using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.SelectedOption
{
	/// <summary>
	/// Properties used by customers to select a product variant. Products can have multiple options, like different sizes or colors.
	/// </summary>
	public class SelectedOption
	{
		/// <summary>
		/// The product option’s name.
		/// </summary>
		[GraphName("name")]
		public string Name { get; set; }
		
		/// <summary>
		/// The product option’s value.
		/// </summary>
		[GraphName("value")]
		public string Value { get; set; }
	}
}