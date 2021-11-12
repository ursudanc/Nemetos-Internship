using Company.Data.Models;
using Company.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class AdminController : Controller
    {
       private readonly ICompanyData db;
        public AdminController(ICompanyData db)
        {
            this.db = db;
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorize(User usermodel)
        {
            using(MyWebAppEntities1 db=new MyWebAppEntities1())
            {
                var userDetails = db.Users.Where(x => x.Username == usermodel.Username && x.Password == usermodel.Password).FirstOrDefault();
                if(userDetails==null)
                {
                    usermodel.LoginErrorMessage = "Wrong Username or Password. ";
                    return View("Login",usermodel);
                }
                else
                {
                    Session["UserID"] = userDetails.UserID;
                    return RedirectToAction("Index");
                }
            }
           
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        public ActionResult Details(int id)
        {

            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
       [ HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {

            if (ModelState.IsValid)
            {
               
                
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var model = db.Get(Id);
            if (model == null)
                return View("Not Found");
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Update(employee);
                TempData["Message"] = "You have saved the restaurant!";
                return RedirectToAction("Details");
            }
            return View(employee);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if (model == null)
                return View("NotFound");
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }


    }
}