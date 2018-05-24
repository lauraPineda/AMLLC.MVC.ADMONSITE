using AMLLC.MVC.ADMONSITE.App_GlobalResources;
using System.ComponentModel.DataAnnotations;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class WorkerUpdate
    {
        [Display(Name = "Worker ID")]
        public int idWorker { get; set; }

        [Display(Name = "Project", ResourceType = typeof(Strings))]
        public uint IdCompany { get; set; }
        public string Message { get; set; }
    }
}