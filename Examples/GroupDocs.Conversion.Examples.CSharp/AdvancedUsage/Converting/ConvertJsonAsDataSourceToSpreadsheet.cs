using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a json document to spreadsheet with advanced options
    /// </summary>
    internal static class ConvertJsonAsDataSourceToSpreadsheet
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.xlsx");

            using (Converter converter = new Converter(Constants.SAMPLE_JSON))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nJson document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
