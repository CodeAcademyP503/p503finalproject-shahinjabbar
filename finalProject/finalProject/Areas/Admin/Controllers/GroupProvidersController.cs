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
    public class GroupProvidersController : Controller
    {
        private readonly ProviderDbContext _context;

        public GroupProvidersController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/GroupProviders
        public async Task<IActionResult> Index()
        {
            var providerDbContext = _context.GroupProviders.Include(g => g.CoreProvider);
            return View(await providerDbContext.ToListAsync());
        }

        // GET: Admin/GroupProviders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProvider = await _context.GroupProviders
                .Include(g => g.CoreProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (groupProvider == null)
            {
                return NotFound();
            }

            return View(groupProvider);
        }

        // GET: Admin/GroupProviders/Create
        public IActionResult Create()
        {
            ViewData["CoreProviderId"] = new SelectList(_context.CoreProviders, "Id", "BackColor");
            return View();
        }

        // POST: Admin/GroupProviders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TagName,BackColor,ProviderName,ImagePath,HasOptions,HasSecondaryOptions,HasInput,HasSecondaryInput,HasAdditionalInput,CoreProviderId,ProviderCategroyId")] GroupProvider groupProvider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupProvider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoreProviderId"] = new SelectList(_context.CoreProviders, "Id", "BackColor", groupProvider.CoreProviderId);
            return View(groupProvider);
        }

        // GET: Admin/GroupProviders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProvider = await _context.GroupProviders.FindAsync(id);
            if (groupProvider == null)
            {
                return NotFound();
            }
            ViewData["CoreProviderId"] = new SelectList(_context.CoreProviders, "Id", "BackColor", groupProvider.CoreProviderId);
            return View(groupProvider);
        }

        // POST: Admin/GroupProviders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TagName,BackColor,ProviderName,ImagePath,HasOptions,HasSecondaryOptions,HasInput,HasSecondaryInput,HasAdditionalInput,CoreProviderId,ProviderCategroyId")] GroupProvider groupProvider)
        {
            if (id != groupProvider.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupProvider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupProviderExists(groupProvider.Id))
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
            ViewData["CoreProviderId"] = new SelectList(_context.CoreProviders, "Id", "BackColor", groupProvider.CoreProviderId);
            return View(groupProvider);
        }

        // GET: Admin/GroupProviders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProvider = await _context.GroupProviders
                .Include(g => g.CoreProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (groupProvider == null)
            {
                return NotFound();
            }

            return View(groupProvider);
        }

        // POST: Admin/GroupProviders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupProvider = await _context.GroupProviders.FindAsync(id);
            _context.GroupProviders.Remove(groupProvider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupProviderExists(int id)
        {
            return _context.GroupProviders.Any(e => e.Id == id);
        }
    }
}
