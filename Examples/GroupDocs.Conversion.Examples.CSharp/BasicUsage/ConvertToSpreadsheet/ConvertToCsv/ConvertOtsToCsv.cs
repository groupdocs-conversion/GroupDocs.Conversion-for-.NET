using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert OTS file into CSV format.
    /// For more details about OpenDocument Spreadsheet Template (.ots) to Comma Separated Values File (.csv) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-ots-to-csv
    /// </summary>
    internal static class ConvertOtsToCsv
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "ots-converted-to.csv");
            
            // Load the source OTS file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_OTS))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Csv };
                // Save converted CSV file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to csv completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
