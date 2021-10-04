using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert CSV file into CSV format.
    /// For more details about Comma Separated Values File (.csv) to Comma Separated Values File (.csv) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-csv-to-csv
    /// </summary>
    internal static class ConvertCsvToCsv
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "csv-converted-to.csv");
            
            // Load the source CSV file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_CSV))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Csv };
                // Save converted CSV file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to csv completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
