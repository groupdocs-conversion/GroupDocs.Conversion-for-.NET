using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a pdf document to wordprocessing with advanced options
    /// </summary>
    internal static class ConvertPdfAndRemoveEmbeddedFiles
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.docx");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new PdfLoadOptions
            {
                RemoveEmbeddedFiles = true
            };
#else                   
            Contracts.Func<LoadOptions> getLoadOptions = () => new PdfLoadOptions
            {
                RemoveEmbeddedFiles = true
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_PDF, getLoadOptions))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nPdf document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
