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
    public class MeistrasController : Controller
    {
        private readonly AutomobiliuServisasContext _context;

        public MeistrasController(AutomobiliuServisasContext context)
        {
            _context = context;
        }


        // GET: Meistras
        public async Task<IActionResult> Index()
        {
            Console.WriteLine("BLA-BLA-BLA");

              return _context.Meistras != null ? 
                          View(await _context.Meistras.ToListAsync()) :
                          Problem("Entity set 'AutomobiliuServisasContext.Meistras'  is null.");
        }

        // GET: Meistras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Meistras == null)
            {
                return NotFound();
            }

            var meistras = await _context.Meistras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meistras == null)
            {
                return NotFound();
            }

            return View(meistras);
        }

        // GET: Meistras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meistras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vardas,Pavarde,Nuotrauka,ServisasId")] Meistras meistras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meistras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meistras);
        }

        // GET: Meistras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Meistras == null)
            {
                return NotFound();
            }

            var meistras = await _context.Meistras.FindAsync(id);
            if (meistras == null)
            {
                return NotFound();
            }
            return View(meistras);
        }

        // POST: Meistras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vardas,Pavarde,Nuotrauka,ServisasId")] Meistras meistras)
        {
            if (id != meistras.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meistras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeistrasExists(meistras.Id))
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
            return View(meistras);
        }

        // GET: Meistras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Meistras == null)
            {
                return NotFound();
            }

            var meistras = await _context.Meistras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meistras == null)
            {
                return NotFound();
            }

            return View(meistras);
        }

        // POST: Meistras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Meistras == null)
            {
                return Problem("Entity set 'AutomobiliuServisasContext.Meistras'  is null.");
            }
            var meistras = await _context.Meistras.FindAsync(id);
            if (meistras != null)
            {
                _context.Meistras.Remove(meistras);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeistrasExists(int id)
        {
          return (_context.Meistras?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        //GET: Ivertinimas
        public string Ivertinimas ()
        {
            return "LABAI-PUIKU";
        }
    
    }
}
