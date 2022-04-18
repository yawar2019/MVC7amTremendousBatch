using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC7amTremendousBatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("new/Welcome");

            routes.MapMvcAttributeRoutes();

            //default/aboutus
             routes.MapRoute(
              name: "xyz",
              url: "pistahouse/cake",//seo
              defaults: new { controller = "Default", action = "AboutUs", id = UrlParameter.Optional }
          );




            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",//404 error
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

          

        }
    }
}
