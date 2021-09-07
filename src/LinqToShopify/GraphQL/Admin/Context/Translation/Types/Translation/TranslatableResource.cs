using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation
{
	/// <summary>
	/// A resource that has translatable fields.
	/// https://shopify.dev/api/admin/graphql/reference/translations/translatableresource
	/// </summary>
	public class TranslatableResource
	{
		/// <summary>
		/// Translatable content.
		/// </summary>
		[GraphName("resourceId")]
		public string ResourceId { get; set; }
		
		/// <summary>
		/// Translatable content.
		/// </summary>
		[GraphName("translatableContent")]
		public List<TranslatableContent> TranslatableContent { get; set; }

		private List<Translation> _translations;

		/// <summary>
		/// Translatable content translations.
		/// </summary>
		/// <param name="locale"></param>
		/// <param name="outdated"></param>
		/// <returns></returns>
		[GraphName("translations")]
		public List<Translation> Translations([GraphNonNullableParameter] string locale, bool? outdated = null) => _translations;
	}
}