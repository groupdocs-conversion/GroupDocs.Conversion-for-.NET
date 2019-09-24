using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert document to Spreadsheet.
    /// </summary>
    internal static class ConvertToSpreadsheet
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.xlsx");

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions();
                
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to spreadsheet completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
