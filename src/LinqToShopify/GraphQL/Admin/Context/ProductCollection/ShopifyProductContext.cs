using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Context.Options.Builder.Configure;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration;
using LinqToGraphQL.Set.Configuration.Builder;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image.Mutation.Input;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Input;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Move.Input;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Image;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result.Image;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result.Media;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Variant;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection
{
	public class ShopifyProductContext : ShopifyBaseContext
	{
		internal ShopifyProductContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}

		/// <summary>
		/// List of products.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="query"></param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="savedSearchId">The ID of an existing saved search. The search’s query string is used as the query argument.</param>
		/// <param name="sortKey">Sort the underlying list by the given key.</param>
		/// <returns></returns>
		[GraphName("products")]
		public GraphSet<ProductConnection> GetProducts(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			string query = null,
			bool reverse = false,
			[GraphParameterType(typeof(ID))] string savedSearchId = null,
			ProductSortKeys sortKey = ProductSortKeys.ID)
		{
			return Set<ProductConnection>(new object[]
			{
				after, before, first, last, query, reverse, savedSearchId, sortKey
			});
		}

		/// <summary>
		/// Returns a Product resource by ID.
		/// </summary>
		/// <param name="id">The ID of the Product to return.</param>
		/// <returns></returns>
		[GraphName("product")]
		public GraphSet<Product> GetProduct([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<Product>(new object[]
			{
				id
			});
		}

		/// <summary>
		/// Return a product by its handle.
		/// </summary>
		/// <param name="handle">The handle of the product.</param>
		/// <returns></returns>
		[GraphName("productByHandle")]
		public GraphSet<Product> GetProductByHandle([GraphNonNullableParameter] string handle)
		{
			return Set<Product>(new object[]
			{
				handle
			});
		}

		/// <summary>
		/// List of the product variants.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="query"></param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="savedSearchId">The ID of an existing saved search. The search’s query string is used as the query argument.</param>
		/// <param name="sortKey">Sort the underlying list by the given key.</param>
		/// <returns></returns>
		[GraphName("productVariants")]
		public GraphSet<ProductVariantConnection> GetProductVariants(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			string query = null,
			bool reverse = false,
			[GraphParameterType(typeof(ID))] string savedSearchId = null,
			ProductSortKeys sortKey = ProductSortKeys.ID)
		{
			return Set<ProductVariantConnection>(new object[]
			{
				after, before, first, last, query, reverse, savedSearchId, sortKey
			});
		}

		/// <summary>
		/// Returns a ProductVariant resource by ID.
		/// </summary>
		/// <param name="id">The ID of the ProductVariant to return.</param>
		/// <returns></returns>
		[GraphName("productVariant")]
		public GraphSet<ProductVariant> GetProductVariant([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<ProductVariant>(new object[]
			{
				id
			});
		}

		/// <summary>
		/// Creates a product.
		/// </summary>
		/// <param name="input">The properties of the new product.</param>
		/// <param name="media">The properties of the new product.</param>
		/// <returns></returns>
		[GraphName("productCreate")]
		public GraphSet<CreateProductMutationResult> CreateProduct([GraphNonNullableParameter] ProductInput input,
			[GraphParameterTypeName("[CreateMediaInput!]")] List<CreateMediaInput> media = null)
		{
			return Set<CreateProductMutationResult>(new object[]
			{
				input,
				media
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		
		/// <summary>
		/// Deletes a product, including all associated variants and media.
		/// </summary>
		/// <param name="input">Specifies the product to delete by its ID.</param>
		/// <returns></returns>
		[GraphName("productDelete")]
		public GraphSet<DeleteProductMutationResult> DeleteProduct([GraphNonNullableParameter] ProductDeleteInput input)
		{
			return Set<DeleteProductMutationResult>(new object[]
			{
				input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Duplicates a product.
		/// </summary>
		/// <param name="newTitle">The new title of the product.</param>
		/// <param name="productId">The ID of the product to be duplicated.</param>
		/// <param name="includeImages">Specifies whether or not to duplicate images.</param>
		/// <param name="newStatus">The new status of the product. If no value is provided the status will be inherited from the original product.</param>
		/// <returns></returns>
		[GraphName("productDuplicate")]
		public GraphSet<DuplicateProductMutationResult> DuplicateProduct([GraphNonNullableParameter] string newTitle,
			[GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string productId,
			bool includeImages = false,
			ProductStatus? newStatus = null)
		{
			return Set<DuplicateProductMutationResult>(new object[]
			{
				newTitle,
				productId,
				includeImages,
				newStatus
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Updates a product. If you update a product, and only include some variants in the update, then any variants not included will be deleted. To safely manage variants without the risk of deleting excluded variants, use productVariantsBulkUpdate. If you want to update a single variant, then use productVariantUpdate.
		/// </summary>
		/// <param name="productInput">The updated properties for a product.</param>
		/// <returns></returns>
		[GraphName("productUpdate")]
		public GraphSet<UpdateProductMutationResult> UpdateProduct([GraphNonNullableParameter] ProductInput input)
		{
			return Set<UpdateProductMutationResult>(new object[]
			{
				input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Changes the status of a product. This allows you to set the availability of the product across all channels.
		/// </summary>
		/// <param name="productId">The ID of the product.</param>
		/// <param name="status">The status to be assigned to the product.</param>
		/// <returns></returns>
		[GraphName("productChangeStatus")]
		public GraphSet<ChangeProductStatusMutationResult> ChangeProductStatus([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] int productId,
			[GraphNonNullableParameter] ProductStatus status)
		{
			return Set<ChangeProductStatusMutationResult>(new object[]
			{
				productId, status
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Appends images to a product.
		/// </summary>
		/// <param name="input">Specifies the new images and the product that they're being added to.</param>
		/// <returns></returns>
		[GraphName("productAppendImages")]
		public GraphSet<AppendProductImagesMutationResult> AppendProductImages([GraphNonNullableParameter] ProductAppendImagesInput input)
		{
			return Set<AppendProductImagesMutationResult>(new object[]
			{
				input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Removes product images from the product.
		/// </summary>
		/// <param name="id">This is the ID of the product.</param>
		/// <param name="imageIds">This is the array of image IDs to delete from the product.</param>
		/// <returns></returns>
		[GraphName("productDeleteImages")]
		public GraphSet<DeleteProductImagesMutationResult> DeleteProductImages([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id,
			[GraphNonNullableParameter] [GraphParameterTypeName("[ID!]")] List<string> imageIds)
		{
			return Set<DeleteProductImagesMutationResult>(new object[]
			{
				id,
				imageIds
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Updates an image of a product.
		/// </summary>
		/// <param name="image">Image to be updated.</param>
		/// <param name="productId">The ID of the product on which to update the image.</param>
		/// <returns></returns>
		[GraphName("productImageUpdate")]
		public GraphSet<UpdateProductImageMutationResult> UpdateProductImage([GraphNonNullableParameter] ImageInput image,
			[GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string productId)
		{
			return Set<UpdateProductImageMutationResult>(new object[]
			{
				image,
				productId
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Asynchronously reorders a set of images for a given product.
		/// </summary>
		/// <param name="id">The ID of the product on which to reorder images.</param>
		/// <param name="moves">A list of moves to perform which will be evaluated in order.</param>
		/// <returns></returns>
		[GraphName("productReorderImages")]
		public GraphSet<ReorderProductImagesMutationResult> ReorderProductImages([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id,
			[GraphNonNullableParameter] [GraphParameterTypeName("[MoveInput!]")] List<MoveInput> moves)
		{
			return Set<ReorderProductImagesMutationResult>(new object[]
			{
				id,
				moves
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Creates media for a product.
		/// </summary>
		/// <param name="media"></param>
		/// <param name="productId"></param>
		/// <returns></returns>
		[GraphName("productCreateMedia")]
		public GraphSet<CreateProductMediaMutationResult> CreateProductMedia([GraphNonNullableParameter] [GraphParameterTypeName("[CreateMediaInput!]")] List<CreateMediaInput> media,
			[GraphParameterType(typeof(ID))] string productId)
		{
			return Set<CreateProductMediaMutationResult>(new object[]
			{
				media,
				productId
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Deletes media for a product.
		/// </summary>
		/// <param name="mediaIds">The media IDs to be deleted.</param>
		/// <param name="productId">The ID of the product on which to delete media.</param>
		/// <returns></returns>
		[GraphName("productDeleteMedia")]
		public GraphSet<DeleteProductMediaMutationResult> DeleteProductMedia([GraphNonNullableParameter] [GraphParameterTypeName("[ID!]")] List<string> mediaIds,
			[GraphNonNullableParameter] [GraphParameterType(typeof(ID))]
			string productId)
		{
			return Set<DeleteProductMediaMutationResult>(new object[]
			{
				mediaIds,
				productId
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Updates media for a product.
		/// </summary>
		/// <param name="media">A list of media updates.</param>
		/// <param name="productId">Specifies the product to update media on.</param>
		/// <returns></returns>
		[GraphName("productUpdateMedia")]
		public GraphSet<UpdateProductImageMutationResult> UpdateProductMedia([GraphNonNullableParameter] [GraphParameterTypeName("[UpdateMediaInput!]")] List<UpdateMediaInput> media,
			[GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string productId)
		{
			return Set<UpdateProductImageMutationResult>(new object[]
			{
				media,
				productId
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Asynchronously reorders a set of images for a given product.
		/// </summary>
		/// <param name="id">The ID of the product on which to reorder images.</param>
		/// <param name="moves">A list of moves to perform which will be evaluated in order.</param>
		/// <returns></returns>
		[GraphName("productReorderMedia")]
		public GraphSet<ReorderProductImagesMutationResult> ReorderProductMedias([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id,
			[GraphNonNullableParameter] [GraphParameterTypeName("[MoveInput!]")] List<MoveInput> moves)
		{
			return Set<ReorderProductImagesMutationResult>(new object[]
			{
				id,
				moves
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		protected override void Configure(GraphContextConfigureOptionsBuilder graphContextConfigureOptionsBuilder)
		{
			var myShopifyUri = BuildShopUri((string) ContextArguments.First(e => e.Key == "MyShopifyName").Value);
			
			var authenticationHeaderName = "X-Shopify-Access-Token";
			var authenticationHeaderValue = (string) ContextArguments.First(e => e.Key == "Authorization").Value;

			Action<GraphSetConfigurationBuilder> graphSetConfigurationBuilder = builder =>
			{
				builder.WithUrl(myShopifyUri);

				builder.ConfigureHttp(httpBuilder =>
				{
					httpBuilder.AddHeader(authenticationHeaderName, authenticationHeaderValue);

					httpBuilder.WithMethod(HttpMethod.Post);
				});
			};
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ProductConnection>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<Product>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ProductVariantConnection>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ProductVariant>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<CreateProductMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<DeleteProductMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<DuplicateProductMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UpdateProductMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ChangeProductStatusMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<AppendProductImagesMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<DeleteProductImagesMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UpdateProductImageMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ReorderProductImagesMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<CreateProductMediaMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<DeleteProductMediaMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UpdateProductImageMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ReorderProductImagesMutationResult>(graphSetConfigurationBuilder);
		}
	}
}