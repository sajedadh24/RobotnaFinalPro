using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        [Required]
        [Display(Name = "Instructor Name")]
        public string  InstructorName { get; set; }
        [Required]
        public string  Position { get; set; }
        [Required]
        public string  FbUrl { get; set; }
        public string  InstructorImg { get; set; }
    }
}
