using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to run the scripts of a trusted HTML document with ExecuteScripts.
    /// Scripts do not run by default.
    /// </summary>
    internal static class RunScriptsOfTrustedHtmlDocument
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<LoadContext, LoadOptions> getLoadOptions = loadContext => new WebLoadOptions
            {
                ExecuteScripts = true
            };

            using (Converter converter = new Converter(Constants.SAMPLE_HTML_WITH_EXTERNAL_RESOURCES, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted with its scripts run. \nCheck output in {0}", outputFolder);
        }
    }
}
