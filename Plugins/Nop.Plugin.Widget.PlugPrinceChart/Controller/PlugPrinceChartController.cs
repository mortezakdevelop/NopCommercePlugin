using Nop.Core.Data;
using Nop.Plugin.Widget.PlugPrinceChart.Domain;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Widget.PlugPrinceChart.Controller
{
   public class PlugPrinceChartController:BasePluginController
    {
        private IRepository<PriceChartRecord> _priceChartRepository;
        public PlugPrinceChartController(IRepository<PriceChartRecord> priceChartRepository)
        {
            _priceChartRepository = priceChartRepository;
        }

        public ActionResult Manage()
        {
            return View();
        }
    }
}
