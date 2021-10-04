using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MBOX file into DOC format.
    /// For more details about Email Mailbox File (.mbox) to Microsoft Word Document (.doc) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-mbox-to-doc
    /// </summary>
    internal static class ConvertMboxToDoc
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "mbox-converted-{0}-to.doc");
            
            // Load the source MBOX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MBOX, fileType => fileType == EmailFileType.Mbox 
                                                                                                            ? new MboxLoadOptions()
                                                                                                            : null))
            {
                var options = new WordProcessingConvertOptions
                {
                    Format = GroupDocs.Conversion.FileTypes.WordProcessingFileType.Doc
                };
                var counter = 1;
                // Save converted DOC file
                converter.Convert(
                    (FileType fileType) => new FileStream(string.Format(outputFile, counter++), FileMode.Create),
                    options
                );
            }

            Console.WriteLine("\nConversion to doc completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
