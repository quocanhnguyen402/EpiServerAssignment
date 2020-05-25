using System.Web;
using System.Web.Optimization;

namespace Assignment_EpiServer
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(bundle: new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css", "~/Content/site.css", "~/Content/Layout.css"));

            //  Home page css file
            bundles.Add(new StyleBundle("~/Content/css-homepage").Include(
                "~/Content/CSS-For-Page/HomePage.css"));

            //  Country css file
            bundles.Add(new StyleBundle("~/Content/css-dataTable").Include(
                "~/Content/CSS-For-Page/DataTables.css"));

            //  Latest News css file
            bundles.Add(new StyleBundle("~/Content/css-latest-news").Include(
                "~/Content/CSS-For-Page/LatestNews.css"));

            // DataTable js file
            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                "~/Scripts/DataTable/jquery.dataTables.min.js",
                "~/Scripts/DataTable/dataTables.bootstrap.min.js",
                "~/Scripts/DataTable/dataTables.js"));

            // CountryChart js file
            bundles.Add(new ScriptBundle("~/bundles/canvasjs").Include(
                "~/Scripts/CountryChart/canvasjs.js"));
        }
    }
}
