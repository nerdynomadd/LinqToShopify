using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ShippingFulfillment.Types.Shipping
{
	/// <summary>
	/// The shipping method for the delivery.
	/// </summary>
	public class ShippingMethod
	{
		/// <summary>
		/// A unique code associated with the rate.
		/// </summary>
		[GraphName("code")]
		public string Code { get; set; }
		
		/// <summary>
		/// A description of the rate, which customers will see at checkout.
		/// </summary>
		[GraphName("label")]
		public string Label { get; set; }
	}
}