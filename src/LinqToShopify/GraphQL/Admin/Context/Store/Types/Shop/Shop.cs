using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.App.Connections;
using LinqToShopify.GraphQL.Admin.Context.Common.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum.Image;
using LinqToShopify.GraphQL.Admin.Context.Store.Types.Shop.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Store.Types.Shop
{
	public class Shop
	{
		// TODO: Implement assignedFulfillmentOrders

		private AppConnection _availableChannelApps;

		/// <summary>
		/// List of sales channels not currently installed on the shop.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("availableChannelApps")]
		[GraphBackingField(nameof(_availableChannelApps))]
		public AppConnection AvailableChannelApps(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			bool reverse = false) => _availableChannelApps;
		
		// TODO: Implement currencySettings

		private StringConnection _customerTags;
		
		/// <summary>
		/// A list of tags that have been added to customer accounts.
		/// </summary>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <returns></returns>
		[GraphName("customerTags")]
		[GraphBackingField(nameof(_customerTags))]
		public StringConnection CustomerTags(int? first = null) => _customerTags;
		
		private StringConnection _draftOrderTags;
		
		/// <summary>
		/// A list of tags that have been added to draft orders.
		/// </summary>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <returns></returns>
		[GraphName("draftOrderTags")]
		[GraphBackingField(nameof(_draftOrderTags))]
		public StringConnection DraftOrderTags(int? first = null) => _draftOrderTags;

		// TODO: Implement fulfillmentOrders

		private MetafieldConnection _metafields;
		
		/// <summary>
		/// List of metafields that belong to the resource.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("metafields")]
		[GraphBackingField(nameof(_metafields))]
		public MetafieldConnection Metafields(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			[GraphName("namespace")] string @namespace = null,
			bool reverse = false) => _metafields;

		
		private StringConnection _orderTags;
		
		/// <summary>
		/// A list of tags that have been added to orders.
		/// </summary>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="sort">Sort type.</param>
		/// <returns></returns>
		[GraphName("orderTags")]
		[GraphBackingField(nameof(_orderTags))]
		public StringConnection OrderTags([GraphNonNullableParameter] int first,
			ShopTagSort sort = ShopTagSort.ALPHABETICAL) => _orderTags;

		private PrivateMetafieldConnection _privateMetafields;
		
		/// <summary>
		/// List of private metafields that belong to the resource.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("privateMetafields")]
		[GraphBackingField(nameof(_privateMetafields))]
		public PrivateMetafieldConnection PrivateMetafields(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			[GraphName("namespace")] string @namespace = null,
			bool reverse = false) => _privateMetafields;

		private ImageConnection _productImages;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="after"></param>
		/// <param name="before"></param>
		/// <param name="first"></param>
		/// <param name="last"></param>
		/// <param name="reverse"></param>
		/// <param name="sortKey"></param>
		/// <returns></returns>
		[GraphName("productImages")]
		public ImageConnection ProductImages(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			bool reverse = false,
			ProductImageSortKeys sortKey = ProductImageSortKeys.CREATED_AT) => _productImages;
		
		private StringConnection _productTags;
		
		/// <summary>
		/// A list of tags that have been added to products.
		/// </summary>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <returns></returns>
		[GraphName("productTags")]
		[GraphBackingField(nameof(_productTags))]
		public StringConnection ProductTags([GraphNonNullableParameter] int first) => _productTags;
		
		private StringConnection _productTypes;
		
		/// <summary>
		/// Types added to products.
		/// </summary>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <returns></returns>
		[GraphName("productTags")]
		[GraphBackingField(nameof(_productTypes))]
		public StringConnection ProductTypes([GraphNonNullableParameter] int first) => _productTypes;
		
		private StringConnection _productVendors;
		
		/// <summary>
		/// Types added to products.
		/// </summary>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <returns></returns>
		[GraphName("productVendors")]
		[GraphBackingField(nameof(_productVendors))]
		public StringConnection ProductVendors([GraphNonNullableParameter] int first) => _productVendors;
		
		// TODO: Implement search

	}
}