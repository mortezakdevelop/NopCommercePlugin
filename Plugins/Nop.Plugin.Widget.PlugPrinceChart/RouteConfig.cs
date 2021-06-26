using Nop.Plugin.Widget.PlugPrinceChart.DependencyInjection;
using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nop.Plugin.Widget.PlugPrinceChart
{
    public class RouteConfig : IRouteProvider
    {
        public RouteConfig()
        {
        }

        public int Priority
        {
            get { return 0; }
        }

        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Widget.PlugPrinceChart.ManageTrackers", "PlugPrinceChart/Manage",
                new { Controller = "PlugPrinceChart", Action = "Manage" },
                new[] { "Nop.Plugin.Widget.PlugPrinceChart.Controller" });

            ViewEngines.Engines.Insert(0, new CustomViewEngine());
        }

    }
}
