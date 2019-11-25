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
    public class UsersTablesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersTablesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UsersTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsersTable.ToListAsync());
        }

        // GET: UsersTables/Details/5
        public async Task<IActionResult> Details(string id)
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

        // GET: UsersTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsersTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,PhoneNumber,Location,PreferredTraining")] UsersTable usersTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usersTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usersTable);
        }

        // GET: UsersTables/Edit/5
        public async Task<IActionResult> Edit(string id)
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

        // POST: UsersTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Address,PhoneNumber,Location,PreferredTraining")] UsersTable usersTable)
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

        // GET: UsersTables/Delete/5
        public async Task<IActionResult> Delete(string id)
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

        // POST: UsersTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var usersTable = await _context.UsersTable.FindAsync(id);
            _context.UsersTable.Remove(usersTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersTableExists(string id)
        {
            return _context.UsersTable.Any(e => e.Id == id);
        }
    }
}
