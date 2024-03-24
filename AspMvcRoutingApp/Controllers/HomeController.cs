using AspMvcRoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcRoutingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];

            return Content($"Controller {controller}, Action {action}");

            //return View();
        }

        public IActionResult Privacy()
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
