using Nop.Plugin.Widget.PlugPrinceChart.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widget.PlugPrinceChart.Data
{
    class PriceChartRecordMap: EntityTypeConfiguration<PriceChartRecord>
    {
        public PriceChartRecordMap()
        {
            ToTable("PriceChart");
            HasKey(m => m.ID);

            Property(m => m.Name);
            Property(m => m.ProductCompany);
            Property(m => m.Price);
            Property(m => m.Date);

        }
    }
}
