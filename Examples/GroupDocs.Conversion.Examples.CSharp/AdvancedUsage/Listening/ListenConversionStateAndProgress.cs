using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to listen for conversion state and progress.
    /// </summary>
    internal static class ListenConversionStateAndProgress
    {
        private static ConversionEvents ConversionEventsFactory()
        {
            var conversionEvents = new ConversionEvents
            {
                OnConversionStarted = () =>
                {
                    Console.WriteLine("Conversion started...");
                },
                OnConversionProgress = (current) =>
                {
                    Console.WriteLine($"... {current} % ...");
                },
                OnConversionCompleted = () =>
                {
                    Console.WriteLine("... conversion completed");
                }
            };

            return conversionEvents;
        }

        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<ConverterSettings> settingsFactory = () => new ConverterSettings
            {
            };

            Func<LoadContext, LoadOptions> getLoadOptions = loadContext => new WordProcessingLoadOptions
            {
                Password = "12345"
            };

            Func<ConversionEvents> conversionEventsFactory = ConversionEventsFactory;


            using (Converter converter = new Converter(Constants.SAMPLE_DOCX_WITH_PASSWORD, getLoadOptions, settingsFactory, conversionEventsFactory))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nPassword protected document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
