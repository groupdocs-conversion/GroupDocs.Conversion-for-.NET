using System;
using System.Dynamic;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to load and convert password-protected document.
    /// </summary>
    internal static class LoadPasswordProtectedDocumentFluent
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            FluentConverter.Load(Constants.SAMPLE_DOCX_WITH_PASSWORD).WithOptions((LoadContext loadContext) => new WordProcessingLoadOptions
                {
                    Password = "12345"
                })
                .ConvertTo(outputFile).WithOptions(new PdfConvertOptions())
                .Convert();




            Console.WriteLine("\nPassword protected document converted successfully. \nCheck output in {0}",
                outputFolder);
        }
    }
}
