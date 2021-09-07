using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Error;
using LinqToShopify.GraphQL.Admin.Context.Global.Link;

namespace LinqToShopify.GraphQL.Admin.Context.App.Types.AppFeedback
{
	/// <summary>
	/// Reports the status of shops and their resources and displays this information within Shopify admin. AppFeedback is used to notify merchants about steps they need to take to set up an app on their store.
	/// </summary>
	public class AppFeedback
	{
		/// <summary>
		/// The application associated to the feedback.
		/// </summary>
		[GraphName("app")]
		public App.App App { get; set; }
		
		/// <summary>
		/// A link to where merchants can resolve errors.
		/// </summary>
		[GraphName("link")]
		public Link Link { get; set; }
		
		/// <summary>
		/// The feedback message presented to the merchant.
		/// </summary>
		[GraphName("messages")]
		public List<UserError> Messages { get; set; }
	}
}