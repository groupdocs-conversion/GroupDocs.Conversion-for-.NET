using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert from a rar to pdf and compress to zip
    /// </summary>
    internal static class ConvertFromRarToPdfAndCompress
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            
            FluentConverter.Load(Constants.SAMPLE_RAR)
                .ConvertTo(p => new MemoryStream()).WithOptions(new PdfConvertOptions())
                .Compress(new CompressionConvertOptions { Format = CompressionFileType.Zip }).OnCompressionCompleted(
                    compressedStream =>
                    {
                        using (var fs = new FileStream(Path.Combine(outputFolder, "converted.zip"), FileMode.Create))
                        {
                            compressedStream.CopyTo(fs);
                        }
                    })
                .Convert();

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
