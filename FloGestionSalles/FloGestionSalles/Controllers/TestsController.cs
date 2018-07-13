using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FloGestionSalles.Controllers
{
    public class TestsController : Controller
    {
        // GET: Tests
        public ActionResult Index()
        {
            List<string> prenoms = new List<string>
            {
                "Gary", "Florian", "Nico"
            };
            return View(prenoms);
        }
    }
}