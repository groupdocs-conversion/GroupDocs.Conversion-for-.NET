using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert an email document and localize email fields
    /// </summary>
    internal static class ConvertEmailWithLocalizingEmailFields
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new EmailLoadOptions
            {
                ConvertOwned = false,
                FieldTextMap = new Dictionary<EmailField, string>
                {
                    {EmailField.Subject, "Gegenstand"},
                    {EmailField.From, "Von"},
                    {EmailField.Attachments, "Anhänge"}
                }
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new EmailLoadOptions
            {
                ConvertOwned = false,
                FieldTextMap = new Dictionary<EmailField, string>
                {
                    { EmailField.Subject, "Gegenstand" },
                    { EmailField.From, "Von" },
                    { EmailField.Attachments, "Anhänge" }
                }
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_EML, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nEmail document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
