using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert content in personal storage to different formats
    /// Emails will be converted to Html
    /// Jpg will be converted to Png
    /// Docx will be converted to Pdf
    /// </summary>
    internal static class ConvertPersonalStorageContentToDifferentFormats
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();

            using (Converter converter = new Converter(Constants.SAMPLE_OST, (FileType fileType) =>
            {
                if (fileType == PersonalStorageFileType.Ost)
                {
                    return new PersonalStorageLoadOptions
                    {
                        Folder = "ROOT/Root - Mailbox/IPM_SUBTREE/Inbox",
                    };
                }

                if (fileType == EmailFileType.Msg)
                {
                    return new EmailLoadOptions
                    {
                        ConvertOwner = true,
                        ConvertOwned = true,
                        Depth = 2
                    };
                }
                return null;
            }))
            {
                int index = 0;
                converter.Convert((FileType fileType) =>
                {
                    string fileName = $"converted_{++index}.{fileType.Extension}";
                    string outputFile = Path.Combine(outputFolder, fileName);
                    return new FileStream(outputFile, FileMode.Create);
                }, (string sourceFileName, FileType fileType) =>
                {
                    if (fileType == ImageFileType.Jpg)
                    {
                        return new ImageConvertOptions
                        {
                            Format = ImageFileType.Png
                        };
                    }

                    if (fileType == WordProcessingFileType.Docx)
                    {
                        return new PdfConvertOptions();
                    }

                    return new MarkupConvertOptions();
                });
            }

            Console.WriteLine("\nDocuments converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}