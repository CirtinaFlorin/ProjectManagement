using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {

        public ActionResult doanaction() {
            return Content("Hello World!");
        }

        public ActionResult hellouser(string alpha)
        {
            var encoded_alpha = Server.HtmlEncode(alpha);
            return Content("Hello:" + encoded_alpha);
         
        }
    }
}