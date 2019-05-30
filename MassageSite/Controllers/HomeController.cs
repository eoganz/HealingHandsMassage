using MassageSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;

namespace MassageSite.Controllers
{
    public class HomeController : Controller
    {
        UserContext context = new UserContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Title = "Login Page";
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            return View(user);
        }
        
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }
        
        
        [HttpPost]
        public ActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                context.Users.Add(user);
                var count = context.SaveChanges();
                
                Console.WriteLine("{0} records saved to database", count);

            }

            return View(user);
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }

        public ActionResult ListAllUsers()
        {
            return View();
        }
    }
}