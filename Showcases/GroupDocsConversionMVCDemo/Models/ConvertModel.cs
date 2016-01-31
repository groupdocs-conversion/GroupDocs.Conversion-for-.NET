using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;

namespace GroupdocsConversionMVCDemo.Models
{
    public class ConvertModel : System.Web.HttpApplication
    {
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

        // <summary>
        /// Get GroupDocs ConversionHandler Object
        /// </summary>
        /// <returns>ConversionHandler</returns>
        public ConversionHandler getConversionHandler()
        {
            storagePath = Server.MapPath("~/App_Data/");

            cachePath = Server.MapPath("~/App_Data/");

            licensePath = Server.MapPath("~/App_Data/");

            conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };
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
            conversionHandler.SetLicense(licensePath);
        }
    }
}