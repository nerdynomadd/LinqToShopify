using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Enum.Rule;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Input.Rule
{
	/// <summary>
	/// Specifies a rule to associate with a collection.
	/// </summary>
	public class CollectionRuleInput
	{
		/// <summary>
		/// The attribute that the rule focuses on (for example, title or product_type).
		/// </summary>
		[GraphName("column")]
		public CollectionRuleColumn Column { get; set; }
		
		/// <summary>
		/// The value that the operator is applied to (for example, Hats).
		/// </summary>
		[GraphName("condition")]
		public string Condition { get; set; }
		
		/// <summary>
		/// The type of operator that the rule is based on (for example, equals, contains, or not_equals).
		/// </summary>
		[GraphName("relation")]
		public CollectionRuleRelation Relation { get; set; }
	}
}