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
            return View();
        }

        public async Task<IActionResult> Avis()
        {
            var feedBacks = await _context.FeedBacks.ToListAsync();
            return View(feedBacks);
        }

        public async Task<IActionResult> Carte()
        {
            var categories = await _context.Categories.Include(m => m.Menus).ToListAsync();
            return View(categories);
        }

        public async Task<IActionResult> Team()
        {
            var TeamList = await _context.TeamLists.ToListAsync();
            return View(TeamList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Reservation()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         

        public async Task<IActionResult> Reservation([Bind("Nom,Date,Time,NombreAdultes,NombreEnfants,NumTel,Email,Message,Anniversaire,Fumeur")] Reservation reservation)
        {            
            if (ModelState.IsValid)
            {
                 if (reservation.Date < DateOnly.FromDateTime(DateTime.Now))
                {
                    ModelState.AddModelError("Date", "La date doit être dans le futur");
                    return View(reservation);
                }
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (var modelStateEntry in ModelState.Values)
                {
                    foreach (var error in modelStateEntry.Errors)
                    {
                        Console.WriteLine($"Erreur de modèle: {error.ErrorMessage}");
                    }
                }
            }

            return View(reservation);
        }




    }
}

