using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert PPSX file into HTML format.
    /// For more details about PowerPoint Open XML Slide Show (.ppsx) to Hyper Text Markup Language (.html) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-ppsx-to-html
    /// </summary>
    internal static class ConvertPpsxToHtml
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "ppsx-converted-to.html");
            
            // Load the source PPSX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_PPSX))
            {
                var options = new WebConvertOptions();
                // Save converted HTML file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to html completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
