using System.Web;
using System.Web.Optimization;

namespace AppTest
{
    public class BundleConfig
    {
        // Pour plus d'informations sur Bundling, accédez à l'adresse http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //person list
            bundles.Add(new ScriptBundle("~/person-list").Include(
                        "~/Assets/Controllers/Person/personController.js"));









            //angular
            bundles.Add(new ScriptBundle("~/angular").Include(
                        "~/Assets/plugins/angular/angular.js",
                         "~/Assets/Controllers/App.js",
                         "~/Assets/plugins/bootstrap/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour développer et apprendre. Puis, lorsque vous êtes
            // prêt pour la production, utilisez l'outil de génération sur http://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css",
                "~/Assets/plugins/bootstrap/css/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Bootstrap").Include("~/Assets/plugins/bootstrap/css/bootstrap.css"));

            //bundles.Add(new StyleBundle("~/Bootstrapjs").Include("~/Assets/plugins/bootstrap/js/bootstrap.js"));
      
        }
    }
}