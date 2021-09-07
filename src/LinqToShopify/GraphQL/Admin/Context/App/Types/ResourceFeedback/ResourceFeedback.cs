using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.App.Types.ResourceFeedback
{
	/// <summary>
	/// Represents feedback from apps about a resource, and the steps required to set up the apps on the shop.
	/// </summary>
	public class ResourceFeedback
	{
		
		/// <summary>
		/// List of AppFeedback detailing issues regarding a resource.
		/// </summary>
		[GraphName("details")]
		public List<AppFeedback.AppFeedback> Details { get; set; }

		/// <summary>
		/// Summary of resource feedback pertaining to the resource.
		/// </summary>
		[GraphName("summary")]
		public string Summary { get; set; }
		
	}
}