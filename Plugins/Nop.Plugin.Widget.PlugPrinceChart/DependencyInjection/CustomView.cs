using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Themes;

namespace Nop.Plugin.Widget.PlugPrinceChart.DependencyInjection
{
   public class CustomViewEngine: ThemeableRazorViewEngine
    {
        public CustomViewEngine()
        {
            ViewLocationFormats = new[] { "~/Plugins/Widget.PlugPrinceChart/View/{0}.cshtml" };
            PartialViewLocationFormats = new[] { "~/Plugins/Widget.PlugPrinceChart/View/{0}.cshtml" };

        }
    }
}
