using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialMedia_App.Data;
using System.Diagnostics;

namespace SocialMedia_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            var allPosts = await _context.Posts
                .Include (n => n.User)
                .ToListAsync();

            return View(allPosts);

        }

    }
}
