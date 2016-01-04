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
        public static string storagePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\SampleFiles");
        public static string cachePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\OutputFiles");
        public static string licensePath = Path.Combine(Environment.CurrentDirectory, @"GroupDocs.conversion.lic");
        public static string inputGUIDFile = "DOCXsample.docx";

        private static ConversionConfig conversionConfig = new ConversionConfig { StoragePath = storagePath, CachePath = cachePath };
        private static ConversionHandler conversionHandler = new ConversionHandler(conversionConfig);

        //ExEnd:CommonProperties

        /// <summary>
        /// Get GroupDocs.Conversion Handler Object
        /// </summary>
        /// <returns></returns>
        public static ConversionHandler getConversionHandler()
        {
            return conversionHandler;
        }


        //ExStart:ApplyLicense
        /// <summary>
        /// Applies product license
        /// </summary>
        public static void ApplyLicense()
        {
            // apply license
            conversionHandler.SetLicense(licensePath);
        }
        //ExEnd:ApplyLicense
    }
}
