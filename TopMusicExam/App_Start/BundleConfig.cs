﻿using System.Web;
using System.Web.Optimization;

namespace TopMusicExam
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // modification du bundle css avec les assets progressus
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/main.css",
                      "~/Content/Site.css"));

            //creation du bundle avec les assets progressus
            bundles.Add(new ScriptBundle("~/bundles/progressus").Include(
                    "~/Scripts/google-map.js",
                    "~/Scripts/headroom.min.js",
                    "~/Scripts/JQuery.headroom.min.js",
                    "~/Scripts/template.js"
                ));
        }
    }
}
