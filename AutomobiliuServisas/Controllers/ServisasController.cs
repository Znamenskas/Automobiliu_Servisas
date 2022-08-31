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
    public class ServisasController : Controller
    {
        private readonly AutomobiliuServisasContext _context;

        public ServisasController(AutomobiliuServisasContext context)
        {
            _context = context;
        }

        // GET: Servisas
        public async Task<IActionResult> Index()
        {
            Console.WriteLine("BLA-BLA-BLA");
              return _context.Servisas != null ? 
                          View(await _context.Servisas.ToListAsync()) :
                          Problem("Entity set 'AutomobiliuServisasContext.Servisas'  is null.");
        }

        // GET: Servisas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Servisas == null)
            {
                return NotFound();
            }

            var servisas = await _context.Servisas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servisas == null)
            {
                return NotFound();
            }

            return View(servisas);
        }

        // GET: Servisas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Servisas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pavadinimas,Adresas,Vadovas,Miestas")] Servisas servisas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servisas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servisas);
        }

        // GET: Servisas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Servisas == null)
            {
                return NotFound();
            }

            var servisas = await _context.Servisas.FindAsync(id);
            if (servisas == null)
            {
                return NotFound();
            }
            return View(servisas);
        }

        // POST: Servisas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pavadinimas,Adresas,Vadovas,Miestas")] Servisas servisas)
        {
            if (id != servisas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servisas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServisasExists(servisas.Id))
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
            return View(servisas);
        }

        // GET: Servisas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Servisas == null)
            {
                return NotFound();
            }

            var servisas = await _context.Servisas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servisas == null)
            {
                return NotFound();
            }

            return View(servisas);
        }

        // POST: Servisas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Servisas == null)
            {
                return Problem("Entity set 'AutomobiliuServisasContext.Servisas'  is null.");
            }
            var servisas = await _context.Servisas.FindAsync(id);
            if (servisas != null)
            {
                _context.Servisas.Remove(servisas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServisasExists(int id)
        {
          return (_context.Servisas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
