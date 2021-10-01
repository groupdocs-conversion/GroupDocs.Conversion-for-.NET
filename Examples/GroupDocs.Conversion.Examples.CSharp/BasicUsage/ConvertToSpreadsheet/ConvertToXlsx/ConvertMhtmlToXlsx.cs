using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MHTML file into XLSX format.
    /// For more details about MIME Encapsulation of Aggregate HTML (.mhtml) to Microsoft Excel Open XML Spreadsheet (.xlsx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-mhtml-to-xlsx
    /// </summary>
    internal static class ConvertMhtmlToXlsx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "mhtml-converted-to.xlsx");
            
            // Load the source MHTML file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MHTML))
            {
                var options = new SpreadsheetConvertOptions();
                // Save converted XLSX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to xlsx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
