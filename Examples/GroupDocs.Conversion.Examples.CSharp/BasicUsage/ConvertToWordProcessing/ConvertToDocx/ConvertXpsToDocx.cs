using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert XPS file into DOCX format.
    /// For more details about Open XML Paper Specification (.xps) to Microsoft Word Open XML Document (.docx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-xps-to-docx
    /// </summary>
    internal static class ConvertXpsToDocx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "xps-converted-to.docx");
            
            // Load the source XPS file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_XPS))
            {
                var options = new WordProcessingConvertOptions();
                // Save converted DOCX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to docx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
