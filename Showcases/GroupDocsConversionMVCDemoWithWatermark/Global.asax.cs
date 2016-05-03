using System.Web.Routing;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;
using GroupDocsConversionMVCDemoWithWatermark;

namespace GroupDocsConversionMVCDemoWithWatermark
{

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}