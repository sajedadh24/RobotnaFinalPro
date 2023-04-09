using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Enter RoleName ")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

    }
}
