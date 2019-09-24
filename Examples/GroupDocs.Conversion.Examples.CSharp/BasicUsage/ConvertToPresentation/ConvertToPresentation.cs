using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert document to Presentation.
    /// </summary>
    internal static class ConvertToPresentation
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pptx");

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX))
            {
                PresentationConvertOptions options = new PresentationConvertOptions();
                
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to presentation completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
