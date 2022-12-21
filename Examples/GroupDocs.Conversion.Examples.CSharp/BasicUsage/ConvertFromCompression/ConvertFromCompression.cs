using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to extract and convert from a Rar.
    /// </summary>
    internal static class ConvertFromCompression
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            
            using (Converter converter = new Converter(Constants.SAMPLE_RAR))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                int i = 0;
                converter.Convert(() => new FileStream(Path.Combine(outputFolder, $"converted-{++i}.pdf"), FileMode.Create), options);
            }

            Console.WriteLine("\nConversion from compression completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
