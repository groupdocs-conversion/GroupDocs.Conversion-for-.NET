//ExStart:CommonClass
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
    public static class Common
    {
        //ExStart:CommonProperties
        // storagePath property to set input file/s directory
        public static string storagePath = Path.Combine(Environment.CurrentDirectory, @"../../../../Data/SampleFiles");

        // cachePath property to set cache file/s directory
        public static string cachePath = Path.Combine(Environment.CurrentDirectory, @"../../../../Data/Cache");

        // outputPath property to set output file/s directory
        public static string outputPath = Path.Combine(Environment.CurrentDirectory, @"../../../../Data/ConvertedFiles");

        // licensePath property to set GroupDocs.Conversion license file anme and path
        public static string licensePath = Path.Combine(Environment.CurrentDirectory, @"GroupDocs.conversion.lic");

        // inputGUIDFile property to set input file
        public static string inputGUIDFile = "DOCXsample.docx";

        // Instantiate GroupDocs.Conversion ConversionConfig class object
        private static ConversionConfig conversionConfig = null;

        // Instantiate GroupDocs.Conversion ConversionHandler class object
        private static ConversionHandler conversionHandler = null;

        //ExEnd:CommonProperties

        //ExStart:getConversionHandler
        /// <summary>
        /// Get GroupDocs ConversionHandler Object
        /// </summary>
        /// <returns>ConversionHandler</returns>
        public static ConversionHandler getConversionHandler()
        {
            if (conversionConfig == null)
            {
                // Creating new ConversionConfig class object with input and output files directory path
                conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath, OutputPath = outputPath };
            }

            // Set false to disable cache
            conversionConfig.UseCache = false;

            // Creating new ConversionHandler class object with ConversionConfig object
            conversionHandler = new ConversionHandler(conversionConfig);

            // Returns the ConversionHandler static object
            return conversionHandler;
        }
        //ExEnd:getConversionHandler

        //ExStart:getConversionHandlerUsingCache
        /// <summary>
        /// Get GroupDocs ConversionHandler Object
        /// </summary>
        /// <returns>ConversionHandler</returns>
        public static ConversionHandler getConversionHandlerUsingCache(bool isUseCache)
        {
            if (conversionConfig == null)
            {
                // Creating new ConversionConfig class object with input and output files directory path
                conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath, OutputPath = outputPath };
            }

            // Set to use cache or not
            conversionConfig.UseCache = isUseCache;

            // Creating new ConversionHandler class object with ConversionConfig object
            conversionHandler = new ConversionHandler(conversionConfig);

            // Returns the ConversionHandler static object
            return conversionHandler;
        }
        //ExEnd:getConversionHandlerUsingCache

        //ExStart:ApplyLicense
        /// <summary>
        /// Applies GroupDocs.Conversion license
        /// </summary>
        public static void ApplyLicense(string filepath)
        {
            // Instantiate GroupDocs.Conversion license
            GroupDocs.Conversion.License license = new GroupDocs.Conversion.License();

            // Apply GroupDocs.Conversion license using license path
            license.SetLicense(filepath);
        }

        /// <summary>
        /// Applies GroupDocs.Conversion license using stream input
        /// </summary>
        public static void ApplyLicense(Stream licenseStream)
        {
            // Instantiate GroupDocs.Conversion license
            GroupDocs.Conversion.License license = new GroupDocs.Conversion.License();

            // Apply GroupDocs.Conversion license using license file stream
            license.SetLicense(licenseStream);
        }
        //ExEnd:ApplyLicense
    }
}
//ExEnd:CommonClass
