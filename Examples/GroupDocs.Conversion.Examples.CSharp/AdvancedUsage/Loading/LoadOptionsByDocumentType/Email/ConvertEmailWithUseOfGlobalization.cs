using System;
using System.Globalization;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert an email document with use of globalization
    /// </summary>
    internal static class ConvertEmailWithUseOfGlobalization
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            CultureInfo.CurrentCulture = new CultureInfo("fr-FR");

            using (Converter converter = new Converter(Constants.SAMPLE_EML))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nEmail document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
