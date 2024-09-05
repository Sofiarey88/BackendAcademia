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
    public class RitmosController : ControllerBase
    {
        private readonly ACADEMIAContext _context;

        public RitmosController(ACADEMIAContext context)
        {
            _context = context;
        }

        // GET: api/Ritmos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ritmo>>> GetRitmos()
        {
            return await _context.Ritmos.ToListAsync();
        }

        // GET: api/Ritmos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ritmo>> GetRitmo(int id)
        {
            var ritmo = await _context.Ritmos.FindAsync(id);

            if (ritmo == null)
            {
                return NotFound();
            }

            return ritmo;
        }

        // PUT: api/Ritmos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRitmo(int id, Ritmo ritmo)
        {
            if (id != ritmo.Id)
            {
                return BadRequest();
            }

            _context.Entry(ritmo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RitmoExists(id))
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

        // POST: api/Ritmos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ritmo>> PostRitmo(Ritmo ritmo)
        {
            _context.Ritmos.Add(ritmo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRitmo", new { id = ritmo.Id }, ritmo);
        }

        // DELETE: api/Ritmos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRitmo(int id)
        {
            var ritmo = await _context.Ritmos.FindAsync(id);
            if (ritmo == null)
            {
                return NotFound();
            }

            _context.Ritmos.Remove(ritmo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RitmoExists(int id)
        {
            return _context.Ritmos.Any(e => e.Id == id);
        }
    }
}
