using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media
{
	public class MediaError
	{
		/// <summary>
		/// Code representing the type of error.
		/// </summary>
		[GraphName("code")]
		public MediaErrorCode Code { get; set; }
		
		/// <summary>
		/// Code representing the type of error.
		/// </summary>
		[GraphName("details")]
		public string Details { get; set; }
		
		/// <summary>
		/// Translated error message.
		/// </summary>
		[GraphName("message")]
		public string Message { get; set; }
	}
}