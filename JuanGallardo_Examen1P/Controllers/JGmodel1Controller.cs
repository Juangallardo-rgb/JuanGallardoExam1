using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuanGallardo_Examen1P.Models;

namespace JuanGallardo_Examen1P.Controllers
{
    public class JGmodel1Controller : Controller
    {
        private readonly JuanGallardo_Examen1PContext _context;

        public JGmodel1Controller(JuanGallardo_Examen1PContext context)
        {
            _context = context;
        }

        // GET: JGmodel1
        public async Task<IActionResult> Index()
        {
            return View(await _context.JGmodel1.ToListAsync());
        }

        // GET: JGmodel1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jGmodel1 = await _context.JGmodel1
                .FirstOrDefaultAsync(m => m.JGmodel1ID == id);
            if (jGmodel1 == null)
            {
                return NotFound();
            }

            return View(jGmodel1);
        }

        // GET: JGmodel1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JGmodel1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JGmodel1ID,Name,Price,CreatedDate")] JGmodel1 jGmodel1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jGmodel1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jGmodel1);
        }

        // GET: JGmodel1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jGmodel1 = await _context.JGmodel1.FindAsync(id);
            if (jGmodel1 == null)
            {
                return NotFound();
            }
            return View(jGmodel1);
        }

        // POST: JGmodel1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JGmodel1ID,Name,Price,CreatedDate")] JGmodel1 jGmodel1)
        {
            if (id != jGmodel1.JGmodel1ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jGmodel1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JGmodel1Exists(jGmodel1.JGmodel1ID))
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
            return View(jGmodel1);
        }

        // GET: JGmodel1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jGmodel1 = await _context.JGmodel1
                .FirstOrDefaultAsync(m => m.JGmodel1ID == id);
            if (jGmodel1 == null)
            {
                return NotFound();
            }

            return View(jGmodel1);
        }

        // POST: JGmodel1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jGmodel1 = await _context.JGmodel1.FindAsync(id);
            if (jGmodel1 != null)
            {
                _context.JGmodel1.Remove(jGmodel1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JGmodel1Exists(int id)
        {
            return _context.JGmodel1.Any(e => e.JGmodel1ID == id);
        }
    }
}
