using System;
using System.IO;
using GroupDocs.Conversion.Logging;
using GroupDocs.Conversion.Options.Convert;


namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to output conversion events to console.
    /// </summary>
    internal static class LogToConsole
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            ConsoleLogger logger = new ConsoleLogger();

            Func<ConverterSettings> settingsFactory = () => new ConverterSettings
            {
                Logger = logger
            };

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX, settingsFactory))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck log in console.");
        }
    }

    /// <summary>
    /// This example demonstrates how to output conversion events to custom logger.
    /// </summary>
    internal static class LogToCustom
    {
        public class CustomFileLogger : ILogger
        {
            private readonly string _fileName;

            /// <summary>
            /// Create logger to file.
            /// </summary>
            /// <param name="fileName">Full file name with path</param>
            public CustomFileLogger(string fileName)
            {
                _fileName = fileName;
            }

            /// <summary>
            /// Writes trace message to file.
            /// Trace log messages provide generally useful information about application flow.
            /// </summary>
            /// <param name="message">The trace message.</param>
            /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="message"/> is null.</exception>
            public void Trace(string message)
            {
                File.AppendAllText(_fileName, $"[TRACE] {message}{Environment.NewLine}");
            }

            /// <summary>
            /// Writes warning message to file.
            /// Warning log messages provide information about the unexpected and recoverable event in application flow.
            /// </summary>
            /// <param name="message">The warning message.</param>
            /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="message"/> is null.</exception>
            public void Warning(string message)
            {
                File.AppendAllText(_fileName, $"[WARN] {message}{Environment.NewLine}");
            }

            /// <summary>
            /// Writes an error message to file.
            /// Error log messages provide information about unrecoverable events in application flow.
            /// </summary>
            /// <param name="message">The error message.</param>
            /// <param name="exception">The exception.</param>
            /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="message"/> is null.</exception>
            /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="exception"/> is null.</exception>
            public void Error(string message, Exception exception)
            {
                File.AppendAllText(_fileName, $"[ERROR] {message}, exception: {exception}{Environment.NewLine}");
            }
        }

        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");
            string outputLogFile = Path.Combine(outputFolder, "conversion.log");

            ILogger logger = new CustomFileLogger(outputLogFile);

            Func<ConverterSettings> settingsFactory = () => new ConverterSettings
            {
                Logger = logger
            };

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX, settingsFactory))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck log at {0}", outputLogFile);
        }
    }
}
