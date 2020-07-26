using JWTTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTest
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pais>().HasData(
                new Pais { Nombre = "España", Habitantes = 46000000 },
                new Pais { Nombre = "Alemania", Habitantes = 83000000 },
                new Pais { Nombre = "Francia", Habitantes = 65000000 },
                new Pais { Nombre = "Italia", Habitantes = 61000000 }
                );
        }
    }
}
