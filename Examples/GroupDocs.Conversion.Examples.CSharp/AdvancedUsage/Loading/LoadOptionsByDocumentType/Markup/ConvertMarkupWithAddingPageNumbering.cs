using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a markup document to wordprocessing document with add of page numbering
    /// </summary>
    internal static class ConvertMarkupWithAddingPageNumbering
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.docx");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new MarkupLoadOptions
            {
                PageNumbering = true
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new MarkupLoadOptions
            {
                PageNumbering = true
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_MARKUP, getLoadOptions))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nEmail document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
