using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CompanyABC.TreeView.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
                name: "Tree",
                url: "tree/{treeDepth}",
                defaults: new { controller = "Home", action = "Index", treeDepth = UrlParameter.Optional }
            );
        }
    }
}