using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.App.Connections;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Connection;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publishable.Interface
{
	public interface IPublishable : INode
	{
		/// <summary>
		/// The number of publications a resource is published to without feedback errors.
		/// </summary>
		[GraphName("availablePublicationCount")]
		public int AvailablePublicationCount { get; set; }
		
		/// <summary>
		/// The number of publications a resource is published on.
		/// </summary>
		[GraphName("publicationCount")]
		public int PublicationCount { get; set; }
		
		/// <summary>
		/// Check to see whether the resource is published to the calling app's publication.
		/// </summary>
		[GraphName("publishedOnCurrentPublication")]
		public bool PublishedOnCurrentPublication { get; set; }

		/// <summary>
		/// Check to see whether the resource is published to a given publication.
		/// </summary>
		/// <param name="publicationId">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("publishedOnPublication")]
		public bool PublishedOnPublication([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] int publicationId);

		/// <summary>
		/// The list of resources that are either published or staged to be published to a publication.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="onlyPublished">Whether to return only the resources that are currently published. If false, then also returns the resources that are scheduled or staged to be published.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("resourcePublications")]
		public ResourcePublicationConnection ResourcePublications(string? after = null, string? before = null, int? first = null, int? last = null, bool onlyPublished = true, bool reverse = false);

		/// <summary>
		/// The list of resources that are either published or staged to be published to a publication.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="onlyPublished">Whether to return only the resources that are currently published. If false, then also returns the resources that are scheduled or staged to be published.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("resourcePublicationsV2")]
		public ResourcePublicationV2Connection ResourcePublicationsV2(string? after = null, string? before = null, int? first = null, int? last = null, bool onlyPublished = true, bool reverse = false);

		/// <summary>
		/// The list of publications that the resource is not published to.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("unpublishedPublications")]
		public PublicationConnection UnpublishedPublications(string? after = null, string? before = null, int? first = null, int? last = null, bool reverse = false);
	}
}