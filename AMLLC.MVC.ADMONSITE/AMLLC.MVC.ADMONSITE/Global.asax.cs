using System.Web.Mvc;
using System.Web.Routing;

namespace AMLLC.MVC.ADMONSITE
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            App_Start.BundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);
            System.Web.Optimization.BundleTable.EnableOptimizations = true;
        }
    }
}
