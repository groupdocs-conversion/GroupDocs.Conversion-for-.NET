using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert csv to data format (json)
    /// </summary>
    internal static class ConvertCsvToJson
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.json");

            var loadOptions = new CsvLoadOptions
            {
                Separator = ','
            };

            using (Converter converter = new Converter(Constants.SAMPLE_CSV, ()=> loadOptions))
            {
                WebConvertOptions options = new WebConvertOptions
                {
                    Format = WebFileType.Json
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
