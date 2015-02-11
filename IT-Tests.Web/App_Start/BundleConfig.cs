using System.Web;
using System.Web.Optimization;

namespace IT_Tests.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                    "~/Scripts/js/bootstrap.min.js",
                    "~/Scripts/js/html5shiv.js",
                    "~/Scripts/js/jquery.isotope.min",
                    "~/Scripts/js/jquery.js",
                    "~/Scripts/js/jquery.prettyPhoto.js",
                    "~/Scripts/js/main.js",
                    "~/Scripts/js/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/flags.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/main.css",
                      "~/Content/css/prettyPhoto.css"));
        }
    }
}
