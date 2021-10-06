using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert AI file into PNG format.
    /// For more details about Adobe Illustrator (.ai) to Portable Network Graphic (.png) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-ai-to-png
    /// </summary>
    internal static class ConvertAiToPng
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath(); 
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.png");
            GroupDocs.Conversion.Contracts.SavePageStream getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);

            // Load the source AI file
            using (Converter converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_AI))
            {
                // Set the convert options for PNG format
                ImageConvertOptions options = new ImageConvertOptions { Format = GroupDocs.Conversion.FileTypes.ImageFileType.Png };  
                // Convert to PNG format
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nConversion to png completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}