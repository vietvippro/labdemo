using labdemo.Data;
using labdemo.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace labdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAccountController : ControllerBase
    {
        private readonly Context _context;

        public AdminAccountController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminAccount>>> GetAdminAccounts()
        {
            if (_context.AdminAccounts == null)
            {
                return NotFound();
            }
            return await _context.AdminAccounts.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminAccount>> GetAdminAccount(string id)
        {
            if (_context.AdminAccounts == null)
            {
                return NotFound();
            }
            var adminAccount = await _context.AdminAccounts.FindAsync(id);

            if (adminAccount == null)
            {
                return NotFound();
            }

            return adminAccount;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminAccount(string id, AdminAccount adminAccount)
        {
            if (id != adminAccount.userName)
            {
                return BadRequest();
            }

            _context.Entry(adminAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminAccountExists(id))
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
        public async Task<ActionResult<AdminAccount>> PostAdminAccount(AdminAccount adminAccount)
        {
            if (_context.AdminAccounts == null)
            {
                return Problem("Entity set 'Context.AdminAccounts'  is null.");
            }
            _context.AdminAccounts.Add(adminAccount);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AdminAccountExists(adminAccount.userName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAdminAccount", new { id = adminAccount.userName }, adminAccount);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminAccount(string id)
        {
            if (_context.AdminAccounts == null)
            {
                return NotFound();
            }
            var adminAccount = await _context.AdminAccounts.FindAsync(id);
            if (adminAccount == null)
            {
                return NotFound();
            }

            _context.AdminAccounts.Remove(adminAccount);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool AdminAccountExists(string id)
        {
            return (_context.AdminAccounts?.Any(e => e.userName == id)).GetValueOrDefault();
        }
    }
}
