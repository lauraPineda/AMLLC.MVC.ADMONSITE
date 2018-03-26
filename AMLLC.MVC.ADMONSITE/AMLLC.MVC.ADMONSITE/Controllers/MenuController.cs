using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class MenuController : CustomLanguageController
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
    }
}