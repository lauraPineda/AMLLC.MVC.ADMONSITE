using DLL = AMLLC.CORE.ENTITIES;
using DLLS = AMLLC.CORE.SHARED;
using AMLLC.MVC.ADMONSITE.Models;
using System.Web.Mvc;
using AMLLC.MVC.BUSINESS;
using AMLLC.MVC.COMMON;
using System.Collections.Generic;
using AMLLC.MVC.ADMONSITE.App_GlobalResources;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class ManageWorkerController : Controller
    {
        enum Catalogs { None, Project, Location, Role };

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
            catch (System.Exception ex)
            {
                DLLS::ExceptionHandler.Instance.WriteExceptionLog(ex);
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
            SessionVar.SetLoginUser(new DLL.Login.LoginResponseDTO() { User = new DLL.DB.UserDTO() { UserName = "Borrame" } });
            var model = new WorkerUpdate() {
                Client = new List<SelectListItem>(),
                Project = new List<SelectListItem>(),
                Location = new List<SelectListItem>(),
                Role = new List<SelectListItem>()
            };
            model.Client.Add(new SelectListItem() { Text = Strings.SelectOption });

            try
            {
                var invoker = new Invoker<List<DLL::CatalogsDTO>, bool>(new CompanyCaller<List<DLL::CatalogsDTO>, bool>());
                var response = invoker.GetAll(new DLL::RequestDTO<bool>() { Signature = true });

                foreach (DLL::CatalogsDTO item in response.Result)
                {
                    model.Client.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
                }
            }
            catch (System.Exception ex)
            {
                DLLS::ExceptionHandler.Instance.WriteExceptionLog(ex);
                model.Message = Key.GetError();
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(WorkerUpdate model)
        {
            var response = new WorkerUpdate()
            {
                Client = new List<SelectListItem>(),
                Project = new List<SelectListItem>(),
                Location = new List<SelectListItem>(),
                Role = new List<SelectListItem>()
            };
            return View(response);
        }

        /// <summary>
        /// Método expuesto para filtrar y obtener catálogos.
        /// </summary>
        /// <param name="option"></param>
        /// <param name="idRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetCatalog(string option, int idRequest)
        {
            Catalogs optionRequest = Catalogs.None;
            switch (option)
            {
                case "Project" : optionRequest = Catalogs.Project; break;
                case "Location": optionRequest = Catalogs.Location; break;
                case "Role": optionRequest = Catalogs.Role; break;
            }

            return Json(GetSelectList(optionRequest, idRequest));
        }

        /// <summary>
        /// Método que obtiene los catálogos de proyecto, locación y rol. 
        /// En caso de error regresa la colección de datos con la leyenda "Error".
        /// </summary>
        /// <param name="option">Enum.</param>
        /// <param name="idRequest">Filtro de búsqueda.</param>
        private List<SelectListItem> GetSelectList(Catalogs option, int idRequest)
        {
            var result = new List<SelectListItem>();
            result.Add(new SelectListItem() { Text = Strings.SelectOption });
            try
            {
                switch (option)
                {
                    case Catalogs.Project:
                        var invokerProject = new Invoker<List<DLL::CatalogsDTO>, bool>(new CompanyCaller<List<DLL::CatalogsDTO>, bool>());
                        var responseProject = invokerProject.GetAll(new DLL::RequestDTO<bool>() { Signature = true });
                        foreach (DLL::CatalogsDTO item in responseProject.Result) { result.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() }); }
                        break;

                    case Catalogs.Location:
                        var invokerLocation = new Invoker<List<DLL::CatalogsDTO>, bool>(new CompanyCaller<List<DLL::CatalogsDTO>, bool>());
                        var responseLocation = invokerLocation.GetAll(new DLL::RequestDTO<bool>() { Signature = true });
                        foreach (DLL::CatalogsDTO item in responseLocation.Result) { result.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() }); }
                        break;

                    case Catalogs.Role:
                        var invokerRole = new Invoker<List<DLL::CatalogsDTO>, bool>(new CompanyCaller<List<DLL::CatalogsDTO>, bool>());
                        var responseRole = invokerRole.GetAll(new DLL::RequestDTO<bool>() { Signature = true });
                        foreach (DLL::CatalogsDTO item in responseRole.Result) { result.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() }); }
                        break;
                }
            }
            catch (System.Exception ex)
            {
                DLLS::ExceptionHandler.Instance.WriteExceptionLog(ex);
                result.Add(new SelectListItem() { Value = "0", Text = Key.GetError() });
            }
            return result;
        }

    }
}