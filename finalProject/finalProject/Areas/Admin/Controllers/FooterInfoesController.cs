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
    public class FooterInfoesController : Controller
    {
        private readonly ProviderDbContext _context;

        public FooterInfoesController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/FooterInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.FooterInfos.ToListAsync());
        }

        // GET: Admin/FooterInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footerInfo = await _context.FooterInfos
                .FirstOrDefaultAsync(m => m.id == id);
            if (footerInfo == null)
            {
                return NotFound();
            }

            return View(footerInfo);
        }

        // GET: Admin/FooterInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/FooterInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Text,LangId")] FooterInfo footerInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footerInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footerInfo);
        }

        // GET: Admin/FooterInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footerInfo = await _context.FooterInfos.FindAsync(id);
            if (footerInfo == null)
            {
                return NotFound();
            }
            return View(footerInfo);
        }

        // POST: Admin/FooterInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Text,LangId")] FooterInfo footerInfo)
        {
            if (id != footerInfo.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(footerInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FooterInfoExists(footerInfo.id))
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
            return View(footerInfo);
        }

        // GET: Admin/FooterInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footerInfo = await _context.FooterInfos
                .FirstOrDefaultAsync(m => m.id == id);
            if (footerInfo == null)
            {
                return NotFound();
            }

            return View(footerInfo);
        }

        // POST: Admin/FooterInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var footerInfo = await _context.FooterInfos.FindAsync(id);
            _context.FooterInfos.Remove(footerInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FooterInfoExists(int id)
        {
            return _context.FooterInfos.Any(e => e.id == id);
        }
    }
}
