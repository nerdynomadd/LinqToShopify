using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Interface
{
	/// <summary>
	/// Published translations associated with the resource.
	/// </summary>
	public interface IHasPublishedTranslations
	{
		/// <summary>
		/// The translations associated with the resource.
		/// </summary>
		/// <param name="locale">Filters translations locale.</param>
		/// <returns></returns>
		[GraphName("translations")]
		public List<PublishedTranslation> Translations([GraphNonNullableParameter] string locale);
	}
}