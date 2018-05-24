using AMLLC.MVC.COMMON;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AMLLC.MVC.ADMONSITE
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Session_Start(Object sender, EventArgs e)
        {
            SessionVar.GetInstance(HttpContext.Current);
        }

        protected void Application_Start()
        {   
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            App_Start.BundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);
            System.Web.Optimization.BundleTable.EnableOptimizations = true;
        }
    }
}
