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
    public class AccountController : Controller
    {
        private RobotnaDbContext db;
        public AccountController(RobotnaDbContext _db)
        {
            db = _db ;      
        }
        public IActionResult Register()
        {
            ViewBag.RolesList = new SelectList(db.Roles, "RoleId", "RoleName");
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Login");

        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(User user) {
            {

                var Chuser = db.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password);
                if (Chuser.Any())
                {
                    HttpContext.Session.SetString("uName",user.UserName);
                    return RedirectToAction("Index", "Dashboard");
                }
                ViewBag.err = "Invalid user or pass ";
                return View(user);
            }


        }







    }
}
