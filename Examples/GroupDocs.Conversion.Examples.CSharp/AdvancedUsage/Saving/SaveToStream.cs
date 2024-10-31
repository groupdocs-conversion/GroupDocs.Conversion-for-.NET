using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to save the converted file to stream.
    /// </summary>
    class SaveToStream
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<SaveContext, Stream> getOutputStream = saveContext => GetFileStream(outputFile);

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                // Pass the output stream as parameter
                converter.Convert(getOutputStream, options);
            }

            Console.WriteLine($"\nSource file converted successfully.\nSaved file to stream.\nCheck output in {outputFolder}.");
        }

        // Obtain the stream for the conversion output
        public static Stream GetFileStream(string outFile)
            {
            return new FileStream(outFile, FileMode.OpenOrCreate);
        }
    }
}
