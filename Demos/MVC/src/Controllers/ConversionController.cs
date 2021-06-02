using System.Web.Mvc;

namespace GroupDocs.Conversion.MVC.Controllers
{
    /// <summary>
    /// Viewer Web page controller
    /// </summary>
    public class ConversionController : Controller
    {       
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}