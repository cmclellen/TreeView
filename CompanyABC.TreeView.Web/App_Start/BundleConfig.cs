using System.Web;
using System.Web.Optimization;

namespace CompanyABC.TreeView.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-route.js")
                .Include("~/Scripts/angular-ui/ui-bootstrap.js")
                .Include("~/Scripts/angular-ui/ui-bootstrap-tpls.js"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .IncludeDirectory("~/dist/partials", "*.js", true)
                .Include("~/app/app.js")
                .IncludeDirectory("~/app/controllers", "*.js")
                .IncludeDirectory("~/app/services", "*.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/site.css"));
        }
    }
}