using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManikantaK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Skills()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult BasicDetails()
        {
            return View();
        }

        public ActionResult Hobbies()
        {
            return View();
        }

     /*   public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}