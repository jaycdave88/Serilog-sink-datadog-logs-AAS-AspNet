using Serilog;
using System.Web.Mvc;

namespace Serilog_sink_datadog_logs_AAS_AspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Log.Information("This is the Index page.");

            return View();
        }

        public ActionResult About()
        {
            Log.Information("This is the About page.");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Log.Information("This is the Contact page.");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}