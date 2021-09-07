using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Navigable;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Interface;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Page
{
	/// <summary>
	/// Represents an article in an OnlineStoreBlog object. Articles appear in reverse chronological order, with the most recent entry at the top of the blog's page. A blog can contain any number of articles.
	/// </summary>
	public class OnlineStoreArticle : INode, IHasPublishedTranslations, INavigable
	{
		/// <summary>
		/// An object with an ID to support global identification.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }

		private List<PublishedTranslation> _translations;

		/// <summary>
		/// The translations associated with the resource.
		/// </summary>
		/// <param name="locale">Filters translations locale.</param>
		/// <returns></returns>
		[GraphName("translations")]
		public List<PublishedTranslation> Translations([GraphNonNullableParameter] string locale) => _translations;

		/// <summary>
		/// A default cursor that returns the single next record, sorted ascending by ID.
		/// </summary>
		[GraphName("defaultCursor")]
		public string DefaultCursor { get; set; }
	}
}