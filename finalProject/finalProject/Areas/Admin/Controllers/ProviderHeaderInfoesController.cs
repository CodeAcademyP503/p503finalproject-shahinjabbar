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
    public class ProviderHeaderInfoesController : Controller
    {
        private readonly ProviderDbContext _context;

        public ProviderHeaderInfoesController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ProviderHeaderInfoes
        public async Task<IActionResult> Index()
        {
            var providerDbContext = _context.ProviderHeaderInfos.Include(p => p.CoreProvider);
            return View(await providerDbContext.ToListAsync());
        }

        // GET: Admin/ProviderHeaderInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerHeaderInfo = await _context.ProviderHeaderInfos
                .Include(p => p.CoreProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerHeaderInfo == null)
            {
                return NotFound();
            }

            return View(providerHeaderInfo);
        }

        // GET: Admin/ProviderHeaderInfoes/Create
        public IActionResult Create()
        {
            ViewData["CoreProviderId"] = new SelectList(_context.CoreProviders, "Id", "BackColor");
            return View();
        }

        // POST: Admin/ProviderHeaderInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImgPath,Text,CoreProviderId")] ProviderHeaderInfo providerHeaderInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(providerHeaderInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoreProviderId"] = new SelectList(_context.CoreProviders, "Id", "BackColor", providerHeaderInfo.CoreProviderId);
            return View(providerHeaderInfo);
        }

        // GET: Admin/ProviderHeaderInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerHeaderInfo = await _context.ProviderHeaderInfos.FindAsync(id);
            if (providerHeaderInfo == null)
            {
                return NotFound();
            }
            ViewData["CoreProviderId"] = new SelectList(_context.CoreProviders, "Id", "BackColor", providerHeaderInfo.CoreProviderId);
            return View(providerHeaderInfo);
        }

        // POST: Admin/ProviderHeaderInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImgPath,Text,CoreProviderId")] ProviderHeaderInfo providerHeaderInfo)
        {
            if (id != providerHeaderInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(providerHeaderInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderHeaderInfoExists(providerHeaderInfo.Id))
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
            ViewData["CoreProviderId"] = new SelectList(_context.CoreProviders, "Id", "BackColor", providerHeaderInfo.CoreProviderId);
            return View(providerHeaderInfo);
        }

        // GET: Admin/ProviderHeaderInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerHeaderInfo = await _context.ProviderHeaderInfos
                .Include(p => p.CoreProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerHeaderInfo == null)
            {
                return NotFound();
            }

            return View(providerHeaderInfo);
        }

        // POST: Admin/ProviderHeaderInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var providerHeaderInfo = await _context.ProviderHeaderInfos.FindAsync(id);
            _context.ProviderHeaderInfos.Remove(providerHeaderInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProviderHeaderInfoExists(int id)
        {
            return _context.ProviderHeaderInfos.Any(e => e.Id == id);
        }
    }
}
