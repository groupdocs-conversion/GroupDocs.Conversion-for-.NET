using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a xml document to spreadsheet with advanced options
    /// </summary>
    internal static class ConvertXmlAsDataSourceToSpreadsheet
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.xlsx");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new XmlLoadOptions
            {
                UseAsDataSource = true
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new XmlLoadOptions
            {
                UseAsDataSource = true
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_XML_DATASOURCE, () => new XmlLoadOptions
            {
                UseAsDataSource = true
            }))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nXml document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
