using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert ONE file into JPG format.
    /// For more details about Microsoft OneNote File Format (.one) to Joint Photographic Expert Group Image File (.jpg) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-one-to-jpg
    /// </summary>
    internal static class ConvertOneToJpg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.jpg");
            Func<SavePageContext, Stream> getPageStream = savePageContext => new FileStream(string.Format(outputFileTemplate, savePageContext.Page), FileMode.Create);

            // Load the source ONE file
            using (Converter converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_ONE))
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