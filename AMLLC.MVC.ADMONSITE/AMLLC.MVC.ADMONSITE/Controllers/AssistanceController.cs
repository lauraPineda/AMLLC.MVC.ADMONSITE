using System.Web.Mvc;
using AMLLC.MVC.ADMONSITE.Models;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class AssistanceController : CustomLanguageController
    {
        // GET: Assistance
        public ActionResult Register()
        {
            Assistance asistance = new Assistance();

            return View();
        }
    }
}