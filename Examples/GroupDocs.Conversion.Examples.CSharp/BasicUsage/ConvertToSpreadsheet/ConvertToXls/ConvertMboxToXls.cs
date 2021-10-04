using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MBOX file into XLS format.
    /// For more details about Email Mailbox File (.mbox) to Microsoft Excel Binary File Format (.xls) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-mbox-to-xls
    /// </summary>
    internal static class ConvertMboxToXls
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "mbox-converted-{0}-to.xls");
            
            // Load the source MBOX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MBOX, fileType => fileType == EmailFileType.Mbox
                                                                                                                ? new MboxLoadOptions()
                                                                                                                : null))
	        {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Xls };
		        var counter = 1;
                // Save converted XLS file
                converter.Convert(
		            (FileType fileType) => new FileStream(string.Format(outputFile, counter++), FileMode.Create),
                    options
                );            
	        }

            Console.WriteLine("\nConversion to xls completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
