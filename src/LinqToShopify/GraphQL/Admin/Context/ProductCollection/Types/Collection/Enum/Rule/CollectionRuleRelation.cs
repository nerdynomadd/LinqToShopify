namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Enum.Rule
{
	/// <summary>
	/// Specifies the relationship between the column and the condition.
	/// </summary>
	public enum CollectionRuleRelation
	{
		STARTS_WITH,
		ENDS_WITH,
		EQUALS,
		GREATER_THAN,
		IS_NOT_SET,
		IS_SET,
		LESS_THAN,
		NOT_CONTAINS,
		NOT_EQUALS,
		CONTAINS
	}
}