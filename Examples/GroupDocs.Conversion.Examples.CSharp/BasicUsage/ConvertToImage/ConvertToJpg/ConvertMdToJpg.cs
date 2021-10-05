using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MD file into JPG format.
    /// For more details about Markdown (.md) to Joint Photographic Expert Group Image File (.jpg) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-md-to-jpg
    /// </summary>
    internal static class ConvertMdToJpg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.jpg");
            GroupDocs.Conversion.Contracts.SavePageStream getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);

            // Load the source MD file
            using (Converter converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MD))
            {
                // Set the convert options for JPG format
                ImageConvertOptions options = new ImageConvertOptions { Format = GroupDocs.Conversion.FileTypes.ImageFileType.Jpg };  
                // Convert to JPG format
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nConversion to jpg completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}