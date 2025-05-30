using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert J2K file into PPT format.
    /// For more details about JPEG 2000 Image (.j2k) to PowerPoint Presentation (.ppt) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-j2k-to-ppt
    /// </summary>
    internal static class ConvertJ2kToPpt
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "j2k-converted-to.ppt");
            
            // Load the source J2K file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_J2K))
            {
                PresentationConvertOptions options = new PresentationConvertOptions { Format = GroupDocs.Conversion.FileTypes.PresentationFileType.Ppt };
                // Save converted PPT file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to ppt completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
