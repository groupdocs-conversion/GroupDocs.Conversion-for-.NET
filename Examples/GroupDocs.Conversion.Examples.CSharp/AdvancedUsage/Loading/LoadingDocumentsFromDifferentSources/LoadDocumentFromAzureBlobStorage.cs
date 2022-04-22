using System;
using System.IO;
using Azure.Storage.Blobs;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to download document from Azure Blob storage and convert document.
    /// </summary>
    class LoadDocumentFromAzureBlobStorage
    {
        public static void Run()
        {
            string blobName = "sample.docx";
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputDirectory, "converted.pdf");

            using (Converter converter = new Converter(() => DownloadFile(blobName)))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine($"\nSource document converted successfully.\nCheck output in {outputDirectory}.");
        }
                
        public static Stream DownloadFile(string blobName)
        {
            BlobContainerClient container = GetContainer();

            BlobClient blob = container.GetBlobClient(blobName);
            MemoryStream memoryStream = new MemoryStream();
            blob.DownloadTo(memoryStream);
            memoryStream.Position = 0;
            return memoryStream;
        }

        private static BlobContainerClient GetContainer()
        {
            // Get a connection string to our Azure Storage account.  You can
            // obtain your connection string from the Azure Portal (click
            // Access Keys under Settings in the Portal Storage account blade)
            // or using the Azure CLI with:
            //
            //     az storage account show-connection-string --name <account_name> --resource-group <resource_group>
            //
            // And you can provide the connection string to your application
            // using an environment variable.
            string connectionString = "<connection_string>";
            string containerName = "***";

            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);
            container.CreateIfNotExists();

            return container;
        }
    }
}
