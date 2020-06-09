using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert each email message attachment to different format based on the attachment document type
    /// </summary>
    internal static class ConvertEachEmailAttachmentToDifferentFormat
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            
            var index = 1;

            LoadOptions LoadOptionsProvider(FileType sourceType)
            {
                if (sourceType == EmailFileType.Eml)
                {
                    return new EmailLoadOptions
                    {
                        ConvertOwned = true, 
                        ConvertOwner = true,
                        Depth = 2
                    };
                }

                return null;
            }

            Stream ConvertedStreamProvider(FileType targetType)
            {
                string outputFile = Path.Combine(outputFolder, $"converted-{index++}.{targetType.Extension}");
                return new FileStream(outputFile, FileMode.Create);
            }

            ConvertOptions ConvertOptionsProvider(string sourceDocumentName, FileType sourceType)
            {
                if (sourceType == EmailFileType.Eml)
                {
                    return new WordProcessingConvertOptions();
                }
                
                if (sourceType == WordProcessingFileType.Txt)
                {
                    return new PdfConvertOptions();
                }

                return new ImageConvertOptions();
            }

            
            using (var converter = new Converter(Constants.SAMPLE_EML_WITH_ATTACHMENT, LoadOptionsProvider))
            {
                converter.Convert(ConvertedStreamProvider, ConvertOptionsProvider);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}