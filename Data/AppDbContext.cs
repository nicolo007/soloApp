using Microsoft.EntityFrameworkCore;
using solo.Models;

namespace solo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Spese> Spese { get; set; }
        public DbSet<Entrate> Entrate { get; set; }

    }
}
