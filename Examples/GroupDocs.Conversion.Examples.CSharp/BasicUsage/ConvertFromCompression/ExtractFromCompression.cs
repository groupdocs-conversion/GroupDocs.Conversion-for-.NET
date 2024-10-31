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
                converter.Convert((ConvertContext convertContext) => null,  (ConvertedContext convertedContext) =>
                {
                    string fileName = Path.Combine(outputFolder, convertedContext.SourceFileName);
                    var folderName = Path.GetDirectoryName(fileName);
                    if (!string.IsNullOrEmpty(folderName))
                    {
                        Directory.CreateDirectory(folderName);
                    }

                    using (var fs = new FileStream(fileName, FileMode.Create))
                    {
                        convertedContext.ConvertedStream.CopyTo(fs);
                    }
                });
            }

            Console.WriteLine("\nExtract from compression completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
