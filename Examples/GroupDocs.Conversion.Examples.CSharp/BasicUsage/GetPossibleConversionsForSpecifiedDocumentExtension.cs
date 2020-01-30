using System;
using GroupDocs.Conversion.Contracts;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to get to what formats an source document format could be converted
    /// </summary>
    internal static class GetPossibleConversionsForSpecifiedDocumentExtension
    {
        public static void Run()
        {
            PossibleConversions conversions = Converter.GetPossibleConversions("docx");

            Console.WriteLine("{0} could be converted to:", conversions.Source.Extension);

            foreach (var conversion in conversions.All)
            {
                Console.WriteLine("\t {0} as {1} conversion.", conversion.Format,
                    conversion.IsPrimary ? "primary" : "secondary");
            }


            Console.WriteLine("\nPossible conversions retrieved successfully.");
        }
    }
}