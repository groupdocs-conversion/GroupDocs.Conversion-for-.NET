using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert password-protected document to HTML and specifying pages to be converted
    /// </summary>
    internal static class ConvertToHtmlWithAdvancedOptions
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.html");

            Contracts.Func<LoadOptions> getLoadOptions = () => new WordProcessingLoadOptions
            {
                Password = "12345"
            };
            
            using (Converter converter = new Converter(Constants.SAMPLE_DOCX_WITH_PASSWORD, getLoadOptions))
            {
                MarkupConvertOptions options = new MarkupConvertOptions
                {
                    PageNumber = 2,
                    FixedLayout = true,
                    PagesCount = 1
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nPassword protected document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
