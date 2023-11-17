using EPerfumesFinal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EPerfumesFinal.Data
{
    public class AppDBContext:IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {           
        }
             
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Perfume> Perfumes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
                .HasMany(m => m.Perfumes)
                .WithOne(m => m.Marca)
                .HasForeignKey(m => m.Marca_ID);

            base.OnModelCreating(modelBuilder);
        }
    }

}
