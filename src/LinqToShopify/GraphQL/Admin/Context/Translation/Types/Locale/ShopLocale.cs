using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale
{
	public class ShopLocale
	{
		/// <summary>
		/// Locale identifier.
		/// </summary>
		[GraphName("locale")]
		public string Locale { get; set; }
		
		/// <summary>
		/// Locale name.
		/// </summary>
		[GraphName("name")]
		public string Name { get; set; }
		
		/// <summary>
		/// Whether or not this is the default locale for the shop.
		/// </summary>
		[GraphName("primary")]
		public bool Primary { get; set; }
		
		/// <summary>
		/// Whether or not the locale is published.
		/// </summary>
		[GraphName("published")]
		public bool Published { get; set; }
	}
}