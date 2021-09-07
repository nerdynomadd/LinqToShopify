using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Enum.Rule;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Rule
{
	/// <summary>
	/// Collections may use rules to automatically include the matching products. This defines restrictions for a type of rule.
	/// </summary>
	public class CollectionRuleConditions
	{
		/// <summary>
		/// Allowed relations of the rule.
		/// </summary>
		[GraphName("allowedRelations")]
		public List<CollectionRuleRelation> AllowedRelations { get; set; }
		
		/// <summary>
		/// Most commonly used relation for this rule.
		/// </summary>
		[GraphName("defaultRelation")]
		public CollectionRuleRelation DefaultRelation { get; set; }
		
		/// <summary>
		/// Type of the rule.
		/// </summary>
		[GraphName("ruleType")]
		public CollectionRuleColumn RuleType { get; set; }
	}
}