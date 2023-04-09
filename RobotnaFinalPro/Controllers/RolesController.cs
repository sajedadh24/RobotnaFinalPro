using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RobotnaFinalPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Controllers
{
    public class RolesController : Controller
    {
        private RobotnaDbContext db;
        public RolesController(RobotnaDbContext _db)
        {
            db = _db;
        }
        // GET: CoursesController
        public ActionResult Index()
        {
            return View(db.Roles);
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            var data = db.Roles.Find(id);
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
        public ActionResult Create(Role role)
        {
            db.Roles.Add(role);
            return View();
        }


        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = db.Roles.Find(id);
            return View(data);
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Role role)
        {

            db.Roles.Update(role);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = db.Roles.Find(id);
            return View(data);
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Role role)

        {
            var data = db.Roles.Find(role);
            db.Roles.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
