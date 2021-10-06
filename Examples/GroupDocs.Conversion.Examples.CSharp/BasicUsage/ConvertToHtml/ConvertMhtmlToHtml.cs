using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MHTML file into HTML format.
    /// For more details about MIME Encapsulation of Aggregate HTML (.mhtml) to Hyper Text Markup Language (.html) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-mhtml-to-html
    /// </summary>
    internal static class ConvertMhtmlToHtml
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "mhtml-converted-to.html");
            
            // Load the source MHTML file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MHTML))
            {
                var options = new MarkupConvertOptions();
                // Save converted HTML file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to html completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
