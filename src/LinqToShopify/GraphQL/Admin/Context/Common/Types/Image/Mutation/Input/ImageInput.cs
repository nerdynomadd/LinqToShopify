using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.Image.Mutation.Input
{
	public class ImageInput
	{
		/// <summary>
		/// A word or phrase to share the nature or contents of an image.
		/// </summary>
		[GraphName("altText")]
		public string AltText { get; set; }
		
		/// <summary>
		/// Globally unique identifier.
		/// </summary>
		[GraphName("id")]
		public int Id { get; set; }
		
		/// <summary>
		/// The URL of the image. May be a signed upload URL.
		/// </summary>
		[GraphName("src")]
		public string Src { get; set; }
	}
}