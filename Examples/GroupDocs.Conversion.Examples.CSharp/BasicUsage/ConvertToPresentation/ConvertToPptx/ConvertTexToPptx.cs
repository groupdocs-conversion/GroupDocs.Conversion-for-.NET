using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert TEX file into PPTX format.
    /// For more details about LaTeX Source Document (.tex) to PowerPoint Open XML Presentation (.pptx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-tex-to-pptx
    /// </summary>
    internal static class ConvertTexToPptx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "tex-converted-to.pptx");
            
            // Load the source TEX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_TEX))
            {
                var options = new PresentationConvertOptions();
                // Save converted PPTX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to pptx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
