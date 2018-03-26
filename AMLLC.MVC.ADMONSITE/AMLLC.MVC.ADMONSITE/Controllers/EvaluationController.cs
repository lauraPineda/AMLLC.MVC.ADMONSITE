using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class EvaluationController : CustomLanguageController
    {
        // GET: Evaluation
        public ActionResult Index()
        {
            return View();
        }
    }
}