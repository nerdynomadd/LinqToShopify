using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Global.Mutation.Error
{
	/// <summary>
	/// Represents an error in the input of a mutation.
	/// </summary>
	public interface IDisplayableError
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