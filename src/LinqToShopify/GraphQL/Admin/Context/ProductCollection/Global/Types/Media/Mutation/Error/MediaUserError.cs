using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Mutation.Error;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Mutation.Error
{
	/// <summary>
	/// Represents an error that happens during execution of a Media query or mutation.
	/// </summary>
	public class MediaUserError : IDisplayableError
	{
		/// <summary>
		/// The error code.
		/// </summary>
		[GraphName("code")]
		public MediaUserErrorCode Code { get; set; }
		
		/// <summary>
		/// The path to the input field that caused the error.
		/// </summary>
		[GraphName("field")]
		public List<string> Field { get; set; }

		/// <summary>
		/// The error message.
		/// </summary>
		[GraphName("message")]
		public string Message { get; set; }
		
	}
}