using System;
using System.IO;
using GroupDocs.Conversion.Contracts;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert document to JPG.
    /// </summary>
    internal static class ConvertToJpg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.jpg");

            SavePageStream getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);

            using (Converter converter = new Converter(Constants.SAMPLE_PDF))
            {
                ImageConvertOptions options = new ImageConvertOptions
                {
                    Format = ImageFileType.Jpg
                };
                
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nConversion to jpg completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
