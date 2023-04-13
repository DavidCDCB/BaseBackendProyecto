using Bogus;
using Bogus.Extensions.Portugal;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

namespace RestServer.Data
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
        public DbSet<Supplier>? Suppliers { get; set; }


        // Se define cada una de la relaciones en cada migración
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // administrador -> usuario
            modelBuilder.Entity<Administrator>()
                .HasOne(v => v.User)
                .WithOne(c => c.Administrator);

            // recepcionista -> usuario
            modelBuilder.Entity<Recepcionist>()
                .HasOne(v => v.User)
                .WithOne(c => c.Recepcionist);

            modelBuilder.Entity<Product>()
                .HasMany(v => v.Purchases)
                .WithOne(c => c.Product);

            modelBuilder.Entity<Supplier>()
                .HasMany(v => v.Purchases)
                .WithOne(c => c.Supplier);

            modelBuilder.Entity<User>().HasData(this.SeedUsers());
            modelBuilder.Entity<Supplier>().HasData(this.SeedSuppliers());
            modelBuilder.Entity<Report>().HasData(this.SeedReports());
            modelBuilder.Entity<Administrator>().HasData(this.SeedAdministrators());
            modelBuilder.Entity<Recepcionist>().HasData(this.SeedRecepcionists());
            modelBuilder.Entity<Product>().HasData(this.SeedProducts());
            modelBuilder.Entity<Purchase>().HasData(this.SeedPurchases());

        }


        List<User> SeedUsers()
        {
            int ids = 1;
            var rol = new[] { "Recepcionist", "Administrator", "Mechanic" };
            Faker<User> fakeData = new Faker<User>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Email, f => f.Person.Email)
              .RuleFor(m => m.Password, f => f.Lorem.Word())
              .RuleFor(m => m.Role, f => f.PickRandom(rol));
            return fakeData.Generate(100);
        }

        List<Supplier> SeedSuppliers()
        {
            int ids = 1;
            Faker<Supplier> fakeData = new Faker<Supplier>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Nit, f => f.Person.Nif())
              .RuleFor(m => m.Name, f => f.Person.FirstName)
              .RuleFor(m => m.Company, f => f.Lorem.Word())
              .RuleFor(m => m.SurName, f => f.Person.LastName)
              .RuleFor(m => m.Phone, f => f.Person.Phone)
              .RuleFor(m => m.Email, f => f.Person.Email)
              .RuleFor(m => m.Address, f => f.Commerce.Department());
            return fakeData.Generate(100);
        }

        List<Report> SeedReports()
        {
            int ids = 1;
            var types = new[] { "Nómina", "Inventario", "Clientes", "Vehiculos" };
            Faker<Report> fakeData = new Faker<Report>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Type, f => f.PickRandom(types));
            return fakeData.Generate(100);
        }

        List<Administrator> SeedAdministrators()
        {
            int ids = 1;
            Faker<Administrator> fakeData = new Faker<Administrator>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Name, f => f.Person.FirstName)
              .RuleFor(m => m.Surname, f => f.Person.LastName)
              .RuleFor(m => m.Phone, f => f.Person.Phone);
            return fakeData.Generate(100);
        }

        List<Recepcionist> SeedRecepcionists()
        {
            int ids = 1;
            Faker<Recepcionist> fakeData = new Faker<Recepcionist>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Name, f => f.Person.FirstName)
              .RuleFor(m => m.Surname, f => f.Person.LastName)
              .RuleFor(m => m.Phone, f => f.Person.Phone)
              .RuleFor(m => m.Address, f => f.Commerce.Department())
              .RuleFor(m => m.Salary, f => f.Random.Float(1000000, 5000000))
              .RuleFor(m => m.Email, f => f.Person.Email);
            return fakeData.Generate(100);
        }

        List<Product> SeedProducts()
        {
            int ids = 1;
            Faker<Product> fakeData = new Faker<Product>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Name, f => f.Commerce.ProductName())
              .RuleFor(m => m.Code, f => f.Commerce.Ean13())
              .RuleFor(m => m.Brand, f => f.Commerce.ProductAdjective())
              .RuleFor(m => m.salePrice, f => f.Random.Float(300000, 700000))
              .RuleFor(m => m.Quantity, f => f.Random.Int(1, 80))
              .RuleFor(m => m.Description, f => f.Commerce.ProductDescription());
            return fakeData.Generate(100);
        }

        List<Purchase> SeedPurchases()
        {
            int ids = 1;
            Faker<Purchase> fakeData = new Faker<Purchase>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.purchasePrice, f => f.Random.Float(100000, 500000))
              .RuleFor(m => m.salePrice, f => f.Random.Float(100000, 500000))
              .RuleFor(m => m.Quantity, f => f.Random.Int(1, 80))
              .RuleFor(m => m.Description, f => f.Commerce.ProductDescription())
              .RuleFor(m => m.Code, f => f.Commerce.Ean13())
              .RuleFor(m => m.datePurchase, f => DateOnly.FromDateTime(f.Date.Past()));
            return fakeData.Generate(100);
        }
    }
}

