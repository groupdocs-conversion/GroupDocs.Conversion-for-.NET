using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;
using GroupDocsConversionMVCDemoWithProgress.Models;

namespace GroupDocsConversionMVCDemoWithProgress.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index(ConvertModel model)
        {
            model.storagePath = Server.MapPath("~/App_Data/");
            model.cachePath = Server.MapPath("~/App_Data/output/");
            ConversionConfig conversionConfig = new ConversionConfig { StoragePath = model.storagePath, CachePath = model.cachePath };
            ConversionHandler conversionHandler = new ConversionHandler(conversionConfig);
            // your input file to be converted
            model.inputGUIDFile = "DOCXsample.docx";
            var availableConversions = conversionHandler.GetSaveOptions(Path.GetExtension(model.inputGUIDFile).Replace(".", ""));
            ConvertModel.AvailableFileTypes = from fileType in availableConversions
                                              select new SelectListItem { Text = fileType.Key.ToString(), Value = fileType.Key.ToString() };
            return View(model);
        }

        private void ConversionProgressHandler(object sender, ConversionProgressEventArgs args)
        {
            //Console.WriteLine("Conversion progress: {0}", args.Progress);
        }

        public string CheckProgress(string jobId)
        {
            if (System.Web.HttpContext.Current.Cache[jobId] == null)
                return null;
            var callbackData = (ConversionHandler)System.Web.HttpContext.Current.Cache[jobId];
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(callbackData);
        }

        public string BeginConvert(string inputFile, string outputFileType)
        {
            try
            {
                ConvertModel model = new ConvertModel();
                model.storagePath = Server.MapPath("~/App_Data/");
                model.cachePath = Server.MapPath("~/App_Data/output/");
                ConversionConfig conversionConfig = new ConversionConfig { StoragePath = model.storagePath, CachePath = model.cachePath };
                ConversionHandler conversionHandler = new ConversionHandler(conversionConfig);
                conversionHandler.ConversionProgress += ConversionProgressHandler;

                // Apply GroupDocs.Conversion license using license path provided/set in licensePath property
                //model.licensePath = Server.MapPath("~/App_Data/");
                //conversionHandler.SetLicense(model.licensePath);

                string outputFile = "converted\\SampleConverted." + outputFileType;

                var saveOptions = conversionHandler.GetSaveOptions(outputFileType)[outputFileType];
                saveOptions.OutputType = OutputType.String;

                string convertResults = conversionHandler.Convert<String>(inputFile, saveOptions);
                System.Web.HttpContext.Current.Cache[convertResults + "_instance"] = conversionHandler;
                //Download(convertResults, outputFileType);

                return convertResults;
            }
            catch
            {
                throw new ArgumentException("Output file type was not recognized");
            }
        }
        private void Download(string outputFileName, string outputfileType)
        {

            if (System.Web.HttpContext.Current.Cache[outputFileName + "_instance"] == null)
                return;

            var conversion = (ConversionHandler)System.Web.HttpContext.Current.Cache[outputFileName + "_instance"];
            var response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.ContentType = outputfileType;
            response.AddHeader("Content-Disposition", "attachment; filename=" + outputfileType + ";");
            response.TransmitFile(outputFileName);
            response.Flush();
            response.End();
        }
    }
}
