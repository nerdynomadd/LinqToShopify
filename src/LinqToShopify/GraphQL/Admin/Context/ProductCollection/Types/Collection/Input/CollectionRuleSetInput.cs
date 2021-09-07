using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Input.Rule;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Input
{
	/// <summary>
	/// Specifies a rule set for the collection.
	/// </summary>
	public class CollectionRuleSetInput
	{
		/// <summary>
		/// Whether products must match any or all of the rules to be included in the collection. If true, then products must match one or more of the rules to be included in the collection. If false, then products must match all of the rules to be included in the collection.
		/// </summary>
		[GraphName("appliedDisjunctively")]
		public bool AppliedDisjunctively { get; set; }
		
		/// <summary>
		/// The rules used to assign products to the collection.
		/// </summary>
		[GraphName("rules")]
		public List<CollectionRuleInput> Rules { get; set; }
	}
}