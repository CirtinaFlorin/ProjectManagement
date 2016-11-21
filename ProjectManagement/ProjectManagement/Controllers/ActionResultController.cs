using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProjectManagement.Controllers
{
    public class ActionResultController : Controller
    {


        //Exercise 8 - Course 6
        public ActionResult Index()
        {
            return Content("This message is sent from the Index action!");
        }

        public ActionResult RedirectPermanent() {
            return RedirectPermanent ("http://www.google.com");

        }

            public ActionResult RedirectToActionInTheSameController(){
               return RedirectToAction ("Index");
            }
        }
}