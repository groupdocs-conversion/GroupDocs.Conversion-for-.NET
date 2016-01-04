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
    public static class Rendering
    {
        /// you can set Input and output paths and input file name along with license path
        public static string storagePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\SampleFiles");
        public static string cachePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\OutputFiles");
        public static string licensePath = Path.Combine(Environment.CurrentDirectory, @"GroupDocs.Conversion.lic");
        public static string inputGUIDFile = "DOCXsample.docx";

        #region Convert to HTML

        /// <summary>
        /// Convert file to HTML format and get output as file path
        /// </summary> 

        public static void ToHTMLAsPath()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentPath = conversionHandler.Convert<string>(inputGUIDFile, new HtmlSaveOptions());
        }

        /// <summary>
        /// Convert file to Excel format and get output as Stream
        /// </summary>

        public static void ToHTMLAsStream()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, new HtmlSaveOptions());
        }

        /// <summary>
        /// in Advanced example Convert Password Protected file to Excel format
        /// </summary

        public static void ToHTMLAdvance()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };
            // cache converted file
            conversionConfig.SetUseCache(true);

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "rizwan" };

            // convert starting from page 2 and convert 2 pages
            SaveOptions saveOptions = new HtmlSaveOptions
            {
                PageNumber = 2,
                NumPagesToConvert = 2
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion

        #region Convert to Image


        /// <summary>
        /// Convert file to Image format and get output as file path
        /// </summary> 

        public static void ToImageAsPath()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentPath = conversionHandler.Convert<IList<string>>(inputGUIDFile, new ImageSaveOptions { ConvertFileType = ImageSaveOptions.ImageFileType.Jpg });
        }

        /// <summary>
        /// Convert file to Image format and get output as Stream
        /// </summary>

        public static void ToImageAsStream()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>(inputGUIDFile, new ImageSaveOptions { ConvertFileType = ImageSaveOptions.ImageFileType.Jpg });
        }
        /// <summary>
        /// in Advanced example Convert Password Protected file to Image format
        /// </summary>


        public static void ToImageAdvance()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };
            conversionConfig.SetUseCache(true);

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Tiff, starting from page 2 and convert 2 pages,
            // use DPI 300, image width 1024, image height 768
            SaveOptions saveOptions = new ImageSaveOptions
            {
                ConvertFileType = ImageSaveOptions.ImageFileType.Tiff,
                PageNumber = 2,
                NumPagesToConvert = 2,
                Dpi = 300,
                Width = 1024,
                Height = 768
            };

            var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>(inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion
    }
}
