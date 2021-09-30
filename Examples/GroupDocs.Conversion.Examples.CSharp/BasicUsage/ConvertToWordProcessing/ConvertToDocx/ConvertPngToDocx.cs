using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert PNG file into DOCX format.
    /// For more details about Portable Network Graphic (.png) to Microsoft Word Open XML Document (.docx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-png-to-docx
    /// </summary>
    internal static class ConvertPngToDocx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "png-converted-to.docx");
            
            // Load the source PNG file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_PNG))
            {
                var options = new WordProcessingConvertOptions();
                // Save converted DOCX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to docx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
