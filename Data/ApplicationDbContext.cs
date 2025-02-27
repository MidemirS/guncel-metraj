using Microsoft.EntityFrameworkCore;

namespace metraj_proje_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Kullanıcı> Kullanıcılar { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class Kullanıcı
    {
        public int Id { get; set; }
        public string KullanıcıAdı { get; set; }
        public string ŞifreHash { get; set; }
        public string Email { get; set; }
        public DateTime KayıtTarihi { get; set; }
    }
}