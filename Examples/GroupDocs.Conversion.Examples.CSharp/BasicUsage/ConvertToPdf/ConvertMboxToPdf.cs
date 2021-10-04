using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MBOX file into PDF format.
    /// For more details about Email Mailbox File (.mbox) to Portable Document (.pdf) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-mbox-to-pdf
    /// </summary>
    internal static class ConvertMboxToPdf
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "mbox-converted-{0}-to.pdf");
            
            // Load the source MBOX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MBOX, fileType => fileType == EmailFileType.Mbox 
                                                                                                                        ? new MboxLoadOptions() 
                                                                                                                        : null))
            {
                var options = new PdfConvertOptions();
                var counter = 1;
                // Save converted PDF file
                converter.Convert(
                    (FileType fileType) => new FileStream(string.Format(outputFile, counter++), FileMode.Create),
                    options
                );
            }

            Console.WriteLine("\nConversion to pdf completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
