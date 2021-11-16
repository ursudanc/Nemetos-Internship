using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Company.Data.Models;


namespace MyWebApp.Controllers
{
    public class AboutUsController : Controller
    {
        private MyWebAppEntities2 db = new MyWebAppEntities2();
        // GET: AboutUs
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Social);
            return View(employees.ToList());
        }
        public ActionResult About_us_Title()
        {
            return View();
        }
        public ActionResult About_us_Body()
        {
            return View();
        }
        public ActionResult About_us_Company()
        {
            return View();
        }


    }
}