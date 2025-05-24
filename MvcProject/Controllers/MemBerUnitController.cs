using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcProject.Data;
using MvcProject.Models.Entities;

namespace MvcProject.Controllers
{
    public class MemBerUnitController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MemBerUnitController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MemBerUnit
        public async Task<IActionResult> Index()
        {
            return View(await _context.MemBerUint.ToListAsync());
        }

        // GET: MemBerUnit/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memBerUnit = await _context.MemBerUint
                .FirstOrDefaultAsync(m => m.MemBerUnitId == id);
            if (memBerUnit == null)
            {
                return NotFound();
            }

            return View(memBerUnit);
        }

        // GET: MemBerUnit/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MemBerUnit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemBerUnitId,MemBerUnitName,Address,PhoneNumber,WebsiteUrl")] MemBerUnit memBerUnit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memBerUnit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(memBerUnit);
        }

        // GET: MemBerUnit/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memBerUnit = await _context.MemBerUint.FindAsync(id);
            if (memBerUnit == null)
            {
                return NotFound();
            }
            return View(memBerUnit);
        }

        // POST: MemBerUnit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemBerUnitId,MemBerUnitName,Address,PhoneNumber,WebsiteUrl")] MemBerUnit memBerUnit)
        {
            if (id != memBerUnit.MemBerUnitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memBerUnit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemBerUnitExists(memBerUnit.MemBerUnitId))
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
            return View(memBerUnit);
        }

        // GET: MemBerUnit/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memBerUnit = await _context.MemBerUint
                .FirstOrDefaultAsync(m => m.MemBerUnitId == id);
            if (memBerUnit == null)
            {
                return NotFound();
            }

            return View(memBerUnit);
        }

        // POST: MemBerUnit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var memBerUnit = await _context.MemBerUint.FindAsync(id);
            if (memBerUnit != null)
            {
                _context.MemBerUint.Remove(memBerUnit);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemBerUnitExists(int id)
        {
            return _context.MemBerUint.Any(e => e.MemBerUnitId == id);
        }
    }
}
