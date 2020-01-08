using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Contracts;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a presentation document to pdf with advanced options
    /// </summary>
    internal static class ConvertPresentationBySpecifyingFontSubstitution
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new PresentationLoadOptions
            {
                DefaultFont = "Helvetica",
                FontSubstitutes = new List<FontSubstitute>
                {
                    FontSubstitute.Create("Tahoma", "Arial"),
                    FontSubstitute.Create("Times New Roman", "Arial"),
                }
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new PresentationLoadOptions
            {
                DefaultFont = "Helvetica",
                FontSubstitutes = new List<FontSubstitute>
                {
                    FontSubstitute.Create("Tahoma", "Arial"),
                    FontSubstitute.Create("Times New Roman", "Arial"),
                }
            };
#endif
            using (Converter converter = new Converter(Constants.PPTX_WITH_NOTES, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nPresentation document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
