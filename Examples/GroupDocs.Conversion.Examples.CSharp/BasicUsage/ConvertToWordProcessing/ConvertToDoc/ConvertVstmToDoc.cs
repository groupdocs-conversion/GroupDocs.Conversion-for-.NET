using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert VSTM file into DOC format.
    /// For more details about Visio Macro-Enabled Drawing Template (.vstm) to Microsoft Word Document (.doc) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-vstm-to-doc
    /// </summary>
    internal static class ConvertVstmToDoc
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "vstm-converted-to.doc");
            
            // Load the source VSTM file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_VSTM))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions { Format = GroupDocs.Conversion.FileTypes.WordProcessingFileType.Doc };
                // Save converted DOC file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to doc completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
