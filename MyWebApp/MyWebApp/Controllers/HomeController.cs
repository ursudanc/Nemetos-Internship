using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Slider()
        {
            return View();
        }
        public ActionResult secComp()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Work()
        {
            return View();
        }
        public ActionResult Clients()
        {
            return View();
        }   

    }
}