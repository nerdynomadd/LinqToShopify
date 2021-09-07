namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Seo.Mutation.Input
{
	/// <summary>
	/// SEO information.
	/// </summary>
	public class SEOInput
	{
		/// <summary>
		/// SEO description of the product.
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// SEO title of the product.
		/// </summary>
		public string Title { get; set; }
	}
}