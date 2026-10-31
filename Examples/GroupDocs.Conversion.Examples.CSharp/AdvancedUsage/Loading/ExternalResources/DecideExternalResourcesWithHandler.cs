using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to decide for each external resource in your own code
    /// with an IExternalResourceHandler: PNG images from one trusted host are loaded, everything else keeps the default decision.
    /// </summary>
    internal static class DecideExternalResourcesWithHandler
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<LoadContext, LoadOptions> getLoadOptions = loadContext => new WebLoadOptions
            {
                ExternalResourceHandler = new TrustedPngHandler()
            };

            using (Converter converter = new Converter(Constants.SAMPLE_HTML_WITH_EXTERNAL_RESOURCES, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted with resources allowed by the handler. \nCheck output in {0}", outputFolder);
        }

        private class TrustedPngHandler : IExternalResourceHandler
        {
            public void OnLoading(ExternalResourceLoadingArgs args)
            {
                Uri uri;
                if (Uri.TryCreate(args.Uri, UriKind.Absolute, out uri)
                    && uri.Scheme == Uri.UriSchemeHttps
                    && string.Equals(uri.Host, "raw.githubusercontent.com", StringComparison.OrdinalIgnoreCase)
                    && uri.AbsolutePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                {
                    args.Skipped = false;
                }

                Console.WriteLine("{0}: {1}", args.Skipped ? "skipped" : "loaded", args.Uri);
            }
        }
    }
}
