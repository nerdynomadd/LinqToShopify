﻿namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Enum
{
	/// <summary>
	/// Error types for media.
	/// </summary>
	public enum MediaErrorCode
	{
		EXTERNAL_VIDEO_EMBED_DISABLED,
		EXTERNAL_VIDEO_EMBED_NOT_FOUND_OR_TRANSCODING,
		EXTERNAL_VIDEO_INVALID_ASPECT_RATIO,
		EXTERNAL_VIDEO_NOT_FOUND,
		EXTERNAL_VIDEO_UNLISTED,
		FILE_STORAGE_LIMIT_EXCEEDED,
		GENERIC_FILE_DOWNLOAD_FAILURE,
		GENERIC_FILE_INVALID_SIZE,
		IMAGE_DOWNLOAD_FAILURE,
		IMAGE_PROCESSING_FAILURE,
		INVALID_IMAGE_ASPECT_RATIO,
		INVALID_IMAGE_FILE_SIZE,
		INVALID_IMAGE_RESOLUTION,
		INVALID_SIGNED_URL,
		MEDIA_TIMEOUT_ERROR,
		MODEL3D_GLB_OUTPUT_CREATION_ERROR,
		MODEL3D_GLB_TO_USDZ_CONVERSION_ERROR,
		MODEL3D_THUMBNAIL_GENERATION_ERROR,
		MODEL3D_VALIDATION_ERROR,
		UNKNOWN,
		UNSUPPORTED_IMAGE_FILE_TYPE,
		VIDEO_INVALID_FILETYPE_ERROR,
		VIDEO_MAX_DURATION_ERROR,
		VIDEO_MAX_HEIGHT_ERROR,
		VIDEO_MAX_WIDTH_ERROR,
		VIDEO_METADATA_READ_ERROR,
		VIDEO_MIN_DURATION_ERROR,
		VIDEO_MIN_HEIGHT_ERROR,
		VIDEO_MIN_WIDTH_ERROR,
		VIDEO_VALIDATION_ERROR
	}
}