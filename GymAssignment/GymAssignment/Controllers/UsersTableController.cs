using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymAssignment.Data;
using GymAssignment.Models;

namespace GymAssignment.Controllers
{
    public class UsersTableController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersTableController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UsersTable
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsersTable.ToListAsync());
        }

        // GET: UsersTable/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersTable = await _context.UsersTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usersTable == null)
            {
                return NotFound();
            }

            return View(usersTable);
        }

        // GET: UsersTable/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsersTable/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,PhoneNumber,StartingWeight,GoalWeight,Location,PreferredTraining")] UsersTable usersTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usersTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usersTable);
        }

        // GET: UsersTable/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersTable = await _context.UsersTable.FindAsync(id);
            if (usersTable == null)
            {
                return NotFound();
            }
            return View(usersTable);
        }

        // POST: UsersTable/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,PhoneNumber,StartingWeight,GoalWeight,Location,PreferredTraining")] UsersTable usersTable)
        {
            if (id != usersTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersTableExists(usersTable.Id))
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
            return View(usersTable);
        }

        // GET: UsersTable/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersTable = await _context.UsersTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usersTable == null)
            {
                return NotFound();
            }

            return View(usersTable);
        }

        // POST: UsersTable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usersTable = await _context.UsersTable.FindAsync(id);
            _context.UsersTable.Remove(usersTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersTableExists(int id)
        {
            return _context.UsersTable.Any(e => e.Id == id);
        }
    }
}
