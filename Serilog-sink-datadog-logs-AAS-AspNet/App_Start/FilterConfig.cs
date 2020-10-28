using System.Web;
using System.Web.Mvc;

namespace Serilog_sink_datadog_logs_AAS_AspNet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
