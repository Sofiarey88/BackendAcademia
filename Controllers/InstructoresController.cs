using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AcademiaBaile.Models;

namespace AcademiaBaile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructoresController : ControllerBase
    {
        private readonly ACADEMIAContext _context;

        public InstructoresController(ACADEMIAContext context)
        {
            _context = context;
        }

        // GET: api/Instructores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instructor>>> GetInstructores()
        {
            return await _context.Instructores.ToListAsync();
        }

        // GET: api/Instructores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instructor>> GetInstructor(int id)
        {
            var instructor = await _context.Instructores.FindAsync(id);

            if (instructor == null)
            {
                return NotFound();
            }

            return instructor;
        }

        // PUT: api/Instructores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstructor(int id, Instructor instructor)
        {
            if (id != instructor.Id)
            {
                return BadRequest();
            }

            _context.Entry(instructor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructorExists(id))
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

        // POST: api/Instructores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Instructor>> PostInstructor(Instructor instructor)
        {
            _context.Instructores.Add(instructor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstructor", new { id = instructor.Id }, instructor);
        }

        // DELETE: api/Instructores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstructor(int id)
        {
            var instructor = await _context.Instructores.FindAsync(id);
            if (instructor == null)
            {
                return NotFound();
            }

            _context.Instructores.Remove(instructor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstructorExists(int id)
        {
            return _context.Instructores.Any(e => e.Id == id);
        }
    }
}
