using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert EPS file into DOC format.
    /// For more details about Encapsulated PostScript File (.eps) to Microsoft Word Document (.doc) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-eps-to-doc
    /// </summary>
    internal static class ConvertEpsToDoc
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "eps-converted-to.doc");
            
            // Load the source EPS file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_EPS))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions { Format = GroupDocs.Conversion.FileTypes.WordProcessingFileType.Doc };
                // Save converted DOC file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to doc completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
