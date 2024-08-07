using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert POT file into HTML format.
    /// For more details about PowerPoint Template (.pot) to Hyper Text Markup Language (.html) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-pot-to-html
    /// </summary>
    internal static class ConvertPotToHtml
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "pot-converted-to.html");
            
            // Load the source POT file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_POT))
            {
                var options = new WebConvertOptions();
                // Save converted HTML file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to html completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
