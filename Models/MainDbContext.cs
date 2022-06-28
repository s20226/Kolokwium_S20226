using Microsoft.EntityFrameworkCore;

namespace Kolokwium_S20226.Models
{
    public class MainDbContext : DbContext
    {
        protected MainDbContext()
        {

        }

        public MainDbContext(DbContextOptions options) : base(options)
        {

        }

        //DbSety
        //public DbSet<Musician> Musicians { get; set; }
        public DbSet<NazwaTabeli> NazwaTabeli { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //  modelBuilder.ApplyConfiguration(new MusicianConfiguration());
            // modelBuilder.ApplyConfiguration(new MusicianTrackConfiguration());

        }
    }
}