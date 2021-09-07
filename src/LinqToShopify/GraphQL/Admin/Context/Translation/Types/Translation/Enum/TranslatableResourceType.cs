namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation.Enum
{
	/// <summary>
	/// Specifies the type of resources that are translatable.
	/// https://shopify.dev/api/admin/graphql/reference/translations/translatableresourcetype
	/// </summary>
	public enum TranslatableResourceType
	{
		COLLECTION,
		DELIVERY_METHOD_DEFINITION,
		EMAIL_TEMPLATE,
		LINK,
		METAFIELD,
		ONLINE_STORE_ARTICLE,
		ONLINE_STORE_BLOG,
		ONLINE_STORE_PAGE,
		ONLINE_STORE_THEME,
		PAYMENT_GATEWAY,
		PRODUCT,
		PRODUCT_OPTION,
		PRODUCT_VARIANT,
		SHOP,
		SHOP_POLICY,
		SMS_TEMPLATE
	}
}