using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert OXPS file into TXT format.
    /// For more details about XML Paper Specification File (.oxps) to Plain Text File Format (.txt) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-oxps-to-txt
    /// </summary>
    internal static class ConvertOxpsToTxt
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "oxps-converted-to.txt");
            
            // Load the source OXPS file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_OXPS))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions { Format = GroupDocs.Conversion.FileTypes.WordProcessingFileType.Txt };
                // Save converted TXT file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to txt completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
