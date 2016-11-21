using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            //Exercise 1 - Course 6
            routes.MapRoute(
                name: "Project",
                url: "Project/doanaction",
                defaults: new { Controller = "Project", Action = "doanaction", name = UrlParameter.Optional }
                );

            //Exercise 5 - Course 6
            routes.MapRoute(
                name: "Projectalpha",
                url: "Project/{alpha}",
                defaults: new { Controller = "Project", Action = "hellouser", alpha = UrlParameter.Optional }
                );

            //Exercise 9 - Course 6
            //routes.MapRoute(
            //   name: "Project",
            //   url: "Project",
            //   defaults: new { Controller = "Home", Action = "About", name = UrlParameter.Optional }
            //   );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
