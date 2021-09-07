using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Domain
{
	/// <summary>
	/// A unique string that represents the address of a Shopify store on the Internet.
	/// </summary>
	public class Domain : Node
	{
		/// <summary>
		/// The host name of the domain (eg: example.com).
		/// </summary>
		[GraphName("host")]
		public string Host { get; set; }
		
		/// <summary>
		/// The localization of the domain, if it does not redirect.
		/// </summary>
		[GraphName("localization")]
		public DomainLocalization Localization { get; set; }
		
		/// <summary>
		/// Whether SSL is enabled or not.
		/// </summary>
		[GraphName("sslEnabled")]
		public bool SslEnabled { get; set; }
		
		/// <summary>
		/// The URL of the domain (eg: https://example.com).
		/// </summary>
		[GraphName("url")]
		public string Url { get; set; }
	}
}