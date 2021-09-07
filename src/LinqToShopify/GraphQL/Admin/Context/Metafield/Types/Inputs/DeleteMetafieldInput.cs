using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs
{
	public class DeleteMetafieldInput
	{
		/// <summary>
		/// The ID of the metafield to delete.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
	}
}