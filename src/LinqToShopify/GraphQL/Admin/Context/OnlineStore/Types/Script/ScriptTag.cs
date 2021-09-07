using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.LegacyInteroperability;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script
{
	public class ScriptTag : INode, ILegacyInteroperability
	{
		/// <summary>
		/// Whether the Shopify CDN can cache and serve the script tag. If true, then the script will be cached and served by the CDN. The cache expires 15 minutes after the script tag is successfully returned. If false, then the script will be served as is.
		/// </summary>
		[GraphName("cache")]
		public bool Cache { get; set; }
		
		/// <summary>
		/// Globally unique identifier.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// The ID of the corresponding resource in the REST Admin API.
		/// </summary>
		[GraphName("legacyResourceId")]
		public ulong LegacyResourceId { get; set; }
		
		[GraphName("displayScope")]
		public ScriptTagDisplayScope DisplayScope { get; set; }
		
		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		[GraphName("updatedAt")]
		public DateTime UpdatedAt { get; set; }
	}
}