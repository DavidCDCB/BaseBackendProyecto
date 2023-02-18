using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Bogus;

// https://www.entityframeworktutorial.net/code-first/code-based-migration-in-code-first.aspx

// Add-Migration "Nombre"
// Update-database
// dotnet ef migrations add InitialCreate
// dotnet ef database update

// https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
// https://geeksarray.com/blog/how-to-configure-entity-relationships-using-fluent-api-in-entity-framework
// https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key

// https://learn.microsoft.com/en-us/ef/core/saving/related-data?source=recommendations
// https://learn.microsoft.com/en-us/ef/core/querying/related-data/eager?source=recommendations

// https://khalidabuhakmeh.com/seed-entity-framework-core-with-bogus
// https://coderethinked.com/how-to-generate-fake-data-in-csharp/
// https://www.learnentityframeworkcore.com/migrations/seeding
// https://medium.com/scrum-and-coke/quick-proof-of-concept-asp-net-core-web-api-using-swashbuckle-aspnetcore-and-bogus-19977c84d4a2

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

        // Se define cada una de la relaciones en cada migración
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

            // Se usa en caso de usar datos por defecto cuando se hace una migración
            //modelBuilder.Entity<User>().HasData(this.SeedUsers());
        }

        List<User> SeedUsers()
        {
            int ids = 1;
            Faker<User> fakeData = new Faker<User>()
                .RuleFor(m => m.Id, f => ids++)
                .RuleFor(m => m.FullName, f => f.Person.FullName)
                .RuleFor(m => m.Email, f => f.Person.Email)
                .RuleFor(m => m.Phone, f => f.Random.Number(100, 10000));
            return fakeData.Generate(10);
        }
    }
}
