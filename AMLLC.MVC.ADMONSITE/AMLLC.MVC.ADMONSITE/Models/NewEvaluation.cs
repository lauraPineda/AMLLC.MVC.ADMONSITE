using AMLLC.MVC.COMMON.Temporal;
using System.Collections.Generic;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class NewEvaluation
    {
        public int IdUserEvaluation { get; set; }
        public string UserName { get; set; }
        public List<Parameter> ParamEval { get; set; }
        public List<EvaluationStatus> Evaluation { get; set; }
    }
}