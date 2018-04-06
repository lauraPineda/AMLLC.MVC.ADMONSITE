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
            var random = new System.Random();
            string[] NameList = new string[] { "Jorge", "Alejandro", "Pedro", "Arnold", "Santiago", "Sara" };
            string[] LastNList = new string[] { "Pérez", "Martínez", "Petronilo", "Sosa"};
            for (int x = 0; x <= NameList.Length - 1; x++)
            {
                var numeroN = random.Next(NameList.Length - 1);
                var numeroL = random.Next(LastNList.Length - 1);
                userList.Add(new User
                {
                    IdUser = x,
                    UserName = NameList[numeroN] + " " + LastNList[numeroL]
                });
            }
            return View(new WorkersEvalutation() { UserList = userList });
        }

        [HttpGet]
        public ActionResult New(User data)
        {
            List<Parameter> paramList = new List<Parameter>();
            List<EvaluationStatus> evalList = new List<EvaluationStatus>();
            paramList.Add(new Parameter {IdParamEval = 1, Name = "Asistencia"});
            paramList.Add(new Parameter {IdParamEval = 2, Name = "Cuidado de equipo" });
            paramList.Add(new Parameter {IdParamEval = 3, Name = "Disposición" });

            evalList.Add(new EvaluationStatus { IdEvaluation = 1, Name = "SI" });
            evalList.Add(new EvaluationStatus { IdEvaluation = 2, Name = "NO" });

            return View(new NewEvaluation { IdUserEvaluation = data.IdUser
                                          , UserName = data.UserName
                                          , ParamEval = paramList
                                          , Evaluation = evalList });
        }
    }
}