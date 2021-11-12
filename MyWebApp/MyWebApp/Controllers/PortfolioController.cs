using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Title()
        {
            return View();
        }
        public ActionResult Imgs()
        {
            return View();
        }
    }
}