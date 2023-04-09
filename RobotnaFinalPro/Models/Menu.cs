using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Models
{
    public class Menu
    {
        public int MenuId{ get; set; }
        [Required(ErrorMessage = "Enter menu Title")]
        [Display(Name = "Menu Title")]

        public string MenuTitle { get; set; }
        [Required(ErrorMessage = "Enter menu URL")]
        [Display(Name = "Menu URL")]
        public string MenuUrl{ get; set; }
    }
}
