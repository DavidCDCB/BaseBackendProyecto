using Microsoft.EntityFrameworkCore;
using Domain.Entities;

// https://www.entityframeworktutorial.net/code-first/code-based-migration-in-code-first.aspx

// Add-Migration "Segunda"
// Update-database

// https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
// https://geeksarray.com/blog/how-to-configure-entity-relationships-using-fluent-api-in-entity-framework
// https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key

// https://learn.microsoft.com/en-us/ef/core/saving/related-data?source=recommendations
// https://learn.microsoft.com/en-us/ef/core/querying/related-data/eager?source=recommendations

namespace NewProtoNet.Data
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany<Course>(g => g.Course)
                .WithOne(g => g.Category)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany<Course>(c => c.Courses)
                .WithMany(s => s.Users)
                .UsingEntity(j => j.ToTable("UserCourses"));

        }
    }
}
