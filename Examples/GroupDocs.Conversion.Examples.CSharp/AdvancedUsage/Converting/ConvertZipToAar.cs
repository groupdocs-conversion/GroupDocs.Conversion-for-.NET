using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a ZIP archive to Apple Archive (AAR)
    /// </summary>
    internal static class ConvertZipToAar
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.aar");

            using (Converter converter = new Converter(Constants.SAMPLE_ZIP))
            {
                CompressionConvertOptions options = new CompressionConvertOptions
                {
                    Format = CompressionFileType.Aar
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nZIP archive converted to Apple Archive successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
