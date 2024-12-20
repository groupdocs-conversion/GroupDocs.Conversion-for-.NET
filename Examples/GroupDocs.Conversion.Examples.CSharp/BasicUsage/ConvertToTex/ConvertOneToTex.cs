using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert ONE file into TEX format.
    /// For more details about Microsoft OneNote File Format (.one) to LaTeX Source Document (.tex) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-one-to-tex
    /// </summary>
    internal static class ConvertOneToTex
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "one-converted-to.tex");
            
            // Load the source ONE file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_ONE))
            {
                PageDescriptionLanguageConvertOptions options = new PageDescriptionLanguageConvertOptions { Format = GroupDocs.Conversion.FileTypes.PageDescriptionLanguageFileType.Tex };
                // Save converted TEX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to tex completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
