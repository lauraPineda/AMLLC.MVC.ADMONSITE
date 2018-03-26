using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class EvaluationController : CustomLanguageController
    {
        // GET: Evaluation
        public ActionResult New()
        {
            return View();
        }
    }
}