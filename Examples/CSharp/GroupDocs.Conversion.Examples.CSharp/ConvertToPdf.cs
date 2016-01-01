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
    class ConvertToPdf
    {
        // Default Sample File Path and output path and GUID File as Input
        public static string storagePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\SampleFiles");
        public static string cachePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\OutputFiles");
        public static string inputGUIDFile = "DOCXsample.docx";
        //public static string inputGUIDFile = "PDFsample.pdf";

        // Result as file path
        public static void ToPdfAsPath()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            var convertedDocumentPath = conversionHandler.Convert<string>(inputGUIDFile, new PdfSaveOptions());
        }

        // Result as Stream
        public static void ToPdfAsStream()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);


            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, new PdfSaveOptions());
        }

        // Advanced example
        public static void ToPdfAdvance()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };
            conversionConfig.SetUseCache(true);

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert starting from page 2 and convert 2 pages,
            // use DPI 300, page width 1024, page height 768
            SaveOptions saveOptions = new PdfSaveOptions
            {
                PageNumber = 2,
                NumPagesToConvert = 2,
                Dpi = 300,
                Width = 1024,
                Height = 768
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, loadOptions, saveOptions);
        }
    }
}
