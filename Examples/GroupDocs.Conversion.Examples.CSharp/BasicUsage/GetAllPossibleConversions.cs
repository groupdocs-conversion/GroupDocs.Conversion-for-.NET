using System;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to get all possible conversions
    /// </summary>
    internal static class GetAllPossibleConversions
    {
        public static void Run()
        {
            var possibleConversions = Converter.GetAllPossibleConversions();
            foreach(var conversions in possibleConversions)
            {
                Console.WriteLine("{0} could be converted to:", conversions.Source.Extension);

                foreach (var conversion in conversions.All)
                {
                    Console.WriteLine("\t {0} as {1} conversion.", conversion.Format, conversion.IsPrimary?"primary": "secondary");
                }
                
            }

            Console.WriteLine("\nPossible conversions retrieved successfully.");
        }
    }
}