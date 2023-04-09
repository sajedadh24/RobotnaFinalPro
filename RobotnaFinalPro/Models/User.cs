using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Enter User Name")]
        [Display(Name = "Menu User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Enter Password ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter Email ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}
