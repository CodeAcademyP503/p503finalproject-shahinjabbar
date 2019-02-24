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
    public class GroupProviderPageButtonTextsController : Controller
    {
        private readonly ProviderDbContext _context;

        public GroupProviderPageButtonTextsController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/GroupProviderPageButtonTexts
        public async Task<IActionResult> Index()
        {
            return View(await _context.GroupProviderPageButtonTexts.ToListAsync());
        }

        // GET: Admin/GroupProviderPageButtonTexts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProviderPageButtonText = await _context.GroupProviderPageButtonTexts
                .FirstOrDefaultAsync(m => m.id == id);
            if (groupProviderPageButtonText == null)
            {
                return NotFound();
            }

            return View(groupProviderPageButtonText);
        }

        // GET: Admin/GroupProviderPageButtonTexts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/GroupProviderPageButtonTexts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Text,LangId")] GroupProviderPageButtonText groupProviderPageButtonText)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupProviderPageButtonText);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groupProviderPageButtonText);
        }

        // GET: Admin/GroupProviderPageButtonTexts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProviderPageButtonText = await _context.GroupProviderPageButtonTexts.FindAsync(id);
            if (groupProviderPageButtonText == null)
            {
                return NotFound();
            }
            return View(groupProviderPageButtonText);
        }

        // POST: Admin/GroupProviderPageButtonTexts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Text,LangId")] GroupProviderPageButtonText groupProviderPageButtonText)
        {
            if (id != groupProviderPageButtonText.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupProviderPageButtonText);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupProviderPageButtonTextExists(groupProviderPageButtonText.id))
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
            return View(groupProviderPageButtonText);
        }

        // GET: Admin/GroupProviderPageButtonTexts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProviderPageButtonText = await _context.GroupProviderPageButtonTexts
                .FirstOrDefaultAsync(m => m.id == id);
            if (groupProviderPageButtonText == null)
            {
                return NotFound();
            }

            return View(groupProviderPageButtonText);
        }

        // POST: Admin/GroupProviderPageButtonTexts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupProviderPageButtonText = await _context.GroupProviderPageButtonTexts.FindAsync(id);
            _context.GroupProviderPageButtonTexts.Remove(groupProviderPageButtonText);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupProviderPageButtonTextExists(int id)
        {
            return _context.GroupProviderPageButtonTexts.Any(e => e.id == id);
        }
    }
}
