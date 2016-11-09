using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Scenarios()
        {
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Surveys()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calculator()
        {
            return View();
        }
    }
}