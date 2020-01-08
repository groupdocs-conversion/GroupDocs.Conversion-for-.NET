#if !NETCOREAPP           

using System;
using System.IO;
using Amazon.S3;
using Amazon.S3.Model;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to download document from Amazon S3 storage and convert document.
    /// </summary>
    class LoadDocumentFromAmazonS3
    {
        public static void Run()
        {
            string key = "sample.docx";
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputDirectory, "converted.pdf");

            using (Converter converter = new Converter(() => DownloadFile(key)))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine($"\nSource document converted successfully.\nCheck output in {outputDirectory}.");
        }
                
        public static Stream DownloadFile(string key)
        {
            AmazonS3Client client = new AmazonS3Client();
            string bucketName = "my-bucket";

            GetObjectRequest request = new GetObjectRequest
            {
                Key = key,
                BucketName = bucketName
            };
            using (GetObjectResponse response = client.GetObject(request))
            {
                MemoryStream stream = new MemoryStream();
                response.ResponseStream.CopyTo(stream);
                stream.Position = 0;
                return stream;
            }
        }
    }
}
#endif