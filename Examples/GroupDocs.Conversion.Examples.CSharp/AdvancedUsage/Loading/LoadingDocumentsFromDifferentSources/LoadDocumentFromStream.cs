using System;
using System.IO;
using System.Text;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert file from stream.
    /// </summary>
    class LoadDocumentFromStream
    {
        public static void Run()
        {
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputDirectory, "converted.pdf");

            Func<Stream> inputStream = GetFileStream;
            //Func<Stream> inputStream = GetMemoryStream;

            using (Converter converter = new Converter(inputStream))
            {
                PdfConvertOptions options = new PdfConvertOptions();

                converter.Convert(outputFile, options);
            }

            Console.WriteLine($"\nSource file converted successfully.\nCheck output in {outputDirectory}.");
        }

        private static Stream GetFileStream() => 
            File.OpenRead(Constants.SAMPLE_DOCX);
        private static Stream GetMemoryStream()
        {
            MemoryStream memStream = new MemoryStream();

            using (FileStream fStream = File.Open(Constants.SAMPLE_TXT, FileMode.Open))
            {
                Console.WriteLine("Source stream length: {0}", fStream.Length.ToString());
                fStream.CopyTo(memStream);
            }
            return memStream;
        }
    }
}
