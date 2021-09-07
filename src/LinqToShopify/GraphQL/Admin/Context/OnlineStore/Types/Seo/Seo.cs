using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Seo
{
	/// <summary>
	/// SEO information.
	/// </summary>
	public class Seo
	{
		/// <summary>
		/// SEO Description.
		/// </summary>
		[GraphName("description")]
		public string Description { get; set; }
		
		/// <summary>
		/// SEO Title.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }
	}
}