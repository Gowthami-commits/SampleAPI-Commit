using Microsoft.EntityFrameworkCore;
using SampleAPI.Model;

namespace SampleAPI.DataBaseDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options){ }

        public ApplicationDbContext() { }

        public virtual DbSet<Cities> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("Cities", "dbo"); 
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
