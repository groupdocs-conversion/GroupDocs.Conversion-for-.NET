using System.IO;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using GroupDocs.Conversion.Domain;
using GroupDocs.Conversion.Handler.Input;

namespace GroupDocs.Conversion.Examples.CSharp
{
    class CustomInputDataHandler : IInputDataHandler
    {
        private static string bucketName = ""; //TODO: Put you bucketname here 
        private readonly AmazonS3Client _client;
        public CustomInputDataHandler()
        {
            _client = new AmazonS3Client(RegionEndpoint.EUWest1);
        }
        public FileDescription GetFileDescription(string guid)
        {
            FileDescription result = new FileDescription();
            var request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = guid
            };
            string fileName;
            long size;
            using (var response = _client.GetObject(request))
            {
                fileName = response.Key;
                size = response.ContentLength;
            }

            result.Guid = guid;
            result.Name = fileName;
            result.Size = size;
            return result;
        }
        public Stream GetFile(string guid)
        {
            var request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = guid
            };
            var result = new MemoryStream();
            using (var response = _client.GetObject(request))
            {
                byte[] buffer = new byte[16384]; //16*1024
                int read;
                while ((read = response.ResponseStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    result.Write(buffer, 0, read);
                }
            }
            return result;
        }
    }
}
