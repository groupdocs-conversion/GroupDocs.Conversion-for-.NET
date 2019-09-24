using System;
using System.IO;
using System.Net;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert document downloaded from FTP.
    /// </summary>
    class LoadDocumentFromFtp
    {
        public static void Run()
        {
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputDirectory, "converted.pdf");
            string filePath = "ftp://localhost/sample.doc";

            using (Converter converter = new Converter(() => GetFileFromFtp(filePath)))
            {
                PdfConvertOptions options = new PdfConvertOptions();

                converter.Convert(outputFile, options);
            }

            Console.WriteLine($"\nSource document converted successfully.\nCheck output in {outputDirectory}.");
        }

        private static Stream GetFileFromFtp(string filePath)
        {
            Uri uri = new Uri(filePath);
            FtpWebRequest request = CreateRequest(uri);

            using (WebResponse response = request.GetResponse())
                return GetFileStream(response);
        }

        private static FtpWebRequest CreateRequest(Uri uri)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            return request;
        }

        private static Stream GetFileStream(WebResponse response)
        {
            MemoryStream fileStream = new MemoryStream();

            using (Stream responseStream = response.GetResponseStream())
                responseStream.CopyTo(fileStream);

            fileStream.Position = 0;
            return fileStream;
        }
    }
}
