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
    public class ProviderOptionsController : Controller
    {
        private readonly ProviderDbContext _context;

        public ProviderOptionsController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ProviderOptions
        public async Task<IActionResult> Index()
        {
            var providerDbContext = _context.ProviderOptions.Include(p => p.GroupProvider);
            return View(await providerDbContext.ToListAsync());
        }

        // GET: Admin/ProviderOptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerOption = await _context.ProviderOptions
                .Include(p => p.GroupProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerOption == null)
            {
                return NotFound();
            }

            return View(providerOption);
        }

        // GET: Admin/ProviderOptions/Create
        public IActionResult Create()
        {
            ViewData["GroupProviderId"] = new SelectList(_context.GroupProviders, "Id", "BackColor");
            return View();
        }

        // POST: Admin/ProviderOptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Text,LabelText,IsFirstOption,IsSecondaryOption,GroupProviderId")] ProviderOption providerOption)
        {
            if (ModelState.IsValid)
            {
                _context.Add(providerOption);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupProviderId"] = new SelectList(_context.GroupProviders, "Id", "BackColor", providerOption.GroupProviderId);
            return View(providerOption);
        }

        // GET: Admin/ProviderOptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerOption = await _context.ProviderOptions.FindAsync(id);
            if (providerOption == null)
            {
                return NotFound();
            }
            ViewData["GroupProviderId"] = new SelectList(_context.GroupProviders, "Id", "BackColor", providerOption.GroupProviderId);
            return View(providerOption);
        }

        // POST: Admin/ProviderOptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Text,LabelText,IsFirstOption,IsSecondaryOption,GroupProviderId")] ProviderOption providerOption)
        {
            if (id != providerOption.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(providerOption);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderOptionExists(providerOption.Id))
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
            ViewData["GroupProviderId"] = new SelectList(_context.GroupProviders, "Id", "BackColor", providerOption.GroupProviderId);
            return View(providerOption);
        }

        // GET: Admin/ProviderOptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerOption = await _context.ProviderOptions
                .Include(p => p.GroupProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerOption == null)
            {
                return NotFound();
            }

            return View(providerOption);
        }

        // POST: Admin/ProviderOptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var providerOption = await _context.ProviderOptions.FindAsync(id);
            _context.ProviderOptions.Remove(providerOption);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProviderOptionExists(int id)
        {
            return _context.ProviderOptions.Any(e => e.Id == id);
        }
    }
}
