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

            Func<LoadContext, LoadOptions> getLoadOptions = loadContext => new WordProcessingLoadOptions
            {
                Password = "12345"
            };

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX_WITH_PASSWORD, getLoadOptions))
            {
                WebConvertOptions options = new WebConvertOptions
                {
                    PageNumber = 2,
                    FixedLayout = true,
                    PagesCount = 1,
                    FixedLayoutShowBorders = false
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nPassword protected document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
