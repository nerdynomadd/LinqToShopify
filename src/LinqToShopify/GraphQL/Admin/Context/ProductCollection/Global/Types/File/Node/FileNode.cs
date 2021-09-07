using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Interface;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Node
{
	public class FileNode : IFile, INode
	{
		/// <summary>
		/// A word or phrase to describe the contents or the function of a file.
		/// </summary>
		[GraphName("alt")]
		public string Alt { get; set; }
		
		/// <summary>
		/// The date and time (ISO 8601 format) when the product was created.
		/// </summary>
		[GraphName("alt")]
		public DateTime CreatedAt { get; set; }
		
		/// <summary>
		/// Any errors that have occurred on the file.
		/// </summary>
		[GraphName("fileErrors")]
		public List<FileError> FileErrors { get; set; }
		
		/// <summary>
		/// Code representing the type of error.
		/// </summary>
		[GraphName("fileStatus")]
		public FileStatus FileStatus { get; set; }
		
		/// <summary>
		/// Code representing the type of error.
		/// </summary>
		[GraphName("preview")]
		public MediaPreviewImage Preview { get; set; }

		/// <summary>
		/// Globally unique identifier.
		/// </summary>
		public string Id { get; set; }
	}
}