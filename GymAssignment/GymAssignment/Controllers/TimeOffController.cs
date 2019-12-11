using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymAssignment.Data;
using GymAssignment.Models;
using Microsoft.AspNetCore.Authorization;

namespace GymAssignment.Controllers
{               //Commenting out the roles as we do not have authentication
    [Authorize] //(Roles ="Admin")]
    public class TimeOffController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimeOffController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TimeOff
        public async Task<IActionResult> Index()
        {
            return View(await _context.TimeOffSchedule.ToListAsync());
        }

        // GET: TimeOff/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeOffSchedule = await _context.TimeOffSchedule
                .FirstOrDefaultAsync(m => m.Id == id);
            if (timeOffSchedule == null)
            {
                return NotFound();
            }

            return View(timeOffSchedule);
        }

        // GET: TimeOff/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TimeOff/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Date,CoveredBy,PostTime")] TimeOffSchedule timeOffSchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeOffSchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeOffSchedule);
        }

        // GET: TimeOff/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeOffSchedule = await _context.TimeOffSchedule.FindAsync(id);
            if (timeOffSchedule == null)
            {
                return NotFound();
            }
            return View(timeOffSchedule);
        }

        // POST: TimeOff/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Date,CoveredBy,PostTime")] TimeOffSchedule timeOffSchedule)
        {
            if (id != timeOffSchedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeOffSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeOffScheduleExists(timeOffSchedule.Id))
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
            return View(timeOffSchedule);
        }

        // GET: TimeOff/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeOffSchedule = await _context.TimeOffSchedule
                .FirstOrDefaultAsync(m => m.Id == id);
            if (timeOffSchedule == null)
            {
                return NotFound();
            }

            return View(timeOffSchedule);
        }

        // POST: TimeOff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timeOffSchedule = await _context.TimeOffSchedule.FindAsync(id);
            _context.TimeOffSchedule.Remove(timeOffSchedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeOffScheduleExists(int id)
        {
            return _context.TimeOffSchedule.Any(e => e.Id == id);
        }
    }
}
