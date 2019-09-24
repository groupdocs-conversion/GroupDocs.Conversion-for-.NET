using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a pdf document to wordprocessing document and specifying pages to be converted
    /// </summary>
    internal static class ConvertToWordProcessingWithAdvancedOptions
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.odt");

            using (Converter converter = new Converter(Constants.SAMPLE_PDF))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions
                {
                    PageNumber = 2,
                    PagesCount = 1,
                    Format = WordProcessingFileType.Odt,
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
