using System.Web;
using System.Web.Optimization;

namespace ProjetGamer
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                "~/Scripts/jquery-3.4.1.js",
                "~/Scripts/core/popper.min.js",
                "~/Scripts/core/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                "~/Scripts/plugins/perfect-scrollbar.jquery.min.js",
                "~/Scripts/plugins/chartjs.min.js",
                "~/Scripts/plugins/bootstrap-notify.js"
                ));
        }
    }
}
