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
{
                //Commenting out the roles as we do not have authentication
    [Authorize] //(Roles ="Admin")]
    public class FacultyListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FacultyListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FacultyLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.FacultyList.ToListAsync());
        }

        // GET: FacultyLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facultyList = await _context.FacultyList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (facultyList == null)
            {
                return NotFound();
            }

            return View(facultyList);
        }

        // GET: FacultyLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FacultyLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Shift,Position,Department,StoreLocation,HomeAddress,PhoneNumber")] FacultyList facultyList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facultyList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(facultyList);
        }

        // GET: FacultyLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facultyList = await _context.FacultyList.FindAsync(id);
            if (facultyList == null)
            {
                return NotFound();
            }
            return View(facultyList);
        }

        // POST: FacultyLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Shift,Position,Department,StoreLocation,HomeAddress,PhoneNumber")] FacultyList facultyList)
        {
            if (id != facultyList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facultyList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacultyListExists(facultyList.Id))
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
            return View(facultyList);
        }

        // GET: FacultyLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facultyList = await _context.FacultyList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (facultyList == null)
            {
                return NotFound();
            }

            return View(facultyList);
        }

        // POST: FacultyLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facultyList = await _context.FacultyList.FindAsync(id);
            _context.FacultyList.Remove(facultyList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacultyListExists(int id)
        {
            return _context.FacultyList.Any(e => e.Id == id);
        }
    }
}
