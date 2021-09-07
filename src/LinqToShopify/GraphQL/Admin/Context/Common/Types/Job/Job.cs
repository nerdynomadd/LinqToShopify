using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.Job
{
	public class Job : Node
	{
		/// <summary>
		/// This indicates if the job is still queued or has been run.
		/// </summary>
		[GraphName("done")]
		public bool Done { get; set; }
	}
}