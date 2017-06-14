using System.Web.Optimization;

namespace MobinorWeb
{
    public class BundleConfig
    {

        //private const string basePath = "~/Scripts/CityCallScripts";
        //private const string virtualPath = "~/Contents/templates/";
        
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular/angular.js",
                        "~/Scripts/ui-grid.js",
                        "~/Scripts/angular-route.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/lodash.js",
                        "~/Scripts/angular-ui/ui-bootstrap.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.js"));

            bundles.Add(new ScriptBundle("~/bundles/appendDirectives").Include(
                        "~/Scripts/CityCallScripts/app/app.js",
                          "~/Scripts/CityCallScripts/Admin/dailer/directives/dailerDetailsDirective.js"));

            bundles.Add(new ScriptBundle("~/bundles/appendServices").Include(
                     "~/Scripts/CityCallScripts/Admin/dailer/services/dailerDetailsService.js",
                      "~/Scripts/CityCallScripts/Admin/dailer/services/dailerDetailsFactory.js",
                     "~/Scripts/CityCallScripts/common/lodashFactory.js"));

            bundles.Add(new ScriptBundle("~/bundles/appendControllers").Include(
                         "~/Scripts/CityCallScripts/Admin/dailer/controllers/dailerDetailsController.js",
                         "~/Scripts/CityCallScripts/Admin/dailer/controllers/addEditDailerDetailsCtrl.js",
                          "~/Scripts/CityCallScripts/Admin/login/controllers/adminHomeController.js",
                         "~/Scripts/CityCallScripts/Admin/login/controllers/indexController.js",
                        "~/Scripts/CityCallScripts/Admin/login/controllers/loginController.js"));

        }
    }
}
