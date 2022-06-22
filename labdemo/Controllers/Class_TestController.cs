using labdemo.Data;
using labdemo.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace labdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Class_TestController : ControllerBase
    {
        private readonly Context _context;

        public Class_TestController(Context context)
        {
            _context = context;
        }

        // GET: api/Class_Test
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class_Test>>> GetClass_Test()
        {
            if (_context.Class_Test == null)
            {
                return NotFound();
            }
            return await _context.Class_Test.ToListAsync();
        }

        // GET: api/Class_Test/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class_Test>> GetClass_Test(int id)
        {
            if (_context.Class_Test == null)
            {
                return NotFound();
            }
            var class_Test = await _context.Class_Test.FindAsync(id);

            if (class_Test == null)
            {
                return NotFound();
            }

            return class_Test;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass_Test(int id, Class_Test class_Test)
        {
            if (id != class_Test.classTestId)
            {
                return BadRequest();
            }

            _context.Entry(class_Test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Class_TestExists(id))
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
        public async Task<ActionResult<Class_Test>> PostClass_Test(Class_Test class_Test)
        {
            if (_context.Class_Test == null)
            {
                return Problem("Entity set 'Context.Class_Test'  is null.");
            }
            _context.Class_Test.Add(class_Test);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClass_Test", new { id = class_Test.classTestId }, class_Test);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass_Test(int id)
        {
            if (_context.Class_Test == null)
            {
                return NotFound();
            }
            var class_Test = await _context.Class_Test.FindAsync(id);
            if (class_Test == null)
            {
                return NotFound();
            }

            _context.Class_Test.Remove(class_Test);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Class_TestExists(int id)
        {
            return (_context.Class_Test?.Any(e => e.classTestId == id)).GetValueOrDefault();
        }
    }
}
