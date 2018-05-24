using DLL = AMLLC.CORE.ENTITIES;
using AMLLC.MVC.ADMONSITE.Models;
using System.Web.Mvc;
using AMLLC.MVC.BUSINESS;
using AMLLC.MVC.COMMON;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class ManageWorkerController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(WorkerInfo model)
        {
            var response = new DLL::ResponseDTO<int>();
            var caller = new UserCaller();
            bool redirect = false;

            try
            {
                if (ModelState.IsValid)
                {
                    var request = new CORE.ENTITIES.User.UserRequestDTO()
                    {
                        User = new DLL.DB.UserDTO() { UserName = model.UserName, Password = model.Password },
                        Info = new DLL.DB.InfoDTO() { Name = model.Name, LastName = model.LastName, Telephone = (model.HasTelephone) ? model.Telephone : string.Empty }
                    };
                    response = caller.AddUser(request);
                    model.Message = (response.Success) ? string.Empty : response.Message;
                    redirect = (response.Success && response.Result > 0) ? true : false;
                }
            }
            catch (System.Exception)
            {
                //Falta implementar el log **********
                model.Message = Key.GetError();
            }

            if (redirect)
            {
                ViewBag.WorkerID = response.Result;
                return RedirectToAction("Update");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }


    }
}