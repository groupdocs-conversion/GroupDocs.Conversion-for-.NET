using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert JPC file into PPTX format.
    /// For more details about JPEG 2000 Image File (.jpc) to PowerPoint Open XML Presentation (.pptx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-jpc-to-pptx
    /// </summary>
    internal static class ConvertJpcToPptx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "jpc-converted-to.pptx");
            
            // Load the source JPC file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_JPC))
            {
                var options = new PresentationConvertOptions();
                // Save converted PPTX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to pptx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
