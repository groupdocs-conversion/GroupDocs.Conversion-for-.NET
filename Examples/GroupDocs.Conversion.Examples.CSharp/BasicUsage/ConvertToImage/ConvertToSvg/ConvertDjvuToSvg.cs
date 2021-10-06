using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert DJVU file into SVG format.
    /// For more details about Graphics File format (.djvu) to Scalable Vector Graphics File (.svg) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-djvu-to-svg
    /// </summary>
    internal static class ConvertDjvuToSvg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "djvu-converted-to.svg");
            
            // Load the source DJVU file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_DJVU))
            {
                ImageConvertOptions options = new ImageConvertOptions { Format = GroupDocs.Conversion.FileTypes.ImageFileType.Svg };
                // Save converted SVG file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to svg completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}