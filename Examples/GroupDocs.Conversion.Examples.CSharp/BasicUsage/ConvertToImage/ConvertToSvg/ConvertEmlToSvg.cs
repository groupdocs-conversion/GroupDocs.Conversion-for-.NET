using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert EML file into SVG format.
    /// For more details about E-Mail Message File (.eml) to Scalable Vector Graphics File (.svg) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-eml-to-svg
    /// </summary>
    internal static class ConvertEmlToSvg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "eml-converted-to.svg");
            
            // Load the source EML file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_EML))
            {
                PageDescriptionLanguageConvertOptions options = new PageDescriptionLanguageConvertOptions { Format = GroupDocs.Conversion.FileTypes.PageDescriptionLanguageFileType.Svg };
                // Save converted SVG file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to svg completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
