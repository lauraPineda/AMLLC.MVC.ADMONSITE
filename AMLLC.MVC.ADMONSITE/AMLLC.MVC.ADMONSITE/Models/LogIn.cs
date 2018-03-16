using AMLLC.MVC.ADMONSITE.App_GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AMLLC.MVC.ADMONSITE.Models
{
    public class LogIn
    {
        [Required]
        [Display(Name = "User", ResourceType = typeof(Strings))]
        public string sUser { get; set; }
        [Required]
        [Display(Name = "Password", ResourceType = typeof(Strings))]
        public string sPassword { get; set; }

    }
}