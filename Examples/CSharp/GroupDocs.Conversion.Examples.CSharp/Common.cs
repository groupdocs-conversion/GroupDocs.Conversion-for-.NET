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
        //ExStart:CommonClass
        // storagePath property to set input file/s directory
        public static string storagePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\SampleFiles");

        // cachePath property to set output file/s directory
        public static string cachePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\OutputFiles");

        // licensePath property to set GroupDocs.Conversion license file anme and path
        public static string licensePath = Path.Combine(Environment.CurrentDirectory, @"GroupDocs.conversion.lic");

        // inputGUIDFile property to set input file
        public static string inputGUIDFile = "DOCXsample.docx";

        // Creating new ConversionConfig class object with input and output files directory path
        private static ConversionConfig conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };

        // Creating new ConversionHandler class object with ConversionConfig object
        private static ConversionHandler conversionHandler = new ConversionHandler(conversionConfig);


        /// <summary>
        /// Get GroupDocs ConversionHandler Object
        /// </summary>
        /// <returns>ConversionHandler</returns>
        public static ConversionHandler getConversionHandler()
        {
            // Returns the ConversionHandler static object
            return conversionHandler;
        }


        /// <summary>
        /// Applies GroupDocs.Conversion license
        /// </summary>
        public static void ApplyLicense()
        {
            // Apply GroupDocs.Conversion license using license path provided/set in licensePath property
            conversionHandler.SetLicense(licensePath);
        }
        //ExEnd:CommonClass
    }
}
