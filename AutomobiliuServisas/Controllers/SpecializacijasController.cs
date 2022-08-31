using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutomobiliuServisas.Data;
using AutomobiliuServisas.Models;

namespace AutomobiliuServisas.Controllers
{
    public class SpecializacijasController : Controller
    {
        private readonly AutomobiliuServisasContext _context;

        public SpecializacijasController(AutomobiliuServisasContext context)
        {
            _context = context;
        }

        // GET: Specializacijas
        public async Task<IActionResult> Index()
        {
              return _context.Specializacija != null ? 
                          View(await _context.Specializacija.ToListAsync()) :
                          Problem("Entity set 'AutomobiliuServisasContext.Specializacija'  is null.");
        }

        // GET: Specializacijas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Specializacija == null)
            {
                return NotFound();
            }

            var specializacija = await _context.Specializacija
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specializacija == null)
            {
                return NotFound();
            }

            return View(specializacija);
        }

        // GET: Specializacijas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Specializacijas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pavadinimas")] Specializacija specializacija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specializacija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specializacija);
        }

        // GET: Specializacijas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Specializacija == null)
            {
                return NotFound();
            }

            var specializacija = await _context.Specializacija.FindAsync(id);
            if (specializacija == null)
            {
                return NotFound();
            }
            return View(specializacija);
        }

        // POST: Specializacijas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pavadinimas")] Specializacija specializacija)
        {
            if (id != specializacija.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specializacija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecializacijaExists(specializacija.Id))
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
            return View(specializacija);
        }

        // GET: Specializacijas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Specializacija == null)
            {
                return NotFound();
            }

            var specializacija = await _context.Specializacija
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specializacija == null)
            {
                return NotFound();
            }

            return View(specializacija);
        }

        // POST: Specializacijas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Specializacija == null)
            {
                return Problem("Entity set 'AutomobiliuServisasContext.Specializacija'  is null.");
            }
            var specializacija = await _context.Specializacija.FindAsync(id);
            if (specializacija != null)
            {
                _context.Specializacija.Remove(specializacija);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecializacijaExists(int id)
        {
          return (_context.Specializacija?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
