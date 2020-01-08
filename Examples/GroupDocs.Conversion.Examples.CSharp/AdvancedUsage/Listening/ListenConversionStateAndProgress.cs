using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;
using GroupDocs.Conversion.Reporting;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to listen for conversion state and progress.
    /// </summary>
    internal static class ListenConversionStateAndProgress
    {
        private class ConverterListener : IConverterListener
        {
            public void Started()
            {
                Console.WriteLine("Conversion started...");
            }

            public void Progress(byte current)
            {
                Console.WriteLine($"... {current} % ...");
            }

            public void Completed()
            {
                Console.WriteLine("... conversion completed");
            }
        }

        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

#if NETCOREAPP
            Func<ConverterSettings> settingsFactory = () => new ConverterSettings
            {
                Listener = new ConverterListener()
            };

            Func<LoadOptions> getLoadOptions = () => new WordProcessingLoadOptions
            {
                Password = "12345"
            };
           
#else     
            Contracts.Func<ConverterSettings> settingsFactory = () => new ConverterSettings
            {
                Listener = new ConverterListener()
            };

            Contracts.Func<LoadOptions> getLoadOptions = () => new WordProcessingLoadOptions
            {
                Password = "12345"
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_DOCX_WITH_PASSWORD, getLoadOptions, settingsFactory))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nPassword protected document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
