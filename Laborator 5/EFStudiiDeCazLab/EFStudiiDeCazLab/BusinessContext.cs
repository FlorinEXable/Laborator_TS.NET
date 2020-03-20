namespace EFStudiiDeCazLab
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BusinessContext : DbContext
    {
        public BusinessContext()
            : base("name=BusinessContext")
        {
        }
        public DbSet<Business> Businesses{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Business>();
        }
    }

}