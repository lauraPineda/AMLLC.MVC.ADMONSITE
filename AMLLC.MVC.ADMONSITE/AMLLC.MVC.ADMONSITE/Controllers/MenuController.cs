using AMLLC.MVC.COMMON;
using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class MenuController : CustomLanguageController
    {

        [HttpGet]
        public ActionResult Administrator()
        {
            ViewBag.LoginUser = SessionVar.GetLoginUser();
            return View();
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            SessionVar.Clean();
            return RedirectToAction("Supervisor", "LogIn");
        }
    }
}