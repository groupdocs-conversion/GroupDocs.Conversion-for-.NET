//ExStart:CustomCacheDataHandlerClass
using System;
using System.IO;
using Amazon;
using Amazon.S3;
using Amazon.S3.IO;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Domain;
using GroupDocs.Conversion.Handler.Cache;

namespace GroupDocs.Conversion.Examples.CSharp
{
    class CustomCacheDataHandler : ICacheDataHandler
    {
        private static string bucketName = ""; //TODO: Put you bucketname here 
        private readonly ConversionConfig _conversionConfig;
        private readonly AmazonS3Client _client;
        public CustomCacheDataHandler(ConversionConfig conversionConfig)
        {
            _conversionConfig = conversionConfig;
            _client = new AmazonS3Client(RegionEndpoint.EUWest1);
        }

        public bool Exists(CacheFileDescription cacheFileDescription)
        {
            if (!_conversionConfig.UseCache)
            {
                return false;
            }
            if (cacheFileDescription == null)
            {
                throw new System.Exception("CacheFileDescription is not set");
            }
            if (cacheFileDescription.LastModified == 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(cacheFileDescription.Guid))
            {
                throw new System.Exception("CacheFileDescription is not set");
            }
            if (string.IsNullOrEmpty(_conversionConfig.StoragePath))
            {
                throw new System.Exception("Storage path is not set");
            }
            var key = GetCachePath(_conversionConfig.CachePath, cacheFileDescription);
            S3FileInfo fileInfo = new S3FileInfo(_client, bucketName, key);
            if (!fileInfo.Exists)
            {
                return false;
            }
            return (fileInfo.LastWriteTimeUtc >= DateTime.UtcNow.AddMinutes(-5));
        }
        public Stream GetInputStream(CacheFileDescription cacheFileDescription)
        {
            if (cacheFileDescription == null || String.IsNullOrEmpty(cacheFileDescription.Guid) ||
                cacheFileDescription.LastModified == 0)
            {
                throw new System.Exception("CacheFileDescription is not set");
            }
            var key = GetCachePath(_conversionConfig.CachePath, cacheFileDescription);
            var fileInfo = new S3FileInfo(_client, bucketName, key);
            if (!fileInfo.Exists)
            {
                throw new System.Exception("File not found");
            }
            return fileInfo.OpenRead();
        }
        public Stream GetOutputSaveStream(CacheFileDescription cacheFileDescription)
        {
            try
            {
                if (!_conversionConfig.UseCache)
                {
                    return new MemoryStream();
                }
                if (cacheFileDescription == null || String.IsNullOrEmpty(cacheFileDescription.Guid))
                {
                    throw new System.Exception("CacheFileDescription is not set");
                }
                string key = GetCachePath(_conversionConfig.CachePath, cacheFileDescription);
                S3FileInfo fileInfo = new S3FileInfo(_client, bucketName, key);
                return fileInfo.Create();
            }
            catch (System.Exception e)
            {
                throw new System.Exception(e.Message);
            }
        }
        public string GetCacheUri(CacheFileDescription cacheFileDescription)
        {
            return GetCachePath(_conversionConfig.CachePath, cacheFileDescription);
        }
        private string GetCachePath(string path, CacheFileDescription cacheFileDescription)
        {  
            if (cacheFileDescription.SaveOptions == null)
            {
                throw new System.Exception("CacheFileDescription.Options is not set");
            }
            var fileName = string.Format("{0}.{1}", cacheFileDescription.BaseName,
             cacheFileDescription.SaveOptions.ConvertFileTypeExtension);

            //var filePath = _fileSystem.Path.Combine(_conversionConfig.CachePath, cacheFileDescription.Guid, fileName);
            var filePath = Path.Combine(_conversionConfig.CachePath, cacheFileDescription.Guid, fileName);
            return filePath;
        }
    }
}
//ExEnd:CustomCacheDataHandlerClass
