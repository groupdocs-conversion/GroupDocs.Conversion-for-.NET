using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert document from stream.
    /// </summary>
    class LoadDocumentFromStream
    {
        public static void Run()
        {
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputDirectory, "converted.pdf");
                        
            using (Converter converter = new Converter(GetFileStream)) 
            {
                PdfConvertOptions options = new PdfConvertOptions();

                converter.Convert(outputFile, options);
            }

            Console.WriteLine($"\nSource document converted successfully.\nCheck output in {outputDirectory}.");
        }

        private static Stream GetFileStream() => 
            File.OpenRead(Constants.SAMPLE_DOCX);
    }
}
