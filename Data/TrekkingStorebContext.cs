namespace TrekkingStore.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using TrekkingStore.Data.Models;

    public class TrekkingStorebContext : IdentityDbContext
    {
        public TrekkingStorebContext(DbContextOptions<TrekkingStorebContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; init; }
        public DbSet<Category> Categories { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
