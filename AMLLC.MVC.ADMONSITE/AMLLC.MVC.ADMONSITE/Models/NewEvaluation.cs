using System;
using System.Collections.Generic;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class NewEvaluation
    {
        public int IdUserEvaluation { get; set; }
        public string UserName { get; set; }
        public List<UInt16> IdParamEval { get; set; }
        public List<UInt16> IdEvaluation { get; set; }
    }
}