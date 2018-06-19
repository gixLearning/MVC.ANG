using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC.ANG {
    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular/angular.js",
                "~/Scripts/angular/angular-route.js"
                ));
            //bundles.Add(new ScriptBundle("~/app").Include(
            //    "~/Scripts/ng-modules/app.js"
            //    ));
        }
    }
}