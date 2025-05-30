using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert TIFF file into XLSX format.
    /// For more details about Tagged Image File Format (.tiff) to Microsoft Excel Open XML Spreadsheet (.xlsx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-tiff-to-xlsx
    /// </summary>
    internal static class ConvertTiffToXlsx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "tiff-converted-to.xlsx");
            
            // Load the source TIFF file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_TIFF))
            {
                var options = new SpreadsheetConvertOptions();
                // Save converted XLSX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to xlsx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
