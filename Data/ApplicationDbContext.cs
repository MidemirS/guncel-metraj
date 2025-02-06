using Microsoft.EntityFrameworkCore;

namespace metraj_proje_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Kullanýcý> Kullanýcýlar { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class Kullanýcý
    {
        public int Id { get; set; }
        public string KullanýcýAdý { get; set; }
        public string ÞifreHash { get; set; }
        public string Email { get; set; }
        public DateTime KayýtTarihi { get; set; }
    }
}