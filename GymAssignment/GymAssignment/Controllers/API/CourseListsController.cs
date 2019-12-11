using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GymAssignment.Data;
using GymAssignment.Models;

namespace GymAssignment.Controllers.API
{
    //Adding in an API for outside users to View/Create our courses, 
    //then they will have a better idea if we're the gym for them. -Tyler Lindley
    [Route("api/[controller]")]
    [ApiController]
    public class CourseListsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CourseLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseList>>> GetCourseList()
        {
            return await _context.CourseList.ToListAsync();
        }

        // GET: api/CourseLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseList>> GetCourseList(int id)
        {
            var courseList = await _context.CourseList.FindAsync(id);

            if (courseList == null)
            {
                return NotFound();
            }

            return courseList;
        }

        // PUT: api/CourseLists/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseList(int id, CourseList courseList)
        {
            if (id != courseList.Id)
            {
                return BadRequest();
            }

            _context.Entry(courseList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseListExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CourseLists
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CourseList>> PostCourseList(CourseList courseList)
        {
            _context.CourseList.Add(courseList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourseList", new { id = courseList.Id }, courseList);
        }

        // DELETE: api/CourseLists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CourseList>> DeleteCourseList(int id)
        {
            var courseList = await _context.CourseList.FindAsync(id);
            if (courseList == null)
            {
                return NotFound();
            }

            _context.CourseList.Remove(courseList);
            await _context.SaveChangesAsync();

            return courseList;
        }

        private bool CourseListExists(int id)
        {
            return _context.CourseList.Any(e => e.Id == id);
        }
    }
}
