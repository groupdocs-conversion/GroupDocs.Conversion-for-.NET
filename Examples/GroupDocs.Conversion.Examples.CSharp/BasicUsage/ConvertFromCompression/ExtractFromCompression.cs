using System;
using System.IO;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to extract from a Rar.
    /// </summary>
    internal static class ExtractFromCompression
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            
            using (Converter converter = new Converter(Constants.SAMPLE_ZIP_WITH_FOLDERS))
            {
                converter.Convert(() => new MemoryStream(), (Stream convertedStream, string sourceFileName) =>
                {
                    string fileName = Path.Combine(outputFolder, sourceFileName);
                    Directory.CreateDirectory(Path.GetDirectoryName(fileName)!);
                    using (var fs = new FileStream(fileName, FileMode.Create))
                    {
                        convertedStream.CopyTo(fs);
                    }
                }, (_, _) => null);
            }

            Console.WriteLine("\nExtract from compression completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
