using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MSG file into XLS format.
    /// For more details about Microsoft Outlook Email Format (.msg) to Microsoft Excel Binary File Format (.xls) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-msg-to-xls
    /// </summary>
    internal static class ConvertMsgToXls
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "msg-converted-to.xls");
            
            // Load the source MSG file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MSG))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Xls };
                // Save converted XLS file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to xls completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
