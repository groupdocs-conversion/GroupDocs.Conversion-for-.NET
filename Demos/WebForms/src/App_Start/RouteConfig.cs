using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace GroupDocs.Conversion.WebForms
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute(
             "Conversion",
             "",
             "~/Conversion.aspx"
         );
        }
    }
}
