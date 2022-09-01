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
    public class VartotojasController : Controller
    {
        private readonly AutomobiliuServisasContext _context;

        public VartotojasController(AutomobiliuServisasContext context)
        {
            _context = context;
        }

        // GET: Vartotojas
        public async Task<IActionResult> Index()
        {
              return _context.Vartotojas != null ? 
                          View(await _context.Vartotojas.ToListAsync()) :
                          Problem("Entity set 'AutomobiliuServisasContext.Vartotojas'  is null.");
        }

        // GET: Vartotojas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vartotojas == null)
            {
                return NotFound();
            }

            var vartotojas = await _context.Vartotojas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vartotojas == null)
            {
                return NotFound();
            }

            return View(vartotojas);
        }

        // GET: Vartotojas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vartotojas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PrisijungimoVardas,ElektroninisPastas,Slaptazodis")] Vartotojas vartotojas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vartotojas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vartotojas);
        }

        // GET: Vartotojas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vartotojas == null)
            {
                return NotFound();
            }

            var vartotojas = await _context.Vartotojas.FindAsync(id);
            if (vartotojas == null)
            {
                return NotFound();
            }
            return View(vartotojas);
        }

        // POST: Vartotojas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PrisijungimoVardas,ElektroninisPastas,Slaptazodis")] Vartotojas vartotojas)
        {
            if (id != vartotojas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vartotojas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VartotojasExists(vartotojas.Id))
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
            return View(vartotojas);
        }

        // GET: Vartotojas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vartotojas == null)
            {
                return NotFound();
            }

            var vartotojas = await _context.Vartotojas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vartotojas == null)
            {
                return NotFound();
            }

            return View(vartotojas);
        }

        // POST: Vartotojas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vartotojas == null)
            {
                return Problem("Entity set 'AutomobiliuServisasContext.Vartotojas'  is null.");
            }
            var vartotojas = await _context.Vartotojas.FindAsync(id);
            if (vartotojas != null)
            {
                _context.Vartotojas.Remove(vartotojas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VartotojasExists(int id)
        {
          return (_context.Vartotojas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
