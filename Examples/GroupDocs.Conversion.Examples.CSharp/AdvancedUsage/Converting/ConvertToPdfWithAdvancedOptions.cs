using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert password-protected document to PDF and specifying pages to be converted
    /// </summary>
    internal static class ConvertToPdfWithAdvancedOptions
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<LoadContext, LoadOptions> getLoadOptions = loadContext => new WordProcessingLoadOptions
            {
                Password = "12345"
            };

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX_WITH_PASSWORD, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions
                {
                    PageNumber = 2,
                    PagesCount = 1,
                    Rotate = Rotation.On180,
                    Dpi = 300,
                    PageWidth = 1024,
                    PageHeight = 768
                };
                converter.Convert(outputFile, options);
            }
            Console.WriteLine("\nPassword protected document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
