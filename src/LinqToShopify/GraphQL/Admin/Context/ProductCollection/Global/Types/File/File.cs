using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Interface;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File
{
	/// <summary>
	/// An auto-generated type for paginating through multiple Files.
	/// </summary>
	public class File : IFile
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
	}
}