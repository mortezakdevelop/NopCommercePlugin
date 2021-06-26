using System;
using System.Collections.Generic;
using Nop.Core.Infrastructure.DependencyManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Web.Framework.Mvc;
using Nop.Plugin.Widget.PlugPrinceChart.Data;
using Nop.Plugin.Widget.PlugPrinceChart.Domain;
using Nop.Data;
using Nop.Core.Data;
using Autofac.Core;

namespace Nop.Plugin.Widget.PlugPrinceChart.DependencyInjection
{
    public class DependencyRegister : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_product_view_tracker";

        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            
            //data context
            this.RegisterPluginDataContext<PriceChartObjectContext>(builder ,CONTEXT_NAME);

            //override required repository with our custom context
            builder.RegisterType<EfRepository<PriceChartRecord>>()
            .As<IRepository<PriceChartRecord>>()
            .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
            .InstancePerLifetimeScope();
        }
        public int Order => 1;

    }
}
