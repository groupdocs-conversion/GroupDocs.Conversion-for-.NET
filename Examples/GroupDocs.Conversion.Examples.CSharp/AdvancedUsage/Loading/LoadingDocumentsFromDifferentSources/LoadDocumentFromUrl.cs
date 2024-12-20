﻿using System;
using System.IO;
using System.Net.Http;
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
            var client = new HttpClient();
            
            using (HttpResponseMessage response = client.GetAsync(url).Result)
                return GetFileStream(response);
        }

        private static Stream GetFileStream(HttpResponseMessage response)
        {
            MemoryStream fileStream = new MemoryStream();

            using (HttpContent content = response.Content)
            {
                using (Stream responseStream = content.ReadAsStreamAsync().Result)
                    responseStream.CopyTo(fileStream);
            }

            fileStream.Position = 0;
            return fileStream;
        }
    }
}
