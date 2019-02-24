using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using finalProject.Models;

namespace finalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeButtonTextsController : Controller
    {
        private readonly ProviderDbContext _context;

        public HomeButtonTextsController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/HomeButtonTexts
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeButtonTexts.ToListAsync());
        }

        // GET: Admin/HomeButtonTexts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeButtonText = await _context.HomeButtonTexts
                .FirstOrDefaultAsync(m => m.id == id);
            if (homeButtonText == null)
            {
                return NotFound();
            }

            return View(homeButtonText);
        }

        // GET: Admin/HomeButtonTexts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeButtonTexts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Text,LangId")] HomeButtonText homeButtonText)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeButtonText);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeButtonText);
        }

        // GET: Admin/HomeButtonTexts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeButtonText = await _context.HomeButtonTexts.FindAsync(id);
            if (homeButtonText == null)
            {
                return NotFound();
            }
            return View(homeButtonText);
        }

        // POST: Admin/HomeButtonTexts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Text,LangId")] HomeButtonText homeButtonText)
        {
            if (id != homeButtonText.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeButtonText);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeButtonTextExists(homeButtonText.id))
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
            return View(homeButtonText);
        }

        // GET: Admin/HomeButtonTexts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeButtonText = await _context.HomeButtonTexts
                .FirstOrDefaultAsync(m => m.id == id);
            if (homeButtonText == null)
            {
                return NotFound();
            }

            return View(homeButtonText);
        }

        // POST: Admin/HomeButtonTexts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeButtonText = await _context.HomeButtonTexts.FindAsync(id);
            _context.HomeButtonTexts.Remove(homeButtonText);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeButtonTextExists(int id)
        {
            return _context.HomeButtonTexts.Any(e => e.id == id);
        }
    }
}
