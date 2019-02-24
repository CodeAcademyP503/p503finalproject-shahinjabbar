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
    public class CoreProvidersController : Controller
    {
        private readonly ProviderDbContext _context;

        public CoreProvidersController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CoreProviders
        public async Task<IActionResult> Index()
        {
            return View(await _context.CoreProviders.ToListAsync());
        }

        // GET: Admin/CoreProviders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coreProvider = await _context.CoreProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coreProvider == null)
            {
                return NotFound();
            }

            return View(coreProvider);
        }

        // GET: Admin/CoreProviders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/CoreProviders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TagName,BackColor,ImagePath,Text,DataId,LangId")] CoreProvider coreProvider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coreProvider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coreProvider);
        }

        // GET: Admin/CoreProviders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coreProvider = await _context.CoreProviders.FindAsync(id);
            if (coreProvider == null)
            {
                return NotFound();
            }
            return View(coreProvider);
        }

        // POST: Admin/CoreProviders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TagName,BackColor,ImagePath,Text,DataId,LangId")] CoreProvider coreProvider)
        {
            if (id != coreProvider.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coreProvider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoreProviderExists(coreProvider.Id))
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
            return View(coreProvider);
        }

        // GET: Admin/CoreProviders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coreProvider = await _context.CoreProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coreProvider == null)
            {
                return NotFound();
            }

            return View(coreProvider);
        }

        // POST: Admin/CoreProviders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coreProvider = await _context.CoreProviders.FindAsync(id);
            _context.CoreProviders.Remove(coreProvider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoreProviderExists(int id)
        {
            return _context.CoreProviders.Any(e => e.Id == id);
        }
    }
}
