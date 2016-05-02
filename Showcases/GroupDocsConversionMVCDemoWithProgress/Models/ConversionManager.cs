using System;
using System.Collections.Generic;
using GroupDocs.Conversion;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;

namespace GroupDocsConversionMVCDemoWithProgress.Models
{
    public class ConversionManager : IConversionProgressListener, IConversionStatusListener
    {
        private readonly ConversionHandler _conversionHandler;

        public ConversionManager(ConvertModel model)
        {
            var conversionConfig = new ConversionConfig { StoragePath = model.storagePath, CachePath = model.cachePath };
            _conversionHandler = new ConversionHandler(conversionConfig);
            _conversionHandler.SetConversionProgressListener(this);
            _conversionHandler.SetConversionStatusListener(this);

            // Apply GroupDocs.Conversion license using license path provided/set in licensePath property
            if (string.IsNullOrEmpty(model.licensePath))
            {
                License license = new License();
                license.SetLicense(model.licensePath);
            }

            Guid = System.Guid.NewGuid().ToString("N");
        }

        public string Guid { get; private set; }

        public void ConversionProgressChanged(ConversionProgressEventArgs args)
        {
            Progress = args.Progress;
        }

        public void ConversionStatusChanged(ConversionEventArgs conversionStatus)
        {
            Status = conversionStatus.Status.ToString();
        }

        public string Status { get; private set; }

        public int Progress { get; private set; }

        public string ResultPath { get; private set; }

        public void Convert(string file, string toFormat)
        {
            var options = _conversionHandler.GetSaveOptions(toFormat)[toFormat];
            options.OutputType=OutputType.String;
            if (options is ImageSaveOptions)
            {
                ResultPath = _conversionHandler.Convert<List<String>>(file, options)[0];
            }
            else
            {
                ResultPath = _conversionHandler.Convert<string>(file, options);
            }
        }
    }
}