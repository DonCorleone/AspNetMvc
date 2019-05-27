using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using mvc;

namespace mvc
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
