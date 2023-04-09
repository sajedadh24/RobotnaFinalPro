using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage ="الرجاء إدخال إسم الدورة")]
        [Display (Name = "Course Name")]
        public string CourseName { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Staet Time ")]
        public DateTime StaetDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Staet  Date ")]
        public DateTime StaetTime { get; set; }
        [Required(ErrorMessage = "الرجاء إدخال وصف الدورة")]
        [Display(Name = "Course Description")]
        public string CourseDesc { get; set; }
        public decimal Price { get; set; }

        public string  Img { get; set; }
        public int VenuId { get; set; }
        public Venu Venu { get; set; }

    }
}
