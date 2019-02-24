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
    public class ProviderCategoriesController : Controller
    {
        private readonly ProviderDbContext _context;

        public ProviderCategoriesController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ProviderCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProviderCategories.ToListAsync());
        }

        // GET: Admin/ProviderCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerCategory = await _context.ProviderCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerCategory == null)
            {
                return NotFound();
            }

            return View(providerCategory);
        }

        // GET: Admin/ProviderCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProviderCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ProviderCategory providerCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(providerCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(providerCategory);
        }

        // GET: Admin/ProviderCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerCategory = await _context.ProviderCategories.FindAsync(id);
            if (providerCategory == null)
            {
                return NotFound();
            }
            return View(providerCategory);
        }

        // POST: Admin/ProviderCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ProviderCategory providerCategory)
        {
            if (id != providerCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(providerCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderCategoryExists(providerCategory.Id))
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
            return View(providerCategory);
        }

        // GET: Admin/ProviderCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerCategory = await _context.ProviderCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerCategory == null)
            {
                return NotFound();
            }

            return View(providerCategory);
        }

        // POST: Admin/ProviderCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var providerCategory = await _context.ProviderCategories.FindAsync(id);
            _context.ProviderCategories.Remove(providerCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProviderCategoryExists(int id)
        {
            return _context.ProviderCategories.Any(e => e.Id == id);
        }
    }
}
