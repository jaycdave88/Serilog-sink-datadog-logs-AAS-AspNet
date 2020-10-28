using Serilog;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Serilog_sink_datadog_logs_AAS_AspNet
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Serilog.Log.Logger = new LoggerConfiguration() 
                .WriteTo.DatadogLogs("<API_KEY>")     // Write to Datadog 
                .Enrich.FromLogContext()             // Add TraceId Correlation 
                .CreateLogger();
        }
    }
}
