using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert PPTX file into SVG format.
    /// For more details about PowerPoint Open XML Presentation (.pptx) to Scalable Vector Graphics File (.svg) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-pptx-to-svg
    /// </summary>
    internal static class ConvertPptxToSvg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "pptx-converted-to.svg");
            
            // Load the source PPTX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_PPTX))
            {
                PageDescriptionLanguageConvertOptions options = new PageDescriptionLanguageConvertOptions { Format = GroupDocs.Conversion.FileTypes.PageDescriptionLanguageFileType.Svg };
                // Save converted SVG file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to svg completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
