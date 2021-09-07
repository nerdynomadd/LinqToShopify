using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Connections;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Interface
{
	public interface IHasMetafields
	{
		/// <summary>
		/// List of metafields that belong to the resource.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="namespace">The metafield namespace to filter by.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("metafields")]
		public MetafieldConnection Metafields(string after = default, 
			string before  = default, 
			int? first = null, 
			int? last = null, 
			[GraphName("namespace")] string @namespace = default, 
			bool reverse = default);
		
		/// <summary>
		/// Returns a metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the metafield.</param>
		/// <param name="namespace">The key for the metafield.</param>
		/// <returns></returns>
		[GraphName("metafield")]
		public Metafield Metafield([GraphNonNullableParameter] string key,
			[GraphNonNullableParameter] [GraphName("namespace")] string @namespace);
		
		/// <summary>
		/// List of private metafields that belong to the resource.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="namespace">The metafield namespace to filter by.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("privateMetafields")]
		public PrivateMetafieldConnection PrivateMetafields(string after = default, 
			string before = default, 
			int? first = null, 
			int? last = null, 
			[GraphName("namespace")] string @namespace = default, 
			bool reverse = default);
		
		/// <summary>
		/// Returns a private metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the metafield.</param>
		/// <param name="namespace">The key for the metafield.</param>
		/// <returns></returns>
		[GraphName("metafield")]
		public PrivateMetafield PrivateMetafield([GraphNonNullableParameter] string key,
			[GraphNonNullableParameter] [GraphName("namespace")] string @namespace);
	}
}