using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Rule
{
	/// <summary>
	/// The set of rules that are used to determine which products are included in the collection.
	/// </summary>
	public class CollectionRuleSet
	{
		
		/// <summary>
		/// Whether products must match any or all of the rules to be included in the collection. If true, then products must match one or more of the rules to be included in the collection. If false, then products must match all of the rules to be included in the collection.
		/// </summary>
		[GraphName("appliedDisjunctively")]
		public bool AppliedDisjunctively { get; set; }
		
		/// <summary>
		/// The rules used to assign products to the collection.
		/// </summary>
		public List<CollectionRule> Rules { get; set; }
		
	}
}