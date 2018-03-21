using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AMLLC.MVC.ADMONSITE.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region SkeletonLayout
            bundles.Add(new StyleBundle("~/bundles/LogIn/Css").Include(
                "~/Content/Library/Bootstrap/bootstrap.css",
                "~/Content/OwnLibrary/Login/Common.css",
                "~/Content/OwnLibrary/Login/LogIn.css",
                "~/Content/Library/fontAwesome/font-awesome-min.css"
                ));
            #endregion
        }
    }
}