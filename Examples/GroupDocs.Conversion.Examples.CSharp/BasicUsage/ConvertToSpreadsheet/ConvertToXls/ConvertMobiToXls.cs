using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MOBI file into XLS format.
    /// For more details about Mobipocket eBook (.mobi) to Microsoft Excel Binary File Format (.xls) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-mobi-to-xls
    /// </summary>
    internal static class ConvertMobiToXls
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "mobi-converted-to.xls");
            
            // Load the source MOBI file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MOBI))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Xls };
                // Save converted XLS file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to xls completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
