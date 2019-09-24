using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert document from local disk.
    /// </summary>
    class LoadDocumentFromLocalDisk
    {
        public static void Run()
        {
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputDirectory, "converted.pdf");
            string filePath = Constants.SAMPLE_DOCX;

            using (Converter converter = new Converter(filePath)) 
            {
                PdfConvertOptions options = new PdfConvertOptions();

                converter.Convert(outputFile, options);
            }

            Console.WriteLine($"\nSource document converted successfully.\nCheck output in {outputDirectory}.");
        }
    }
}
