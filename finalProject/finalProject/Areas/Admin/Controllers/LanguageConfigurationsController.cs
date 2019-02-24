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
    public class LanguageConfigurationsController : Controller
    {
        private readonly ProviderDbContext _context;

        public LanguageConfigurationsController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/LanguageConfigurations
        public async Task<IActionResult> Index()
        {
            return View(await _context.LanguageConfigurations.ToListAsync());
        }

        // GET: Admin/LanguageConfigurations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageConfiguration = await _context.LanguageConfigurations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (languageConfiguration == null)
            {
                return NotFound();
            }

            return View(languageConfiguration);
        }

        // GET: Admin/LanguageConfigurations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LanguageConfigurations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LangName,PhotoPath")] LanguageConfiguration languageConfiguration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(languageConfiguration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(languageConfiguration);
        }

        // GET: Admin/LanguageConfigurations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageConfiguration = await _context.LanguageConfigurations.FindAsync(id);
            if (languageConfiguration == null)
            {
                return NotFound();
            }
            return View(languageConfiguration);
        }

        // POST: Admin/LanguageConfigurations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LangName,PhotoPath")] LanguageConfiguration languageConfiguration)
        {
            if (id != languageConfiguration.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(languageConfiguration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanguageConfigurationExists(languageConfiguration.Id))
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
            return View(languageConfiguration);
        }

        // GET: Admin/LanguageConfigurations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageConfiguration = await _context.LanguageConfigurations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (languageConfiguration == null)
            {
                return NotFound();
            }

            return View(languageConfiguration);
        }

        // POST: Admin/LanguageConfigurations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var languageConfiguration = await _context.LanguageConfigurations.FindAsync(id);
            _context.LanguageConfigurations.Remove(languageConfiguration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LanguageConfigurationExists(int id)
        {
            return _context.LanguageConfigurations.Any(e => e.Id == id);
        }
    }
}
