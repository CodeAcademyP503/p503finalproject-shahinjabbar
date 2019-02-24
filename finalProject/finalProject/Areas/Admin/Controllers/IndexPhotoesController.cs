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
    public class IndexPhotoesController : Controller
    {
        private readonly ProviderDbContext _context;

        public IndexPhotoesController(ProviderDbContext context)
        {
            _context = context;
        }

        // GET: Admin/IndexPhotoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.IndexPhotos.ToListAsync());
        }

        // GET: Admin/IndexPhotoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexPhoto = await _context.IndexPhotos
                .FirstOrDefaultAsync(m => m.id == id);
            if (indexPhoto == null)
            {
                return NotFound();
            }

            return View(indexPhoto);
        }

        // GET: Admin/IndexPhotoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/IndexPhotoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,PhotoPath,LangId")] IndexPhoto indexPhoto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indexPhoto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indexPhoto);
        }

        // GET: Admin/IndexPhotoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexPhoto = await _context.IndexPhotos.FindAsync(id);
            if (indexPhoto == null)
            {
                return NotFound();
            }
            return View(indexPhoto);
        }

        // POST: Admin/IndexPhotoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,PhotoPath,LangId")] IndexPhoto indexPhoto)
        {
            if (id != indexPhoto.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indexPhoto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndexPhotoExists(indexPhoto.id))
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
            return View(indexPhoto);
        }

        // GET: Admin/IndexPhotoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexPhoto = await _context.IndexPhotos
                .FirstOrDefaultAsync(m => m.id == id);
            if (indexPhoto == null)
            {
                return NotFound();
            }

            return View(indexPhoto);
        }

        // POST: Admin/IndexPhotoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var indexPhoto = await _context.IndexPhotos.FindAsync(id);
            _context.IndexPhotos.Remove(indexPhoto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndexPhotoExists(int id)
        {
            return _context.IndexPhotos.Any(e => e.id == id);
        }
    }
}
