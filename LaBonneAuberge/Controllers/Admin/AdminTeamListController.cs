using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaBonneAuberge.Data;
using LaBonneAuberge.Models;
using Microsoft.AspNetCore.Authorization;

namespace LaBonneAuberge
{
    [Authorize]

    public class AdminTeamListController : Controller
    {
        private readonly LaBonneAubergeContext _context;

        public AdminTeamListController(LaBonneAubergeContext context)
        {
            _context = context;
        }

        // GET: AdminTeamList
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamLists.ToListAsync());
        }

        // GET: AdminTeamList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamList = await _context.TeamLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamList == null)
            {
                return NotFound();
            }

            return View(teamList);
        }

        // GET: AdminTeamList/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminTeamList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,Job,Description,Photo")] TeamList teamList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamList);
        }

        // GET: AdminTeamList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamList = await _context.TeamLists.FindAsync(id);
            if (teamList == null)
            {
                return NotFound();
            }
            return View(teamList);
        }

        // POST: AdminTeamList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,Job,Description,Photo")] TeamList teamList)
        {
            if (id != teamList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamListExists(teamList.Id))
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
            return View(teamList);
        }

        // GET: AdminTeamList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamList = await _context.TeamLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamList == null)
            {
                return NotFound();
            }

            return View(teamList);
        }

        // POST: AdminTeamList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamList = await _context.TeamLists.FindAsync(id);
            if (teamList != null)
            {
                _context.TeamLists.Remove(teamList);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamListExists(int id)
        {
            return _context.TeamLists.Any(e => e.Id == id);
        }
    }
}
