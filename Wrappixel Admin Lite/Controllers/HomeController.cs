using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wrappixel_Admin_Lite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BootstrapTables()
        {
            return View();
        }

        public ActionResult Animation()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult GoogleMap()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Blank()
        {
            return View();
        }

        public ActionResult FontAwesome()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}