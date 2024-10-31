﻿using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert messages from OST document to different formats
    /// </summary>
    internal static class ConvertOstDocumentMessagesToDifferentFormats
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            
            var index = 1;

            LoadOptions LoadOptionsProvider(LoadContext loadContext)
            {
                if (loadContext.SourceFormat == EmailFileType.Ost)
                {
                    return new PersonalStorageLoadOptions
                    {
                        Folder = @"Root - Mailbox/IPM_SUBTREE/Inbox", 
                        Depth = 2
                    };
                }

                return null;
            }

            Stream ConvertedStreamProvider(SaveContext saveContext)
            {
                string outputFile = Path.Combine(outputFolder, $"converted-{index++}.{saveContext.TargetFormat.Extension}");
                return new FileStream(outputFile, FileMode.Create);
            }

            ConvertOptions ConvertOptionsProvider(ConvertContext convertContext)
            {
                if (convertContext.SourceFormat == EmailFileType.Msg)
                {
                    return new PdfConvertOptions();
                }
            
                return new WordProcessingConvertOptions();
            }

            
            using (var converter = new Converter(Constants.SAMPLE_OST, LoadOptionsProvider))
            {
                converter.Convert(ConvertedStreamProvider, ConvertOptionsProvider);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}