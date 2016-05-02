using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using GroupDocs.Conversion.Config;
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

        public JsonResult CheckProgress(string guid)
        {
            if (System.Web.HttpContext.Current.Cache[guid] == null)
                return null;
            var manager = (ConversionManager)System.Web.HttpContext.Current.Cache[guid];

            return Json(new { manager.Progress, manager.Status }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BeginConvert(string inputFile, string outputFileType)
        {
            try
            {
                ConvertModel model = new ConvertModel();
                model.storagePath = Server.MapPath("~/App_Data/");
                model.cachePath = Server.MapPath("~/App_Data/output/");

                ConversionManager conversionManager = new ConversionManager(model);
                System.Web.HttpContext.Current.Cache[conversionManager.Guid] = conversionManager;
                Task.Factory.StartNew(() => conversionManager.Convert(inputFile, outputFileType));

                return Json(new { conversionManager.Guid });
            }
            catch
            {
                throw new ArgumentException("Output file type was not recognized");
            }
        }

        public void Download(string guid)
        {

            if (System.Web.HttpContext.Current.Cache[guid] == null)
                return;

            var manager = (ConversionManager)System.Web.HttpContext.Current.Cache[guid];
            var fileName = Path.GetFileName(manager.ResultPath);
            var response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.ContentType = Path.GetExtension(fileName).Replace(".", "");
            response.AddHeader("Content-Disposition", "attachment; filename=" + fileName + ";");
            response.TransmitFile(manager.ResultPath);
            response.Flush();
            response.End();
        }
    }
}
