using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to get default load options for source document
    /// </summary>
    internal static class GetDefaultLoadOptionsForSourceDocument
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            var possibleConversions = Converter.GetPossibleConversions("docx");
            var loadOptions = (WordProcessingLoadOptions) possibleConversions.LoadOptions;
            loadOptions.Password = "12345";
            
            using (Converter converter = new Converter(Constants.SAMPLE_DOCX_WITH_PASSWORD, () => loadOptions))
            {
                var convertOptions = new PdfConvertOptions();
                converter.Convert(outputFile, convertOptions);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
