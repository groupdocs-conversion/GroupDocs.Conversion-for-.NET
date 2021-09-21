using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MBOX image to PDF.
    /// </summary>
    internal static class ConvertMboxToPdf
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "mbox-converted-to.pdf");
            
            // Load the source MBOX file
            using (Converter converter = new Converter(Constants.SAMPLE_MBOX))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                // Save converted PDF file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to pdf completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
