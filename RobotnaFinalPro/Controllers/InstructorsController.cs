using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RobotnaFinalPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Controllers
{
    public class InstructorsController : Controller
    {
        private RobotnaDbContext db;
        public InstructorsController(RobotnaDbContext _db)
        {
            db = _db;
        }
        // GET: CoursesController
        public ActionResult Index()
        {
            return View(db.instructors);
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            var data = db.instructors.Find(id);
            return View(data);
        }

        // GET: CoursesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instructor instructor)
        {
            db.instructors.Add(instructor);
            return View();
        }


        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = db.instructors.Find(id);
            return View(data);
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Instructor instructor)
        {

            db.instructors.Update(instructor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = db.instructors.Find(id);
            return View(data);
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Instructor instructor)

        {
            var data = db.instructors.Find(instructor);
            db.instructors.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
