using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert DJVU file into HTML format.
    /// For more details about Graphics File format (.djvu) to Hyper Text Markup Language (.html) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-djvu-to-html
    /// </summary>
    internal static class ConvertDjvuToHtml
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "djvu-converted-to.html");
            
            // Load the source DJVU file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_DJVU))
            {
                var options = new MarkupConvertOptions();
                // Save converted HTML file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to html completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
