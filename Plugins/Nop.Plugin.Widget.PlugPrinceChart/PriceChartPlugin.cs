using Nop.Core.Data;
using Nop.Core.Plugins;
using Nop.Plugin.Widget.PlugPrinceChart.Data;
using Nop.Plugin.Widget.PlugPrinceChart.Domain;
using Nop.Web.Framework.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widget.PlugPrinceChart
{
    public class PriceChartPlugin : BasePlugin, IAdminMenuPlugin
    {
        private PriceChartObjectContext _Context;
        private IRepository<PriceChartRecord> _PriceRepo;

        public PriceChartPlugin(PriceChartObjectContext context, IRepository<PriceChartRecord> PriceRepo)
        {
            _Context = context;
            _PriceRepo = PriceRepo;
        }

        public bool Authenticate()
        {
            return true;
        }
        public override void Install()
        {
            _Context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _Context.Uninstall();
            base.Uninstall();
        }

        public Web.Framework.Menu.SiteMapNode BuildMenuItem()
        {
            SiteMapNode node = new SiteMapNode { Visible = true, Title = "Price Chart", Url = "/PriceChart/Manage" };
            return node;
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {
            throw new NotImplementedException();
        }
    }
}
