using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a KMZ (zipped KML) file to GeoJSON
    /// </summary>
    internal static class ConvertKmzToGeoJson
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.geojson");

            using (Converter converter = new Converter(Constants.SAMPLE_KMZ))
            {
                GisConvertOptions options = new GisConvertOptions
                {
                    Format = GisFileType.GeoJson
                };
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nKMZ file converted to GeoJSON successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
