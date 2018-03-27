using AMLLC.MVC.ADMONSITE.App_GlobalResources;
using System;
using System.ComponentModel.DataAnnotations;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class Assistance
    {

        public string sWorkerName { get; set; }

        public Boolean hasTodayAssisteance { get; set; }

    }
}