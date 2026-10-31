using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to load external resources only from trusted locations,
    /// listed in WhitelistedResources as absolute URI prefixes.
    /// </summary>
    internal static class LoadExternalResourcesFromTrustedLocations
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<LoadContext, LoadOptions> getLoadOptions = loadContext => new WebLoadOptions
            {
                WhitelistedResources = new List<string>
                {
                    "https://raw.githubusercontent.com/groupdocs/groupdocs.github.io/master/img/"
                }
            };

            using (Converter converter = new Converter(Constants.SAMPLE_HTML_WITH_EXTERNAL_RESOURCES, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted with resources from trusted locations only. \nCheck output in {0}", outputFolder);
        }
    }
}
