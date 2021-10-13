using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpeedyAuth.Server.Models;
using System.Diagnostics;

namespace SpeedyAuth.Server.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}