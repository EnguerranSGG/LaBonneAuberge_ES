using LaBonneAuberge.Migrations;
using LaBonneAuberge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using LaBonneAuberge.Data;

namespace LaBonneAuberge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LaBonneAubergeContext _context;

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
        
        public async Task<IActionResult> Contact()
        {
            var TeamList = await _context.TeamLists.ToListAsync();
            return View(TeamList);
        }

        public async Task<IActionResult> Avis()
        {
            var feedBacks = await _context.FeedBacks.ToListAsync();
            return View(feedBacks);
        }

        public async Task<IActionResult> Carte()
        {
            var Menu = await _context.Menus.ToListAsync();
            return View(Menu);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
