using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;

namespace LinqToShopify.GraphQL.Admin.Context.Global.Link
{
	public class Link
	{
		/// <summary>
		/// A context-sensitive label for the link.
		/// </summary>
		[GraphName("label")]
		public string Label { get; set; }

		private List<PublishedTranslation> _translations;
		
		/// <summary>
		/// The translations associated with the resource.
		/// </summary>
		/// <param name="locale"></param>
		/// <returns></returns>
		[GraphName("translations")]
		[GraphBackingField(nameof(_translations))]
		public List<PublishedTranslation> Translations(string locale) => _translations;
		
		/// <summary>
		/// The URL that the link visits.
		/// </summary>
		[GraphName("url")]
		public string Url { get; set; }
	}
}