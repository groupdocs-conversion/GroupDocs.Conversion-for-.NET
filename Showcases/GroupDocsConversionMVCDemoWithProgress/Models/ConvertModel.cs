using System.Collections.Generic;
using System.Web.Mvc;
using GroupDocs.Conversion;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;

namespace GroupDocsConversionMVCDemoWithProgress.Models
{
    public class ConvertModel : System.Web.HttpApplication
    {
        public static IEnumerable<SelectListItem> AvailableFileTypes { get; set; }
        // storagePath property to set input file/s directory
        public string storagePath = "~/App_Data/";

        // cachePath property to set output file/s directory
        public string cachePath = "~/App_Data/";

        // licensePath property to set GroupDocs.Conversion license file anme and path
        public string licensePath = "~/App_Data/";

        // inputGUIDFile property to set input file
        public string inputGUIDFile = "DOCXsample.docx";

        // Creating new ConversionConfig class object with input and output files directory path
        private ConversionConfig conversionConfig;

        // Creating new ConversionHandler class object with ConversionConfig object
        private ConversionHandler conversionHandler;

        // Instantiate GroupDocs.Conversion license
        private static License license = new License();

        // <summary>
        /// Get GroupDocs ConversionHandler Object
        /// </summary>
        /// <returns>ConversionHandler</returns>
        public ConversionHandler getConversionHandler()
        {
            storagePath = Server.MapPath("~/App_Data/");

            cachePath = Server.MapPath("~/App_Data/");

            licensePath = Server.MapPath("~/App_Data/");

            // Creating new ConversionConfig class object with input and output files directory path
            conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

            // Set false to disable cache
            conversionConfig.UseCache = true;

            // Creating new ConversionHandler class object with ConversionConfig object
            conversionHandler = new ConversionHandler(conversionConfig);

            // Returns the ConversionHandler static object
            return conversionHandler;
        }

        /// <summary>
        /// Applies GroupDocs.Conversion license
        /// </summary>
        public void ApplyLicense()
        {
            // Apply GroupDocs.Conversion license using license path provided/set in licensePath property
            license.SetLicense(licensePath);
        }
    }
}