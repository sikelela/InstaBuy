using System.Web.Optimization;

namespace InstaBuy
{
  public class BundleConfig
  {
    // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Scripts/jquery.validate*"));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

      bundles.Add(new StyleBundle("~/Styles/css").Include(
                "~/Styles/bootstrap.min.css",
                "~/Styles/site.css",
                "~/Styles/jquery-ui-1.8.19.custom.css",
                 "~/Styles/font-awesome.min.css",
                "~/Styles/welcome.css"));

      bundles.Add(new ScriptBundle("~/Script/Bundles")
        .Include(
        "~/Bundles/inline.*",
        "~/Bundles/polyfills.*",
        "~/Bundles/scripts.*",
        "~/Bundles/vendor.*",
        "~/Bundles/main.*"));

    }
  }
}
