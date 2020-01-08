using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a spreadsheet document to pdf with advanced options
    /// </summary>
    internal static class ConvertSpreadsheetWithHiddenSheetsIncluded
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new SpreadsheetLoadOptions
            {
                ShowHiddenSheets = true,
                OnePagePerSheet = true,
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new SpreadsheetLoadOptions
            {
                ShowHiddenSheets = true,
                OnePagePerSheet = true,
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_XLSX_WITH_HIDDEN_SHEET, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nSpreadsheet document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
