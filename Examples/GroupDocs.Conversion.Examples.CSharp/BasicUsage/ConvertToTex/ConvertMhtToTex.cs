using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MHT file into TEX format.
    /// For more details about MIME Encapsulation of Aggregate HTML (.mht) to LaTeX Source Document (.tex) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-mht-to-tex
    /// </summary>
    internal static class ConvertMhtToTex
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "mht-converted-to.tex");
            
            // Load the source MHT file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MHT))
            {
                PageDescriptionLanguageConvertOptions options = new PageDescriptionLanguageConvertOptions { Format = GroupDocs.Conversion.FileTypes.PageDescriptionLanguageFileType.Tex };
                // Save converted TEX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to tex completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
