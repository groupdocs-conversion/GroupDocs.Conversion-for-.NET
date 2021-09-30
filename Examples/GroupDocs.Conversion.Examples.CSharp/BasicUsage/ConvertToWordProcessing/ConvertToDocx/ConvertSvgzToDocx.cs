using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert SVGZ file into DOCX format.
    /// For more details about Compressed Scalable Vector Graphics File (.svgz) to Microsoft Word Open XML Document (.docx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-svgz-to-docx
    /// </summary>
    internal static class ConvertSvgzToDocx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "svgz-converted-to.docx");
            
            // Load the source SVGZ file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_SVGZ))
            {
                var options = new WordProcessingConvertOptions();
                // Save converted DOCX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to docx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
