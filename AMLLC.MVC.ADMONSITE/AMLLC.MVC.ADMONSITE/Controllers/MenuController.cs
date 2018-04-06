using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class MenuController : CustomLanguageController
    {
        [HttpGet]
        public ActionResult Administrator()
        {
            return View();
        }
    }
}