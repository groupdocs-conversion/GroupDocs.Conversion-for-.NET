using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert XLTM file into PSD format.
    /// For more details about Microsoft Excel Macro-Enabled Template (.xltm) to Adobe Photoshop Document (.psd) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-xltm-to-psd
    /// </summary>
    internal static class ConvertXltmToPsd
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.psd");
            Func<SavePageContext, Stream> getPageStream = savePageContext => new FileStream(string.Format(outputFileTemplate, savePageContext.Page), FileMode.Create);

            // Load the source XLTM file
            using (Converter converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_XLTM))
            {
                // Set the convert options for PSD format
                ImageConvertOptions options = new ImageConvertOptions { Format = GroupDocs.Conversion.FileTypes.ImageFileType.Psd };  
                // Convert to PSD format
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nConversion to psd completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}