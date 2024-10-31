﻿using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a csv document to pdf with advanced options
    /// </summary>
    internal static class ConvertCsvByConvertingDateTimeAndNumericData
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<LoadContext, LoadOptions> getLoadOptions = loadContext => new CsvLoadOptions
            {
                ConvertDateTimeData = true,
                ConvertNumericData = true
            };

            using (Converter converter = new Converter(Constants.SAMPLE_CSV, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nCsv document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
