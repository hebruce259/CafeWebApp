using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffeshopapp.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProcessSignup(string Uname, string Email)
        {
            ViewBag.Message = "Thanks " + Uname + "(" + Email + ")";
            // return View("Index"); return View("Index");
            return Redirect("https://www.google.com");
        }
    }
}