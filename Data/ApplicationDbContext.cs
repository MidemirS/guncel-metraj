using Microsoft.EntityFrameworkCore;

namespace metraj_proje_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Kullan�c�> Kullan�c�lar { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class Kullan�c�
    {
        public int Id { get; set; }
        public string Kullan�c�Ad� { get; set; }
        public string �ifreHash { get; set; }
        public string Email { get; set; }
        public DateTime Kay�tTarihi { get; set; }
    }
}