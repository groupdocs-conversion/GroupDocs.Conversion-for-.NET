using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert document to WordProcessing.
    /// </summary>
    internal static class ConvertToWordProcessing
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.docx");

            using (Converter converter = new Converter(Constants.SAMPLE_PDF))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions();
                
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to wordprocessing completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
