using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert specific pages
    /// </summary>
    internal static class ConvertSpecificPages
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX))
            {
                PdfConvertOptions options = new PdfConvertOptions
                {
                    Pages = new List<int>{ 1, 3 }
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
