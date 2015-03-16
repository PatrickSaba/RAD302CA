using RadCA_s00130053.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RadCA_s00130053.Controllers
{
    public class HomeController : Controller
    {
        public CountryDb db = new CountryDb();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(db.Countries);
        }
    }
}
