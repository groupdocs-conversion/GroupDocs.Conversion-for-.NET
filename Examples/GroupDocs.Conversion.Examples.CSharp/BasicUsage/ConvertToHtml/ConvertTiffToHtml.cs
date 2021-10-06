using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert TIFF file into HTML format.
    /// For more details about Tagged Image File Format (.tiff) to Hyper Text Markup Language (.html) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-tiff-to-html
    /// </summary>
    internal static class ConvertTiffToHtml
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "tiff-converted-to.html");
            
            // Load the source TIFF file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_TIFF))
            {
                var options = new MarkupConvertOptions();
                // Save converted HTML file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to html completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
