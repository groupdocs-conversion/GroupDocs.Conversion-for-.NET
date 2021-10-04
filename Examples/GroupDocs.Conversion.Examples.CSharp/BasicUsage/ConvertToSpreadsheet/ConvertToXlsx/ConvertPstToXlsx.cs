using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert PST file into XLSX format.
    /// For more details about Personal Storage File (.pst) to Microsoft Excel Open XML Spreadsheet (.xlsx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-pst-to-xlsx
    /// </summary>
    internal static class ConvertPstToXlsx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "pst-converted-{0}-to.xlsx");
            
            // Load the source PST file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_PST, fileType => fileType == PersonalStorageFileType.Pst 
                                                                                                            ? new PersonalStorageLoadOptions()
                                                                                                            : null ))
            {
                var options = new SpreadsheetConvertOptions();
                var counter = 1;
                // Save converted XLSX file
                converter.Convert(
                    (FileType fileType) => new FileStream(string.Format(outputFile, counter++), FileMode.Create),
                    options
                );
            }

            Console.WriteLine("\nConversion to xlsx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
