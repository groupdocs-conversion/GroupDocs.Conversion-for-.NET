using System.Web.Routing;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;
using GroupDocsConversionMVCDemo;

namespace GroupdocsConversionMVCDemo
{

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // set license file path here (if you have any)
        }
    }
}