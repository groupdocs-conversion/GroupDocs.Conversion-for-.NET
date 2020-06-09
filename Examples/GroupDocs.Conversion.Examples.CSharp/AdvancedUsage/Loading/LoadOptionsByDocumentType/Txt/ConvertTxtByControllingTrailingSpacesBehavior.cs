using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a txt document to pdf with advanced options
    /// </summary>
    internal static class ConvertTxtByControllingTrailingSpacesBehavior
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new TxtLoadOptions
            {
                TrailingSpacesOptions = TxtTrailingSpacesOptions.Trim
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new TxtLoadOptions
            {
                TrailingSpacesOptions = TxtTrailingSpacesOptions.Trim
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_TXT, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nTxt document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
