using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using MVC.ANG.DataContexts;
using MVC.ANG.DataContexts.Initializers;

namespace MVC.ANG
{
    public class MvcApplication : HttpApplication {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer<PeopleDBContext>(new PeopleDBInitializer());
        }
    }
}
