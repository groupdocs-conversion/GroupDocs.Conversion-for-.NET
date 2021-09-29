using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert TSV file into DOC format.
    /// For more details about Tab Separated Values File (.tsv) to Microsoft Word Document (.doc) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-tsv-to-doc
    /// </summary>
    internal static class ConvertTsvToDoc
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "tsv-converted-to.doc");
            
            // Load the source TSV file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_TSV))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions();
                // Save converted DOC file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to doc completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
