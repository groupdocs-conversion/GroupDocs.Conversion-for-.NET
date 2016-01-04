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
    public static class Conversion
    {
        /// you can set Input and output paths and input file name along with license path
        public static string storagePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\SampleFiles");
        public static string cachePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\OutputFiles");
        public static string licensePath = Path.Combine(Environment.CurrentDirectory, @"GroupDocs.conversion.lic");
        public static string inputGUIDFile = "DOCXsample.docx";

        #region Convert to Cells

        /// <summary>
        /// Convert file to Excel format and get output as file path
        /// </summary> 
        public static void ToCellsAsPath()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            /// set license path for GroupDocs.Conversion
         //conversionHandler.SetLicense(licensePath);
            var convertedDocumentPath = conversionHandler.Convert<string>(inputGUIDFile, new CellsSaveOptions());
        }

        /// <summary>
        /// Convert file to Excel format and get output as Stream
        /// </summary> 
        public static void ToCellsAsStream()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, new CellsSaveOptions());
        }

        /// <summary>
        /// in Advanced example Convert Password Protected file to Excel format 
        /// </summary>

        public static void ToCellsAdvance()
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

            // convert file to Xls, starting from page 2 and convert 2 pages
            SaveOptions saveOptions = new CellsSaveOptions
            {
                ConvertFileType = CellsSaveOptions.CellsFileType.Xls,
                PageNumber = 2,
                NumPagesToConvert = 2
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion

        #region Convert to Words


        /// <summary>
        /// Convert file to Word format and get output as file path
        /// </summary> 

        public static void ToWordsAsPath()
        {

            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentPath = conversionHandler.Convert<string>(inputGUIDFile, new WordsSaveOptions());
        }


        /// <summary>
        /// Convert file to Word format and get output as Stream
        /// </summary>

        public static void ToWordsAsStream()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, new WordsSaveOptions());
        }

        /// <summary>
        /// in Advanced example Convert Password Protected file to Word format
        /// </summary>

        public static void ToWordsAdvance()
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

            // convert file to Doc, starting from page 2 and convert 2 pages,
            SaveOptions saveOptions = new WordsSaveOptions
            {
                ConvertFileType = WordsSaveOptions.WordsFileType.Doc,
                PageNumber = 2,
                NumPagesToConvert = 2,
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion

        #region Convert to PDF

        /// <summary>
        /// Convert file to PDF format and get output as file path
        /// </summary>

        public static void ToPdfAsPath()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentPath = conversionHandler.Convert<string>(inputGUIDFile, new PdfSaveOptions());
        }

        /// <summary>
        /// Convert file to PDF format and get output as Stream
        /// </summary>

        public static void ToPdfAsStream()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, new PdfSaveOptions());
        }

        /// <summary>
        /// in Advanced example Convert Password Protected file to PDF format
        /// </summary>        
        public static void ToPdfAdvance()
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

        #endregion

        #region Convert to Slides

        /// <summary>
        /// Convert file to PowerPiont format and get output as file path
        /// </summary>
        public static void ToSlidesAsPath()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentPath = conversionHandler.Convert<string>(inputGUIDFile, new SlidesSaveOptions());
        }

        /// <summary>
        /// Convert file to PowerPiont format and get output as Stream
        /// </summary>
        public static void ToSlidesAsStream()
        {
            // Setup Conversion configuration
            var conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            //instantiating the conversion handler
            var conversionHandler = new ConversionHandler(conversionConfig);

            // set license path for GroupDocs.Conversion
            // conversionHandler.SetLicense(licensePath);

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, new SlidesSaveOptions());
        }

        /// <summary>
        /// in Advanced example Convert Password Protected file to PowerPiont format
        /// </summary>

        public static void ToSlidesAdvance()
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

            // convert file to Ppt, starting from page 2 and convert 2 pages,
            // use DPI 300, image width 1024, image height 768
            SaveOptions saveOptions = new SlidesSaveOptions
            {
                ConvertFileType = SlidesSaveOptions.SlidesFileType.Ppt,
                PageNumber = 2,
                NumPagesToConvert = 2,
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(inputGUIDFile, loadOptions, saveOptions);
        }


        #endregion
    }
}
