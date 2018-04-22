using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class ManageWorkerController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }


    }
}