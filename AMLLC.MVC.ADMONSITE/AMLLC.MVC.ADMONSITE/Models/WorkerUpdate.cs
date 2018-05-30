using AMLLC.MVC.ADMONSITE.App_GlobalResources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class WorkerUpdate
    {
        [HiddenInput(DisplayValue = false)]
        public int idWorker { get; set; }

        [Required]
        [Range(1,int.MaxValue,ErrorMessageResourceName = "SelectOption", ErrorMessageResourceType = typeof(Strings))]
        [Display(Name = "Client", ResourceType = typeof(Strings))]
        public List<SelectListItem> Client { get; set; }

        [ScaffoldColumn(false)]
        public int idClient { get; set; }

        [Display(Name = "Project", ResourceType = typeof(Strings))]
        public List<SelectListItem> Project { get; set; }

        [ScaffoldColumn(false)]
        public int idProject { get; set; }

        [Display(Name = "Location", ResourceType = typeof(Strings))]
        public List<SelectListItem> Location { get; set; }

        [ScaffoldColumn(false)]
        public int idLocation { get; set; }

        [Display(Name = "Role", ResourceType = typeof(Strings))]
        public List<SelectListItem> Role { get; set; }

        [ScaffoldColumn(false)]
        public int idRole { get; set; }

        public string Message { get; set; }
    }
}