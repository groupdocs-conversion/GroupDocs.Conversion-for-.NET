using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a presentation to a self-contained HTML slideshow
    /// </summary>
    internal static class ConvertPresentationToHtmlSlideshow
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "slideshow.html");

            using (Converter converter = new Converter(Constants.SAMPLE_PPTX))
            {
                WebConvertOptions options = new WebConvertOptions
                {
                    SlideShow = true
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nPresentation converted to an HTML slideshow successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
