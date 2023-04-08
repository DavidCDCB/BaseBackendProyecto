using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Bogus;

// Gestión de migraciones
// https://www.entityframeworktutorial.net/code-first/code-based-migration-in-code-first.aspx
// https://stackoverflow.com/questions/11904571/ef-migrations-rollback-last-applied-migration

// Add-Migration "Nombre"
// get-migration
// remove-migration
// Update-database
// dotnet ef migrations add InitialCreate
// dotnet ef database update

// Relaciones entre entidades:
// https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
// https://geeksarray.com/blog/how-to-configure-entity-relationships-using-fluent-api-in-entity-framework
// https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key

// Consulta e inserción en entidades relacionadas
// https://learn.microsoft.com/en-us/ef/core/saving/related-data?source=recommendations
// https://learn.microsoft.com/en-us/ef/core/querying/related-data/eager?source=recommendations

// Ejemplos para insertar datos dalsos desde las migraciones
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
        public DbSet<Report>? Reports { get; set; }
        public DbSet<Administrator>? Administrators { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Purchase>? Purchases { get; set; }
        public DbSet<Recepcionist>? Recepcionists { get; set; }


        // Se define cada una de la relaciones en cada migración
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        }
    }
