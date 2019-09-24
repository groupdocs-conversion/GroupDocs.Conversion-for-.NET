using System;
using System.IO;
using GroupDocs.Conversion.Contracts;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a pdf document to image with advanced options
    /// </summary>
    internal static class ConvertToImageWithAdvancedOptions
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
                    Format = ImageFileType.Png,
                    FlipMode = ImageFlipModes.FlipY,
                    Brightness = 50,
                    Contrast = 50,
                    Gamma = 0.5F,
                    Grayscale = true,
                    HorizontalResolution = 300,
                    VerticalResolution = 100
                };
                
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
