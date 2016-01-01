using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;

namespace GroupDocs.Conversion.Examples.CSharp
{
    class ConvertToCells
    {
        // Default Sample File Path and output path and GUID File as Input
        public static string storagePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\SampleFiles");
        public static string cachePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\OutputFiles");
        public static string inputGUIDFile = "DOCXsample.docx";
        //public static string inputGUIDFile = "PDFsample.pdf";

        // Result as file path
        public static void ToCellsAsPath()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            var convertedDocumentPath = conversionHandler.Convert<string>(inputGUIDFile, new CellsSaveOptions());
        }

        // Result as Stream
        public static void ToCellsAsStream()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, new CellsSaveOptions());
        }

        // Advanced example
        public static void ToCellsAdvance()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };
            conversionConfig.SetUseCache(true);

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Xls, starting from page 2 and convert 2 pages
            SaveOptions saveOptions = new CellsSaveOptions
            {
                ConvertFileType = CellsSaveOptions.CellsFileType.Xls,
                PageNumber = 2,
                NumPagesToConvert = 2
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, loadOptions, saveOptions);
        }
    }
}
