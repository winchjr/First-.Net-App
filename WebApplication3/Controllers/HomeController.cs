using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult UserRegistration()
        {
            ViewBag.Message = "Please enter the following information to sign up.";
            return View();
        }

        public ActionResult Summary(Models.Register r)
        {
            ViewBag.Message = "Your name is " + r.FirstName;
            ViewBag.Message += " ";

            ViewBag.Message += "Your email is " + r.Email;
            ViewBag.Message += " ";
            ViewBag.Message += "Your gender is" + r.Gender;
        return View(r);
        }

    }
}