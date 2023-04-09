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
    public class UsersController : Controller
    {
        private RobotnaDbContext db;
        public UsersController(RobotnaDbContext _db)
        {
            db = _db;
        }
        // GET: CoursesController
        public ActionResult Index()
        {
            return View(db.Users);
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            var data = db.Users.Find(id);
            return View(data);
        }

        // GET: CoursesController/Create
        public ActionResult Create()
        {
            ViewBag.RolesList = new SelectList(db.Roles, "RoleId", "RoleName");
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            ViewBag.RolesList = new SelectList(db.Roles, "RoleId", "RoleName");
            db.Users.Add(user);
            return View();
        }


        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = db.Users.Find(id);
            ViewBag.RolesList = new SelectList(db.Roles, "RoleId", "RoleName");
            return View(data);
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            ViewBag.RolesList = new SelectList(db.Roles, "RoleId", "RoleName");

            db.Users.Update(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = db.Users.Find(id);
            return View(data);
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(User user)

        {
            var data = db.Users.Find(User);
            db.Users.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
