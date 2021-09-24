using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Mutation.Error;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Error
{
	public class UserError : IDisplayableError
	{
		
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