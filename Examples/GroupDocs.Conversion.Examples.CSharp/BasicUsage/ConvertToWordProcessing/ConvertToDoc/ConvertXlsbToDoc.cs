using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert XLSB file into DOC format.
    /// For more details about Microsoft Excel Binary Spreadsheet File (.xlsb) to Microsoft Word Document (.doc) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-xlsb-to-doc
    /// </summary>
    internal static class ConvertXlsbToDoc
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "xlsb-converted-to.doc");
            
            // Load the source XLSB file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_XLSB))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions { Format = GroupDocs.Conversion.FileTypes.WordProcessingFileType.Doc };
                // Save converted DOC file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to doc completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}