using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class ReportController : CustomLanguageController
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
    }
}