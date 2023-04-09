using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Models.ViewData
{
    public class InCoViewModel
    {
        public IList <Instructor > instructors{ get; set; }
        public IList <Role> Roles{ get; set; }
        public IList <Course> Courses { get; set; }
    }
}
