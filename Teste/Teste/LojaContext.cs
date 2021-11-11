using Microsoft.EntityFrameworkCore;
using System;

namespace Teste {
    public class LojaContext : DbContext {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=True;");
        }
    }
}