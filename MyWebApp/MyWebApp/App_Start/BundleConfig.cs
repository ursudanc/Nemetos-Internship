using System.Web;
using System.Web.Optimization;

namespace MyWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/vendor/jquery-1.9.1.min.js", "~/Scripts/jquery.ba-cond.min.js", "~/Scripts/jquery.slitslider.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/mainjs").Include("~/Scripts/main.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/vendor/modernizr-2.6.2-respond-1.1.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js","~/Scripts/vendor/bootstrap.min.js","~/Scripts/twitter-bootstrap-hover-dropdown.min.js"));

         
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap-responsive.min.css", "~/Content/bootstrap.min.css", "~/Content/font-awesome.min.css", "~/Content/main.css", "~/Content/sl-slide.css"));        }
    }
}
