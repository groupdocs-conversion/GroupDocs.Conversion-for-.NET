using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert to a stream
    /// </summary>
    internal static class ConvertToStream
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
            {
                using (Converter converter = new Converter(Constants.SAMPLE_DOCX))
                {
                    var convertOptions = new PdfConvertOptions();
                    converter.Convert(() => new MemoryStream(), convertedStream =>
                    {
                        convertedStream.CopyTo(outputStream);
                    } ,convertOptions);
                }
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
