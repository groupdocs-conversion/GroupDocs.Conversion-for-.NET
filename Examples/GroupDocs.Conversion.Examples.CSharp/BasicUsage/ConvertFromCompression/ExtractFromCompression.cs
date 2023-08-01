using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;

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
                converter.Convert(() => new MemoryStream(), (string sourceFileName, FileType convertedFileType, Stream convertedStream) =>
                {
                    string fileName = Path.Combine(outputFolder, sourceFileName);
                    var folderName = Path.GetDirectoryName(fileName);
                    if (!string.IsNullOrEmpty(folderName))
                    {
                        Directory.CreateDirectory(folderName);
                    }

                    using (var fs = new FileStream(fileName, FileMode.Create))
                    {
                        convertedStream.CopyTo(fs);
                    }
                }, (string sourceDocumentName, FileType sourceType) => null);
            }

            Console.WriteLine("\nExtract from compression completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
