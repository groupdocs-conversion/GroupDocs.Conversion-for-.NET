using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert csv to data format (xml)
    /// </summary>
    internal static class ConvertCsvToXml
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.xml");

            using (Converter converter = new Converter(Constants.SAMPLE_CSV))
            {
                DataConvertOptions options = new DataConvertOptions
                {
                    Format = DataFileType.Xml
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}