using Gabrielle_Stanguini_cp1_mvc_98786.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gabrielle_Stanguini_cp1_mvc_98786.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private User user = new User();

        public IActionResult Index()
        {
            ViewBag.user = user;
            return View();
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
