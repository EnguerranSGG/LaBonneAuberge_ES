using LaBonneAuberge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LaBonneAuberge.Data;
using Microsoft.EntityFrameworkCore;

namespace LaBonneAuberge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly LaBonneAubergeContext _context;

        public HomeController(ILogger<HomeController> logger, LaBonneAubergeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Presentation()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
          public IActionResult Contact()
        {
            return View();
        }

        public async Task<IActionResult> Avis()
        {
            var feedBacks = await _context.FeedBacks.ToListAsync();
            return View(feedBacks);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
