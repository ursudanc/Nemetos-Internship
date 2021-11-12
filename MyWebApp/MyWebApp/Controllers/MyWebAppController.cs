using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class MyWebAppController : Controller
    {
        // GET: MyWebApp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About_us()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Portfolio()
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }
        public ActionResult Contact_us()
        {
            return View();
        }
    }

}
