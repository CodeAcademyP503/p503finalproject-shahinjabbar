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
    public class ProviderAdditionalInformationsController : Controller
    {
        private readonly ProviderDbContext _context;

        public ProviderAdditionalInformationsController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ProviderAdditionalInformations
        public async Task<IActionResult> Index()
        {
            var providerDbContext = _context.ProviderAdditionalInformations.Include(p => p.GroupProvider);
            return View(await providerDbContext.ToListAsync());
        }

        // GET: Admin/ProviderAdditionalInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerAdditionalInformation = await _context.ProviderAdditionalInformations
                .Include(p => p.GroupProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerAdditionalInformation == null)
            {
                return NotFound();
            }

            return View(providerAdditionalInformation);
        }

        // GET: Admin/ProviderAdditionalInformations/Create
        public IActionResult Create()
        {
            ViewData["GroupProviderId"] = new SelectList(_context.GroupProviders, "Id", "BackColor");
            return View();
        }

        // POST: Admin/ProviderAdditionalInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InputText,SecondaryInputText,AdditionalInputText,FirstInputValidLength,SecondaryInputValidLength,AdditionalInputValidLength,GroupProviderId")] ProviderAdditionalInformation providerAdditionalInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(providerAdditionalInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupProviderId"] = new SelectList(_context.GroupProviders, "Id", "BackColor", providerAdditionalInformation.GroupProviderId);
            return View(providerAdditionalInformation);
        }

        // GET: Admin/ProviderAdditionalInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerAdditionalInformation = await _context.ProviderAdditionalInformations.FindAsync(id);
            if (providerAdditionalInformation == null)
            {
                return NotFound();
            }
            ViewData["GroupProviderId"] = new SelectList(_context.GroupProviders, "Id", "BackColor", providerAdditionalInformation.GroupProviderId);
            return View(providerAdditionalInformation);
        }

        // POST: Admin/ProviderAdditionalInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InputText,SecondaryInputText,AdditionalInputText,FirstInputValidLength,SecondaryInputValidLength,AdditionalInputValidLength,GroupProviderId")] ProviderAdditionalInformation providerAdditionalInformation)
        {
            if (id != providerAdditionalInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(providerAdditionalInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderAdditionalInformationExists(providerAdditionalInformation.Id))
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
            ViewData["GroupProviderId"] = new SelectList(_context.GroupProviders, "Id", "BackColor", providerAdditionalInformation.GroupProviderId);
            return View(providerAdditionalInformation);
        }

        // GET: Admin/ProviderAdditionalInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerAdditionalInformation = await _context.ProviderAdditionalInformations
                .Include(p => p.GroupProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerAdditionalInformation == null)
            {
                return NotFound();
            }

            return View(providerAdditionalInformation);
        }

        // POST: Admin/ProviderAdditionalInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var providerAdditionalInformation = await _context.ProviderAdditionalInformations.FindAsync(id);
            _context.ProviderAdditionalInformations.Remove(providerAdditionalInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProviderAdditionalInformationExists(int id)
        {
            return _context.ProviderAdditionalInformations.Any(e => e.Id == id);
        }
    }
}
