using System.Web.Optimization;

namespace AMLLC.MVC.ADMONSITE.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region CSS
            bundles.Add(new StyleBundle("~/bundles/LogIn/Css").Include(
                "~/Content/Library/Bootstrap/bootstrap.css",
                "~/Content/OwnLibrary/Login/Common.css",
                "~/Content/OwnLibrary/Login/LogIn.css",
                "~/Content/Library/fontAwesome/font-awesome-min.css"
                ));

            bundles.Add(new StyleBundle("~/bundles/Layout/Css").Include(
                "~/Content/Library/Bootstrap/bootstrap.css",
                "~/Content/OwnLibrary/Login/Common.css",
                "~/Content/Library/fontAwesome/font-awesome-min.css"
                ));
            #endregion

            #region JS
            bundles.Add(new ScriptBundle("~/bundles/Layout/Js").Include(
                "~/Content/Library/jQuery/jquery-3.1.1-min.js"
                ));
            #endregion
        }
    }
}