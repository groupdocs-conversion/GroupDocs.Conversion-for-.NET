using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert DOTX file into PDF format.
    /// For more details about Word Open XML Document Template (.dotx) to Portable Document (.pdf) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-dotx-to-pdf
    /// </summary>
    internal static class ConvertDotxToPdf
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "dotx-converted-to.pdf");
            
            // Load the source DOTX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_DOTX))
            {
                var options = new PdfConvertOptions();
                // Save converted PDF file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to pdf completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
