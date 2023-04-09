using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RobotnaFinalPro.Models;
using RobotnaFinalPro.Models.ViewData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Controllers
{
    public class HomeController : Controller
    {
        private RobotnaDbContext db;
        public HomeController(RobotnaDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            InCoViewModel model = new InCoViewModel
            {
                Courses = db.Courses.Include(x=>x.Venu).ToList(),
                instructors=db.instructors.ToList(),
                
                Roles = db.Roles.ToList()


            };
            return View(model);
        }
    }
}
