using Luna.Contracts;
using Luna.Recruitment.VisaProcessing.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luna.Recruitment.VisaProcessing.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class MedicalCenterController : Controller
    {
        private readonly lunaContext _context;
        private readonly ILoggerManager _logger;

        public MedicalCenterController(lunaContext context, ILoggerManager logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var lunaContext = _context.MedicalCenter.Include(c=>c.City);
            return View(await lunaContext.ToListAsync());
        }
        public IActionResult Create()
        {
            ViewData["CityId"] = new SelectList(_context.City, "Id", "Name").Take(100).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MedicalCenter medical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CityId"] = new SelectList(_context.City, "Id", "Name").Take(100).ToList();
            return View(medical);
        }
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.MedicalCenter.FindAsync(id);
            if (medical == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_context.City, "Id", "Name").Take(100).ToList();
            return View(medical);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, MedicalCenter medical)
        {
            if (id != medical.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalExist(medical.Id))
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
            ViewData["CityId"] = new SelectList(_context.City, "Id", "Name").Take(100).ToList();
            return View(medical);
        }
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.MedicalCenter
                .Include(c => c.City)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var medical = await _context.MedicalCenter.FindAsync(id);
            _context.MedicalCenter.Remove(medical);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool MedicalExist(long id)
        {
            return _context.MedicalCenter.Any(e => e.Id == id);
        }
    }
}
