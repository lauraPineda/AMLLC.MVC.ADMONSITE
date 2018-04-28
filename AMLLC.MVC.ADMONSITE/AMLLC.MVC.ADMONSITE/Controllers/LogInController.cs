using AMLLC.CORE.ENTITIES;
using AMLLC.CORE.ENTITIES.DB;
using AMLLC.CORE.ENTITIES.Login;
using AMLLC.MVC.ADMONSITE.Models;
using AMLLC.MVC.APICLIENT;
using AMLLC.MVC.COMMON;
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
            var response = new ResponseDTO<LoginResponseDTO>();
            var caller = new LoginCaller();
            bool redirect = false;

            try
            {
                if (ModelState.IsValid)
                {
                    response = caller.GetLogin(new UserDTO() { UserName = model.sUser, Password = model.sPassword });
                    model.Message = (response.Success) ? string.Empty : response.Message;
                    redirect = (response.Success && response.Result.IsAuthenticated) ? true : false;
                }
            }
            catch (System.Exception exception)
            {
                model.Message = Key.GetError();
            }

            if (redirect)
            {
                return RedirectToAction("Administrator", "Menu");
            }
            return View(model);
        }

        public ActionResult Worker()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Worker(WorkerLogIn model)
        {
            return RedirectToAction("Register", "Assistance");
        }
    }
}