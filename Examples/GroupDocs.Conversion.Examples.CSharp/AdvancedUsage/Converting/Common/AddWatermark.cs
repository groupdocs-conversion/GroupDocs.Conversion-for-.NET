using System;
using System.Drawing;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to add watermark during conversion
    /// </summary>
    internal static class AddWatermark
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX))
            {
                PdfConvertOptions options = new PdfConvertOptions
                {
                    Watermark = new WatermarkOptions
                    {
                        Text = "Sample watermark",
                        Color = Color.Red,
                        Width = 100,
                        Height = 100,
                        Background = true
                    }
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
