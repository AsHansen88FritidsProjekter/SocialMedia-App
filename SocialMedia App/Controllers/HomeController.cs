using Microsoft.AspNetCore.Mvc;
using SocialMedia_App.Models;
using System.Diagnostics;

namespace SocialMedia_App.Controllers
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
            return View();
        }

    }
}
