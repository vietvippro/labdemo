using labdemo.Models;
using Microsoft.EntityFrameworkCore;

namespace labdemo.Data
{
    public class HọcTapDbcontext : DbContext
    {
        public HọcTapDbcontext(DbContextOptions<HọcTapDbcontext> options)
            : base(options)
        {

        }
        public DbSet<User> User { get; set; }
    }
}
