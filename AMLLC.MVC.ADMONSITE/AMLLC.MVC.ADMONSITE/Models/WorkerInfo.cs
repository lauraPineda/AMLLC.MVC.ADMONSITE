using AMLLC.MVC.ADMONSITE.App_GlobalResources;
using System.ComponentModel.DataAnnotations;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class WorkerInfo
    {
        [Required]
        [Display(Name = "Name", ResourceType = typeof(Strings))]
        public string Name { get; set; }
        [Required]
        [Display(Name = "LastName", ResourceType = typeof(Strings))]
        public string LastName { get; set; }
        [Display(Name = "Telephone", ResourceType = typeof(Strings))]
        public string Telephone { get; set; }
        [Display(Name = "HasTelephone", ResourceType = typeof(Strings))]
        public bool HasTelephone { get; set; }
        [Required]
        [Display(Name = "User", ResourceType = typeof(Strings))]
        public string UserName { get; set; }
        [Display(Name = "Password", ResourceType = typeof(Strings))]
        public string Password { get; set; }
        [Display(Name = "Project", ResourceType = typeof(Strings))]
        public uint IdCompany { get; set; }
    }
}