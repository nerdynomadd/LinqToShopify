using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Navigable;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Interface;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Page
{
	/// <summary>
	/// Shopify stores come with a built-in blogging engine, allowing a shop to have one or more blogs. Blogs are meant to be used as a type of magazine or newsletter for the shop, with content that changes over time.
	/// </summary>
	public class OnlineStorePage : INode, IHasPublishedTranslations, INavigable
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