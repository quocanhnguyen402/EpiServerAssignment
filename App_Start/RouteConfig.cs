using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Assignment_EpiServer
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Country",
                url: "country-summary/{country_slug}/{country_code}",
                defaults: new
                {
                    controller = "Home",
                    action = "Country",
                    country = UrlParameter.Optional, 
                    country_slug = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home", 
                    action = "Index", 
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
