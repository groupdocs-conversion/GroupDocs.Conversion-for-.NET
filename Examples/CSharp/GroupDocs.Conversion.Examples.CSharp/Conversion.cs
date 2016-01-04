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
        public static string inputGUIDFile = "DOCXsample.docx";

        #region Convert to Spreadsheet Document

        /// <summary>
        /// Convert file  Spreadsheet Document formats and get output as file path
        /// </summary> 
        public static void ConvertToSpreadsheetAsPath()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new CellsSaveOptions());
        }

        /// <summary>
        /// Convert file  Spreadsheet Document formats and get output as Stream
        /// </summary> 
        public static void ConvertToSpreadsheetStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new CellsSaveOptions());
        }

        /// <summary>
        /// In AdvanceOptions()d example Convert Password Protected file to Spreadsheet Document formats 
        /// </summary>

        public static void ConvertToSpreadsheetAdvanceOptions()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Xls, starting from page 2 and convert 2 pages
            SaveOptions saveOptions = new CellsSaveOptions
            {
                ConvertFileType = CellsSaveOptions.CellsFileType.Xls,
                PageNumber = 2,
                NumPagesToConvert = 2
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion

        #region Convert to Word Processing Document


        /// <summary>
        /// Convert file to Word Processing Document format and get output as file path
        /// </summary> 

        public static void ConvertToWordDocumentAsPath()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new WordsSaveOptions());
        }


        /// <summary>
        /// Convert file to Word Processing Document format and get output as Stream
        /// </summary>

        public static void ConvertToWordDocumentAsStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new WordsSaveOptions());
        }

        /// <summary>
        /// In AdvanceOptions()d example Convert Password Protected file to Word Processing Document format
        /// </summary>

        public static void ConvertToWordDocumentAdvanceOptions()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Doc, starting from page 2 and convert 2 pages,
            SaveOptions saveOptions = new WordsSaveOptions
            {
                ConvertFileType = WordsSaveOptions.WordsFileType.Doc,
                PageNumber = 2,
                NumPagesToConvert = 2,
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion

        #region Convert to Pdf

        /// <summary>
        /// Convert file to Pdf format and get output as file path
        /// </summary>

        public static void ConvertToPdfAsPath()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new PdfSaveOptions());
        }

        /// <summary>
        /// Convert file to Pdf format and get output as Stream
        /// </summary>

        public static void ConvertToPdfAsStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new PdfSaveOptions());
        }

        /// <summary>
        /// In AdvanceOptions()d example Convert Password Protected file to Pdf format
        /// </summary>        
        public static void ConvertToPdfAdvanceOptions()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

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

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion

        #region Convert to Presentation Document

        /// <summary>
        /// Convert file to Presentation Document format and get output as file path
        /// </summary>
        public static void ConvertToPresentationAsPath()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new SlidesSaveOptions());
        }

        /// <summary>
        /// Convert file to Presentation Document format and get output as Stream
        /// </summary>
        public static void ConvertToPresentationAsStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new SlidesSaveOptions());
        }

        /// <summary>
        /// In AdvanceOptions()d example Convert Password Protected file to Presentation Document format
        /// </summary>

        public static void ConvertToPresentationAdvanceOptions()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

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

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
        }


        #endregion
    }
}
