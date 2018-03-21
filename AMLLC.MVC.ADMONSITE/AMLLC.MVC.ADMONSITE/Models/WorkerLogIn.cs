using AMLLC.MVC.ADMONSITE.App_GlobalResources;
using System.ComponentModel.DataAnnotations;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class WorkerLogIn
    {
        [Required]
        [Display(Name = "User", ResourceType = typeof(Strings))]
        public string sUser { get; set; }
    }
}