using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert VSDX file into TXT format.
    /// For more details about Microsoft Visio File Format (.vsdx) to Plain Text File Format (.txt) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-vsdx-to-txt
    /// </summary>
    internal static class ConvertVsdxToTxt
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "vsdx-converted-to.txt");
            
            // Load the source VSDX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_VSDX))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions { Format = GroupDocs.Conversion.FileTypes.WordProcessingFileType.Txt };
                // Save converted TXT file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to txt completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
