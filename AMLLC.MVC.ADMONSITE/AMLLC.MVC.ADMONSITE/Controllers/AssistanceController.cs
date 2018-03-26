using AMLLC.MVC.ADMONSITE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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