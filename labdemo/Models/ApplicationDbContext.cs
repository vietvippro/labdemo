using Microsoft.EntityFrameworkCore;
namespace labdemo.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Permission> Permission { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<Lophoc> Lop { get; set; }
        public DbSet<Lop_SinhVien> Lop_SinhVien { get; set; }
        public DbSet<Lop_MonHoc> Lop_MonHoc { get; set; }
        public DbSet<HinhThuc> HinhThuc_Thi_KiemTra { get; set; }
        public DbSet<Thi_KiemTra> Thi_KiemTra { get; set; }
        public DbSet<DiemSV> Diem_SinhVien { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DiemSV>().HasOne<User>(P => P.SinhVien).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Lop_SinhVien>().HasOne<User>(P => P.SinhVien).WithMany().OnDelete(DeleteBehavior.NoAction);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);

            }
        }
    }
}
