using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert XLAM file into PDF format.
    /// For more details about Microsoft Excel Macro-Enabled Add-In (.xlam) to Portable Document (.pdf) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-xlam-to-pdf
    /// </summary>
    internal static class ConvertXlamToPdf
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "xlam-converted-to.pdf");
            
            // Load the source XLAM file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_XLAM))
            {
                var options = new PdfConvertOptions();
                // Save converted PDF file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to pdf completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
