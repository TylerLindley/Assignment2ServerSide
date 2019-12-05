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
    [Authorize] //(Roles ="Admin")]
    public class CourseListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CourseLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseList.ToListAsync());
        }

        // GET: CourseLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseList = await _context.CourseList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseList == null)
            {
                return NotFound();
            }

            return View(courseList);
        }

        // GET: CourseLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourseLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourseName,PhysicalActivity,Time,Instructor,Location")] CourseList courseList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseList);
        }

        // GET: CourseLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseList = await _context.CourseList.FindAsync(id);
            if (courseList == null)
            {
                return NotFound();
            }
            return View(courseList);
        }

        // POST: CourseLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CourseName,PhysicalActivity,Time,Instructor,Location")] CourseList courseList)
        {
            if (id != courseList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseListExists(courseList.Id))
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
            return View(courseList);
        }

        // GET: CourseLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseList = await _context.CourseList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseList == null)
            {
                return NotFound();
            }

            return View(courseList);
        }

        // POST: CourseLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseList = await _context.CourseList.FindAsync(id);
            _context.CourseList.Remove(courseList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseListExists(int id)
        {
            return _context.CourseList.Any(e => e.Id == id);
        }
    }
}
