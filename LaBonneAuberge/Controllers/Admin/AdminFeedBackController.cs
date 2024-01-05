using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaBonneAuberge.Data;
using LaBonneAuberge.Models;

namespace LaBonneAuberge
{
    public class AdminFeedBackController : Controller
    {
        private readonly LaBonneAubergeContext _context;

        public AdminFeedBackController(LaBonneAubergeContext context)
        {
            _context = context;
        }

        // GET: AdminFeedBack
        public async Task<IActionResult> Index()
        {
            return View(await _context.FeedBacks.ToListAsync());
        }

        // GET: AdminFeedBack/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedBackModel = await _context.FeedBacks
                .FirstOrDefaultAsync(m => m.Id_FeedBack == id);
            if (feedBackModel == null)
            {
                return NotFound();
            }

            return View(feedBackModel);
        }

        // GET: AdminFeedBack/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminFeedBack/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_FeedBack,Pseudo_FeedBack,Notation_FeedBack,Email_FeedBack,Message_FeedBack")] FeedBackModel feedBackModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedBackModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feedBackModel);
        }

        // GET: AdminFeedBack/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedBackModel = await _context.FeedBacks.FindAsync(id);
            if (feedBackModel == null)
            {
                return NotFound();
            }
            return View(feedBackModel);
        }

        // POST: AdminFeedBack/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_FeedBack,Pseudo_FeedBack,Notation_FeedBack,Email_FeedBack,Message_FeedBack")] FeedBackModel feedBackModel)
        {
            if (id != feedBackModel.Id_FeedBack)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feedBackModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedBackModelExists(feedBackModel.Id_FeedBack))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(feedBackModel);
        }

        // GET: AdminFeedBack/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedBackModel = await _context.FeedBacks
                .FirstOrDefaultAsync(m => m.Id_FeedBack == id);
            if (feedBackModel == null)
            {
                return NotFound();
            }

            return View(feedBackModel);
        }

        // POST: AdminFeedBack/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feedBackModel = await _context.FeedBacks.FindAsync(id);
            if (feedBackModel != null)
            {
                _context.FeedBacks.Remove(feedBackModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeedBackModelExists(int id)
        {
            return _context.FeedBacks.Any(e => e.Id_FeedBack == id);
        }
    }
}
