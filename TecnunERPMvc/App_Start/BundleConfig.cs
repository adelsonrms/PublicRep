using System.Web;
using System.Web.Optimization;

namespace TecnunERPMvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/CSS/Tecnun").Include(
                                        "~/Content/tecnun.css"));

            //Componentes JS e CSS para o Bootstrap
            bundles.Add(new StyleBundle("~/CSS/Bootstrap").Include(
                                        "~/Content/bootstrap/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/JS/Bootstrap").Include(
                                         "~/Content/bootstrap/bootstrap.js"));

            //Componentes JS e CSS para o JQuery
            bundles.Add(new ScriptBundle("~/JS/JQuery").Include(
                                         "~/Content/jquery/jquery-1.12.4.js"));
            /*
             * CDN : 
             * <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.16/datatables.min.css"/>
               <script type="text/javascript" src="https://cdn.datatables.net/v/dt/dt-1.10.16/datatables.min.js"></script>
            */
            
            //Componentes JS e CSS para o DataTable
            bundles.Add(new ScriptBundle("~/JS/DataTable").Include(
                                          "~/Content/datatable/dataTables.bootstrap.min.js",
                                          "~/Content/datatable/jquery.dataTables.js"));

            bundles.Add(new StyleBundle("~/CSS/DataTable").Include(
                                        "~/Content/datatable/jquery.dataTables.css"));

        }
    }
}
