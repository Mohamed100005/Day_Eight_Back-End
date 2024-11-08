using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.Models;

namespace P01_SalesDatabase.Data {
    internal class ApplicationDbContext : DbContext {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Saless { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-LDMHIRF\\SQLEXPRESS;Database=SalesDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(e => e.Name).HasMaxLength(50).IsUnicode(true);
            modelBuilder.Entity<Product>().Property(e => e.Price).HasPrecision(10, 2);
            modelBuilder.Entity<Customer>().Property(e => e.Name).HasMaxLength(100).IsUnicode(true);
            modelBuilder.Entity<Customer>().Property(e => e.Email).HasMaxLength(80).IsUnicode(false);
            modelBuilder.Entity<Store>().Property(e => e.Name).HasMaxLength(80).IsUnicode(true);
        }
    }
}
