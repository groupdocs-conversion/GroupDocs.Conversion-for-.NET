using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert XLSX file into PNG format.
    /// For more details about Microsoft Excel Open XML Spreadsheet (.xlsx) to Portable Network Graphic (.png) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-xlsx-to-png
    /// </summary>
    internal static class ConvertXlsxToPng
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.png");
            Func<SavePageContext, Stream> getPageStream = savePageContext => new FileStream(string.Format(outputFileTemplate, savePageContext.Page), FileMode.Create);

            // Load the source XLSX file
            using (Converter converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_XLSX))
            {
                // Set the convert options for PNG format
                ImageConvertOptions options = new ImageConvertOptions { Format = GroupDocs.Conversion.FileTypes.ImageFileType.Png };  
                // Convert to PNG format
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nConversion to png completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}