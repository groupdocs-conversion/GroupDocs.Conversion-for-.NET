using System;
using System.Web;
using System.Web.Routing;
using System.Web.Http;
using GroupDocs.Conversion.WebForms.AppDomainGenerator;

namespace GroupDocs.Conversion.WebForms
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Fix required to use several GroupDocs products in one project.
            // Set GroupDocs products assemblies names          
            string conversionAssemblyName = "GroupDocs.Conversion.dll";          
            // set GroupDocs.Conversion license
            DomainGenerator conversionDomainGenerator = new DomainGenerator(conversionAssemblyName, "GroupDocs.Conversion.License");
            conversionDomainGenerator.SetConversionLicense();

            // Code that runs on application startup
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }
    }
}