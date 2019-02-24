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
    public class TopProvidersController : Controller
    {
        private readonly ProviderDbContext _context;

        public TopProvidersController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/TopProviders
        public async Task<IActionResult> Index()
        {
            return View(await _context.TopProviders.ToListAsync());
        }

        // GET: Admin/TopProviders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topProvider = await _context.TopProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topProvider == null)
            {
                return NotFound();
            }

            return View(topProvider);
        }

        // GET: Admin/TopProviders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TopProviders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TagName,BackColor,ImagePath,DataId,LangId")] TopProvider topProvider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(topProvider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(topProvider);
        }

        // GET: Admin/TopProviders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topProvider = await _context.TopProviders.FindAsync(id);
            if (topProvider == null)
            {
                return NotFound();
            }
            return View(topProvider);
        }

        // POST: Admin/TopProviders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TagName,BackColor,ImagePath,DataId,LangId")] TopProvider topProvider)
        {
            if (id != topProvider.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(topProvider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopProviderExists(topProvider.Id))
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
            return View(topProvider);
        }

        // GET: Admin/TopProviders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topProvider = await _context.TopProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topProvider == null)
            {
                return NotFound();
            }

            return View(topProvider);
        }

        // POST: Admin/TopProviders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var topProvider = await _context.TopProviders.FindAsync(id);
            _context.TopProviders.Remove(topProvider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopProviderExists(int id)
        {
            return _context.TopProviders.Any(e => e.Id == id);
        }
    }
}
