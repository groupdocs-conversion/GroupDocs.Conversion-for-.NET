﻿using System;
using System.IO;

namespace GroupDocs.Conversion.Examples.CSharp.QuickStart
{
    /// <summary>
    /// This example demonstrates how to convert document to PDF.
    /// </summary>
    internal static class HelloWorldFluent
    {
        public static void Run()
        {
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string convertedFile = Path.Combine(outputDirectory, "converted.pdf");

            FluentConverter
                .Load(Constants.SAMPLE_DOCX)
                .ConvertTo(convertedFile)
                .OnConversionFailed((context, exception) => throw exception)
                .Convert();

            Console.WriteLine($"\nSource document converted successfully.\nCheck output in {outputDirectory}.");
        }
    }
}
