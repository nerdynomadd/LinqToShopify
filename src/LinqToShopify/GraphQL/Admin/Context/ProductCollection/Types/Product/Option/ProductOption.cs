using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Interface;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Option
{
	/// <summary>
	/// Product property names like "Size", "Color", and "Material". Variants are selected based on permutations of these options. 255 characters limit each.
	/// </summary>
	public class ProductOption : Node, IHasPublishedTranslations
	{
		/// <summary>
		/// The product option’s name.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// The product option's position.
		/// </summary>
		public int Position { get; set; }
		
		private List<PublishedTranslation> _translations;

		/// <summary>
		/// The translations associated with the resource.
		/// </summary>
		/// <param name="locale">Filters translations locale.</param>
		/// <returns></returns>
		[GraphName("translations")]
		[GraphBackingField(nameof(_translations))]
		public List<PublishedTranslation> Translations(string locale) => _translations;
		
		/// <summary>
		/// The corresponding value to the product option name.
		/// </summary>
		[GraphName("values")]
		public List<string> Values { get; set; }
	}
}