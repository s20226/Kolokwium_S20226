using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<NazwaTabeli>(e =>
            //{

            //});

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NazwaTabeli>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Nazwa ).IsRequired().HasMaxLength();

                e.HasData(
                    new NazwaTabeli {
                    
                    },
                    new NazwaTabeli { 

                    }
                    );
            });

        }
    }
}