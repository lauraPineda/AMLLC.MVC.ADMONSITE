using AMLLC.MVC.ADMONSITE.App_GlobalResources;
using System.ComponentModel.DataAnnotations;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class SupervisorLogIn
    {
        [Required]
        [Display(Name = "User", ResourceType = typeof(Strings))]
        public string sUser { get; set; }
        [Required]
        [Display(Name = "Password", ResourceType = typeof(Strings))]
        public string sPassword { get; set; }
        public string Message { get; set; }

    }
}