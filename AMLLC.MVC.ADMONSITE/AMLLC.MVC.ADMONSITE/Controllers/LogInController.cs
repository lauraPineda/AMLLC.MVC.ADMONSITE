using AMLLC.MVC.ADMONSITE.Models;
using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class LogInController : CustomLanguageController
    {
        // GET: LogIn
        public ActionResult Supervisor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Supervisor(SupervisorLogIn model)
        {
            return View();
        }

        public ActionResult Worker()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Worker(WorkerLogIn model)
        {
            return View();
        }
    }
}