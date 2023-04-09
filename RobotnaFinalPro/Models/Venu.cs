using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Models
{
    public class Venu
    {
        public int VenuId { get; set; }
        [Required(ErrorMessage = "Enter Venu Name")]
        [Display(Name = "Menu Venu Name")]
        public string VenuName { get; set; }
    }
}
