using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Configuration;
using System.Web.Configuration;
using System.Web.Security;

namespace MvcDemo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // http://localhost/scriptresource.axd/foo
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // http://localhost/Process/
            routes.MapRoute(
                "Process",
                "Process/{action}/{id}",
                new { controller = "Process", action = "List", id = "" }
            );

            // http://localhost/
            // http://localhost/home
            // http://localhost/HoMe/About/
            // http://localhost/PRocess/List/1/
            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );           
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);                               
        }
    }
}