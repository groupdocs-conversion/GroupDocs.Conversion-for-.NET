using System;
using System.IO;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to get default convert options for desired target format
    /// </summary>
    internal static class GetDefaultConvertOptionsForDesiredTargetFormat
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX))
            {
                var possibleConversion = converter.GetPossibleConversions();
                var convertOptions = possibleConversion["pdf"].ConvertOptions;
                converter.Convert(outputFile, convertOptions);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
