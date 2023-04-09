using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RobotnaFinalPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Controllers
{
    public class CoursesController : Controller
    {
        private RobotnaDbContext db;
        public CoursesController(RobotnaDbContext _db)
        {
            db = _db;
        }
        // GET: CoursesController
        public ActionResult Index()
        {
            return View(db.Courses);
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            var data = db.Courses.Find( id);
            return View(data);
        }

        // GET: CoursesController/Create
        public ActionResult Create()
        {
            ViewBag.VenuId=  new SelectList(db.Venus, "VenuId", "VenuName");
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course courses)
        {
            ViewBag.VenuId = new SelectList(db.Venus, "VenuId", "VenuName");
            db.Courses.Add(courses);
            return View();
            }
        

        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = db.Courses.Find(id);
            ViewBag.VenuId = new SelectList(db.Venus, "VenuId", "VenuName");
            return View(data);
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course course)
        {
            ViewBag.VenuId = new SelectList(db.Venus, "VenuId", "VenuName");

            db.Courses.Update(course);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
        

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = db.Courses.Find(id);
            return View(data);
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Course course)

        {
            var data = db.Courses.Find(course.CourseId);
            db.Courses.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
