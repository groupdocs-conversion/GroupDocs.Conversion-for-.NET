using System;
using System.IO;
using System.Text;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a csv document to pdf with advanced options
    /// </summary>
    internal static class ConvertCsvBySpecifyingEncoding
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new CsvLoadOptions
            {
                Encoding = Encoding.GetEncoding("shift_jis")
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new CsvLoadOptions
            {
                Encoding = Encoding.GetEncoding("shift_jis")
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_CSV, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nCsv document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
