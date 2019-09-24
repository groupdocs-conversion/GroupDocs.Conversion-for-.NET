using System;
using System.IO;
using GroupDocs.Conversion.Contracts;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert document to PNG.
    /// </summary>
    internal static class ConvertToPng
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.png");

            SavePageStream getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);

            using (Converter converter = new Converter(Constants.SAMPLE_PDF))
            {
                ImageConvertOptions options = new ImageConvertOptions
                {
                    Format = ImageFileType.Png
                };
                
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nConversion to png completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
