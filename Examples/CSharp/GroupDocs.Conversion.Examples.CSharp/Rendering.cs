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
        #region Converts and Render in HTML

        /// <summary>
        /// Converts and Render file to a HTML format and get output as file path
        /// </summary> 

        public static void RenderHTMLAsPath()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();
            
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new HtmlSaveOptions());
        }

        /// <summary>
        /// Converts and Render file as HTML format and get output as Stream
        /// </summary>

        public static void RenderHTMLAsStream()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new HtmlSaveOptions());
        }

        /// <summary>
        /// In AdvanceOptions()d example Converts and Render Password Protected file to Excel format
        /// </summary

        public static void RenderHTMLAdvanceOptions()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert starting from page 2 and convert 2 pages
            SaveOptions saveOptions = new HtmlSaveOptions
            {
                PageNumber = 2,
                NumPagesToConvert = 2
            };

            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion

        #region Converts and Render in Image


        /// <summary>
        /// Converts and Render file to an Image format and get output as file path
        /// </summary> 
        /// <param name="outputFileType"></param>
        public static void RenderImageAsPath(ImageSaveOptions.ImageFileType outputFileType)
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentPath = conversionHandler.Convert<IList<string>>(Common.inputGUIDFile, new ImageSaveOptions { ConvertFileType = outputFileType });
        }

        /// <summary>
        /// Converts and Render file to an Image format and get output as Stream
        /// </summary>
        /// <param name="outputFileType"></param>
        public static void RenderImageAsStream(ImageSaveOptions.ImageFileType outputFileType)
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>(Common.inputGUIDFile, new ImageSaveOptions { ConvertFileType = outputFileType });
        }

        /// <summary>
        /// In AdvanceOptions()d example Converts and Render Password Protected file to Image format
        /// </summary>
        /// <param name="outputFileType"></param>
        public static void RenderImageAdvanceOptions(ImageSaveOptions.ImageFileType outputFileType)
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Tiff, starting from page 2 and convert 2 pages,
            // use DPI 300, image width 1024, image height 768
            SaveOptions saveOptions = new ImageSaveOptions
            {
                ConvertFileType = outputFileType,
                PageNumber = 2,
                NumPagesToConvert = 2,
                Dpi = 300,
                Width = 1024,
                Height = 768
            };

            var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>(Common.inputGUIDFile, loadOptions, saveOptions);
        }

        #endregion
    }
}
