using labdemo.Data;
using labdemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace labdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly HọcTapDbcontext _context;

        public ClassController(HọcTapDbcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lophoc>>> GetClasses()
        {
            if (_context.Classes == null)
            {
                return NotFound();
            }
            return await _context.Classes.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Lophoc>> GetClass(string id)
        {
            if (_context.Classes == null)
            {
                return NotFound();
            }
            var @class = await _context.Classes.FindAsync(id);

            if (@class == null)
            {
                return NotFound();
            }

            return @class;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass(string id, Lophoc @class)
        {
            if (id != @class.classId)
            {
                return BadRequest();
            }

            _context.Entry(@class).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassExists(id))
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
        [HttpPost]
        public async Task<ActionResult<Lophoc>> PostClass(Lophoc @class)
        {
            if (_context.Classes == null)
            {
                return Problem("Entity set 'Context.Classes'  is null.");
            }
            _context.Classes.Add(@class);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassExists(@class.classId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClass", new { id = @class.classId }, @class);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(string id)
        {
            if (_context.Classes == null)
            {
                return NotFound();
            }
            var @class = await _context.Classes.FindAsync(id);
            if (@class == null)
            {
                return NotFound();
            }

            _context.Classes.Remove(@class);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassExists(string id)
        {
            return (_context.Classes?.Any(e => e.classId == id)).GetValueOrDefault();
        }
    }
}
