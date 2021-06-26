using Nop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widget.PlugPrinceChart.Domain
{
    public class PriceChartRecord:BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProductCompany { get; set; }
        public int Price { get; set; }
        public int Date { get; set; }
       
    }
}
