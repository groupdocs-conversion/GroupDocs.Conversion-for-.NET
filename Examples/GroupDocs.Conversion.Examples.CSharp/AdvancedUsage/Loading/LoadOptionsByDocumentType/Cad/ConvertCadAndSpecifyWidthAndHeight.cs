using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a cad document to pdf with advanced options
    /// </summary>
    internal static class ConvertCadAndSpecifyWidthAndHeight
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new CadLoadOptions
            {
                Width = 1920,
                Height = 1080
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new CadLoadOptions
            {
                Width = 1920,
                Height = 1080
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_DWG_WITH_LAYOUTS_AND_LAYERS, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }


            Console.WriteLine("\nCad document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
