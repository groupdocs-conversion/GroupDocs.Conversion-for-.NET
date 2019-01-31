//ExStart:ConversionManagerWithInterfaceClass
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Handler;
using GroupDocs.Conversion.Options.Save;

namespace GroupDocs.Conversion.Examples.CSharp
{
    public class ConversionManager : IConversionProgressListener, IConversionStatusListener
    {
        private readonly ConversionHandler _conversionHandler;
        public ConversionManager(string path)
        {
            _conversionHandler = Common.getConversionHandler();
            _conversionHandler.SetConversionProgressListener(this);
            _conversionHandler.SetConversionStatusListener(this);
        }
        public void ConversionProgressChanged(ConversionProgressEventArgs args)
        {
            Console.WriteLine("Conversion progress: {0} %", args.Progress);
        }
        public void ConversionStatusChanged(ConversionEventArgs args)
        {
            Console.WriteLine("Conversion status changed to: {0}", args.Status);
        }
        public string Convert(string file)
        {
            
            var convertedDocumentPath =_conversionHandler.Convert(file, new PdfSaveOptions());
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");
            return "result-" + Common.inputGUIDFile + ".pdf";
        }
    }
}
//ExEnd:ConversionManagerWithInterfaceClass
