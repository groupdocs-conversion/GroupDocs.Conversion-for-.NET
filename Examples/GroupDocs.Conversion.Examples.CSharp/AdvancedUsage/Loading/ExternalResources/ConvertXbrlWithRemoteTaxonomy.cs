using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert an XBRL document whose taxonomy is published online.
    /// External resources are not loaded by default, so such a document loads only with SkipExternalResources set to false.
    /// </summary>
    internal static class ConvertXbrlWithRemoteTaxonomy
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.ixbrl");

            Func<LoadContext, LoadOptions> getLoadOptions = loadContext => new FinanceLoadOptions
            {
                SkipExternalResources = false
            };

            using (Converter converter = new Converter(Constants.SAMPLE_XBRL_WITH_REMOTE_TAXONOMY, getLoadOptions))
            {
                FinanceConvertOptions options = new FinanceConvertOptions
                {
                    Format = FinanceFileType.IXbrl
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nXBRL document with a remote taxonomy converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
