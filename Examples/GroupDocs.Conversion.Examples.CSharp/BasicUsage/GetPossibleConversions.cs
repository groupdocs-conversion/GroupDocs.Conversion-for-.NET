using System;
using GroupDocs.Conversion.Contracts;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to get to what formats the source document could be converted
    /// </summary>
    internal static class GetPossibleConversions
    {
        public static void Run()
        {
            using (Converter converter = new Converter(Constants.SAMPLE_DOCX))
            {
                PossibleConversions conversions = converter.GetPossibleConversions();

                Console.WriteLine("{0} is of type {1} and could be converted to:", Constants.SAMPLE_DOCX, conversions.Source.Extension);

                foreach (var conversion in conversions.All)
                {
                    Console.WriteLine("\t {0} as {1} conversion.", conversion.Key, conversion.Value?"primary": "secondary");
                }
                
            }

            Console.WriteLine("\nPossible conversions retrieved successfully.");
        }
    }
}
