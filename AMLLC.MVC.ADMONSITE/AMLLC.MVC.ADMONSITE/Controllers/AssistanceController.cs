using System.Web.Mvc;
using AMLLC.MVC.ADMONSITE.Models;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class AssistanceController : CustomLanguageController
    {
        // GET: Assistance
        public ActionResult Register()
        {
            Assistance assistance = new Assistance();
            assistance.sWorkerName = "TEST TEST";
            assistance.hasTodayAssisteance = false;
            return View(assistance);
        }

        [HttpPost]
        public ActionResult Register(Assistance model)
        {
            model.hasTodayAssisteance = true;
            return View(model);
        }
    }
}