using System;
using System.IO;
using System.Net;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to download and convert document.
    /// </summary>
    class LoadDocumentFromUrl
    {
        public static void Run()
        {
            string url = "https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET/blob/master/Examples/GroupDocs.Conversion.Examples.CSharp/Resources/SampleFiles/sample.docx?raw=true";
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputDirectory, "converted.pdf");

            using (Converter converter = new Converter(() => GetRemoteFile(url)))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine($"\nSource document converted successfully.\nCheck output in {outputDirectory}.");
        }
                
        private static Stream GetRemoteFile(string url)
        {
            WebRequest request = WebRequest.Create(url);

            using (WebResponse response = request.GetResponse())
                return GetFileStream(response);
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
