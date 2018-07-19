using FloGestionSalles.Data;
using FloGestionSalles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FloGestionSalles.Utils;


namespace FloGestionSalles.Controllers
{
    public class UsersController : Controller
    {
        private RoomyDbContext db = new RoomyDbContext();
        // GET: Users
        [HttpGet]
        public ActionResult Create()
        {           
           ViewBag.Civilities = db.Civilities.ToList();
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            
            if (ModelState.IsValid)
            {
                db.Configuration.ValidateOnSaveEnabled = false;
                user.Password = user.Password.HashMD5();
                db.Users.Add(user);
                db.SaveChanges();
            }
            ViewBag.Civilities = db.Civilities.ToList();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


    }
}