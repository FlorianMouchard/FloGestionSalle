using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FloGestionSalles.Areas.BackOffice.Models;
using FloGestionSalles.Data;
using FloGestionSalles.Filters;
using FloGestionSalles.Utils;

namespace FloGestionSalles.Areas.BackOffice.Controllers
{
    public class AuthenticationController : Controller
    {
        private RoomyDbContext db = new RoomyDbContext();
        // GET: BackOffice/Authentication
        public ActionResult Login()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(AuthenticationLoginViewModels model)
        {
            if (ModelState.IsValid)
            {
                var passwordHash = model.Password.HashMD5();
                var user = db.Users.SingleOrDefault(x => x.Mail == model.Login && x.Password == passwordHash);
                if (user == null)
                {
                    //ModelState.AddModelError("", "Utilisateur ou mot de passe incorrect");
                    ViewBag.ErrorMessage = "Utilisateur ou mot de passe incorrect";
                    return View(model);
                }
                else
                {
                    Session.Add("USER_BO", user);
                    return RedirectToAction("Index", "Dashboard", new { area = "BackOffice" });
                }
                
            }
            return View(model);
        }

        // GET: BackOffice/Authentication/Logout
        [AuthenticationFilter]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}