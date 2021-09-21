using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert OXPS image to PDF.
    /// </summary>
    internal static class ConvertOxpsToPdf
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "oxps-converted-to.pdf");
            
            // Load the source OXPS file
            using (Converter converter = new Converter(Constants.SAMPLE_OXPS))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                // Save converted PDF file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to pdf completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
