using ENA_Rodrigo_Vera_3600.DBConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA_Rodrigo_Vera_3600.Modell
{
    class ConexionDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<ControlMascotas> ControlMascotas { get; set; }
        public DbSet<TablaIntermedia> TablaIntermedia { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vet;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new TablaIntermediaConf(modelBuilder.Entity<TablaIntermedia>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
