using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
namespace ClassLibraryNetCore
{
    internal class ModelContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KMK5HDT;Database = EfCore2020; Trusted_Connection = True");
        //ChangeTracker.LazyLoadingEnabled = false;
 }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>();
            modelBuilder.Entity<Customer>().HasMany<Order>(o => o.Orders).WithOne(o1 => o1.Customer);
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<Album>().HasMany<Artist>(o => o.Artists);
            modelBuilder.Entity<Artist>().HasMany<Album>(o => o.Albums);
        }
    }
}
