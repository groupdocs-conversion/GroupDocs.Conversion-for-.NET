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

            // Convert and save converted spreadsheet documents.
            // Returns paths to the converted spreadsheet documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new CellsSaveOptions());
        }

        /// <summary>
        /// Converts documents to Spreadsheet Document formats and outputs the resulting document to a stream
        /// </summary> 
        public static void ConvertToSpreadsheetStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted spreadsheet documents. 
            // Returns the converted spreadsheet documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new CellsSaveOptions());
        }

        /// <summary>
        /// In advance options example Convert Password Protected file to Spreadsheet Document formats 
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

            // Unprotect input document, Convert and save spreadsheet documents using advance options.
            // Returns the converted spreadsheet documents as IO Stream.
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

            // Convert and save converted word processing documents.
            // Returns paths to the converted word processing documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new WordsSaveOptions());
        }


        /// <summary>
        /// Converts documents to Word Processing Document formats and outputs the resulting document to a stream
        /// </summary>

        public static void ConvertToWordDocumentAsStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted word processing documents. 
            // Returns the converted word processing documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new WordsSaveOptions());
        }

        /// <summary>
        /// In advance options example Convert Password Protected file to Word Processing Document format
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

            // Unprotect input document, Convert and save word processing documents using advance options.
            // Returns the converted word processing documents as IO Stream.
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

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new PdfSaveOptions());
        }

        /// <summary>
        /// Converts documents to Pdf Document formats and outputs the resulting document to a stream
        /// </summary>

        public static void ConvertToPdfAsStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted Pdf documents. 
            // Returns the converted spreadsheet Pdf as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new PdfSaveOptions());
        }

        /// <summary>
        /// In advance options example Convert Password Protected file to Pdf format
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

            // Unprotect input document, Convert and save Pdf documents using advance options.
            // Returns the converted spreadsheet Pdf as IO Stream.
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

            // Convert and save converted presentation documents.
            // Returns paths to the converted presentation documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new SlidesSaveOptions());
        }

        /// <summary>
        /// Converts documents to Presentation Document format and outputs the resulting document to a stream
        /// </summary>
        public static void ConvertToPresentationAsStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted presentation documents. 
            // Returns the converted presentation documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new SlidesSaveOptions());
        }

        /// <summary>
        /// In advance options example Convert Password Protected file to Presentation Document format
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

            // Unprotect input document, Convert and save presentation documents using advance options.
            // Returns the converted presentation documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
        }


        #endregion
    }
}
