using AMMLC.MVC.COMMON.Temporales;
using System.Collections.Generic;
using System.Web.Mvc;
using AMLLC.MVC.ADMONSITE.Models;

namespace AMLLC.MVC.ADMONSITE.Controllers
{
    public class EvaluationController : CustomLanguageController
    {
        [HttpGet]
        public ActionResult Workers()
        {
            //Mock object
            List<User> userList = new List<User>();
            for(int x=1; x<=6; x++ )
            {
                userList.Add(new User
                {
                    IdUser = x,
                    UserName = "Worker " + x.ToString()
                });
            }
            return View(new WorkersEvalutation() { UserList = userList });
        }

        [HttpGet]
        public ActionResult New(User model)
        {
            List<Parameter> paramList = new List<Parameter>();
            List<EvaluationStatus> evalList = new List<EvaluationStatus>();
            paramList.Add(new Parameter {IdParamEval = 1, Name = "Asistencia"});
            paramList.Add(new Parameter {IdParamEval = 2, Name = "Cuidado de equipo" });
            paramList.Add(new Parameter {IdParamEval = 3, Name = "Disposición" });

            evalList.Add(new EvaluationStatus { IdEvaluation = 1, Name = "SI" });
            evalList.Add(new EvaluationStatus { IdEvaluation = 2, Name = "NO" });

            return View(new NewEvaluation { IdUserEvaluation = model.IdUser
                                          , UserName = model.UserName
                                          , ParamEval = paramList
                                          , Evaluation = evalList });
        }
    }
}