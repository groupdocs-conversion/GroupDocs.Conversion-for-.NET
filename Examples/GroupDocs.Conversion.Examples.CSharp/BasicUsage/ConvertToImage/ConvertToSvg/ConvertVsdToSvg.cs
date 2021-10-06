using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert VSD file into SVG format.
    /// For more details about Visio Drawing File Format (.vsd) to Scalable Vector Graphics File (.svg) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-vsd-to-svg
    /// </summary>
    internal static class ConvertVsdToSvg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "vsd-converted-to.svg");
            
            // Load the source VSD file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_VSD))
            {
                ImageConvertOptions options = new ImageConvertOptions { Format = GroupDocs.Conversion.FileTypes.ImageFileType.Svg };
                // Save converted SVG file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to svg completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}