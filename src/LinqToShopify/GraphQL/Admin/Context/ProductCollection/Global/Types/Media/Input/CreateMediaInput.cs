using LinqToGraphQL.Attributes;
using LinqToGraphQL.Translator.Behavior;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Input
{
	/// <summary>
	/// Specifies the input fields required to create a media object.
	/// </summary>
	public class CreateMediaInput
	{
		/// <summary>
		/// The alt text associated to the media.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Alt { get; set; }
		
		/// <summary>
		/// The alt text associated to the media.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public MediaContentType MediaContentType { get; set; }
		
		/// <summary>
		/// The original source of the media object. May be an external URL or signed upload URL.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string OriginalSource { get; set; }
	}
}