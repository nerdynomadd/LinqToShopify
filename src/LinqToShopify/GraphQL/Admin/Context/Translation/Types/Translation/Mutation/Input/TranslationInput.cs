using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation.Mutation.Input
{
	public class TranslationInput
	{
		/// <summary>
		/// The key of the translation.
		/// </summary>
		[GraphName("key")]
		public string Key { get; set; }
		
		/// <summary>
		/// The locale of the translation.
		/// </summary>
		[GraphName("locale")]
		public string Locale { get; set; }
		
		/// <summary>
		/// The digest (hash) of the content being translated.
		/// </summary>
		[GraphName("translatableContentDigest")]
		public string TranslatableContentDigest { get; set; }
		
		/// <summary>
		/// The value of the translation.
		/// </summary>
		[GraphName("value")]
		public string Value { get; set; }
	}
}