using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVien.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SinhVien> SinhViens { get; set; }
    }
}