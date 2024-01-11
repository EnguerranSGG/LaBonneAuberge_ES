using LaBonneAuberge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using LaBonneAuberge.Data;
using LaBonneAuberge.ViewModels;
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
        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                // Chargement des produits depuis la base de donnée
                Categories = await _context.Categories.Include(c => c.Menus).ToListAsync(),
                FeedBacks = await _context.FeedBacks.ToListAsync()

            };
            return View(viewModel);
        }


        public IActionResult Presentation()
        {
            return View();
        }
        public IActionResult Legal()
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

        public IActionResult FormAvis()
        {
            return View();
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FormAvis([Bind("Pseudo_FeedBack,Notation_FeedBack,Email_FeedBack,Message_FeedBack")] FeedBackModel feedBackModel)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(feedBackModel.Notation_FeedBack);
                _context.Add(feedBackModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            foreach (var modelStateEntry in ModelState.Values)
            {
                foreach (var error in modelStateEntry.Errors)
                {
                    Console.WriteLine($"Erreur de modèle: {error.ErrorMessage}");
                }
            }
            
            return View(feedBackModel);
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact([Bind("Email,Message")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Bien reçu cowboy!";
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

    }

}

