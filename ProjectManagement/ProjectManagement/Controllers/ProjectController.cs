using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        //Exercise 2 - Course 6
        public ActionResult doanaction() {
            return Content("Hello World!");
        }
        
        //Exercise 6-7 - Course 6
        public ActionResult hellouser(string alpha)
        {
            var encoded_alpha = Server.HtmlEncode(alpha);
            return Content("Hello:" + encoded_alpha);
         
        }
    }
}