using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        { 

            var model = new AboutModel();
            model.Message = "Hello";
            model.Author = "CF";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public double medie () {
            var list = new List<int> { 1, 3, 7};
            // return list.Average();
            int sum = 0;
           foreach (int i in list){
                sum += i;

            }
            return sum / list.Count();
        }

        public ActionResult HelloWorld() {
            return Content("Hello World!");
        }

    }
}