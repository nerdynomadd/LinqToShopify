using System.Collections.Generic;
using LinqToShopify.GraphQL.Admin.Context.Global.Mutation.Error;
using Newtonsoft.Json;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Error
{
	public class UserError : IDisplayableError
	{
		
		/// <summary>
		/// The path to the input field that caused the error.
		/// </summary>
		[JsonProperty("field")]
		public List<string> Field { get; set; }

		/// <summary>
		/// The error message.
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; set; }
		
	}
}