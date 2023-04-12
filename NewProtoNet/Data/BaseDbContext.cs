using Microsoft.EntityFrameworkCore;
using Bogus;
using Domain.Entities.Base;
using Domain.Entities;
using System.Security.Policy;
using System.Data;

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

        public DbSet<Client>? Clients { get; set; }
        public DbSet<Vehicle>? Vehicles { get; set; }
        public DbSet<Request>? Requests { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Supplier>? Suppliers { get; set; }

        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }

        public DbSet<Mechanic>? Mechanics { get; set; }
        public DbSet<Inconvenient>? Inconvenients { get; set; }
        public DbSet<Payroll>? Payrolls { get; set; }



        // Se define cada una de la relaciones en cada migración
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cliente->Vehiculos
            modelBuilder.Entity<Client>()
              .HasMany(v => v.Vehicles)
              .WithOne(c => c.Client);

            // Cliente->Solicitudes
            modelBuilder.Entity<Client>()
              .HasMany(v => v.Requests)
              .WithOne(c => c.Client);

            // Servicio->Solicitudes
            modelBuilder.Entity<Service>()
              .HasMany(v => v.Requests)
              .WithOne(c => c.Service);


            //mechanic -> request 
            //TODO: relacion de muchos a muchos


            //mechanic -> payroll
            //TODO: relacion de muchos a muchos

            //request -> inconvenients
            modelBuilder.Entity<Request>()
                .HasMany(v => v.Inconvenient)
                .WithOne(c => c.Request);


            // Preveedor->Compras
            // ...

            modelBuilder.Entity<Client>().HasData(this.SeedClients());
            modelBuilder.Entity<Supplier>().HasData(this.SeedSuppliers());
            modelBuilder.Entity<Vehicle>().HasData(this.SeedVehicles());
            modelBuilder.Entity<Service>().HasData(this.SeedServices());
            modelBuilder.Entity<Request>().HasData(this.SeedRequests());

            /*
            modelBuilder.Entity<User>()
              .HasMany(c => c.Courses)
              .WithMany(s => s.Users)
              .UsingEntity(j => j.ToTable("UserCourses"));

            // Se usa en caso de usar datos por defecto cuando se hace una migración
            modelBuilder.Entity<User>().HasData(this.SeedUsers());*/
        }

        // https://github.com/bchavez/Bogus
        List<Client> SeedClients()
        {
            int ids = 1;
            Faker<Client> fakeData = new Faker<Client>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Name, f => f.Person.FirstName)
              .RuleFor(m => m.Surname, f => f.Person.LastName)
              .RuleFor(m => m.Phone, f => f.Person.Phone)
              .RuleFor(m => m.Email, f => f.Person.Email)
              .RuleFor(m => m.Address, f => f.Person.Address.Street)
              .RuleFor(m => m.Type, f => f.Lorem.Word());
            return fakeData.Generate(100);
        }

        List<Supplier> SeedSuppliers()
        {
            int ids = 1;
            Faker<Supplier> fakeData = new Faker<Supplier>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Nit, f => f.Random.Number(100, 1000).ToString())
              .RuleFor(m => m.Name, f => f.Person.FirstName)
              .RuleFor(m => m.SurName, f => f.Person.LastName)
              .RuleFor(m => m.Phone, f => f.Person.Phone)
              .RuleFor(m => m.Email, f => f.Person.Email)
              .RuleFor(m => m.Address, f => f.Person.Address.Street)
              .RuleFor(m => m.Company, f => f.Company.CompanyName());
            return fakeData.Generate(100);
        }

        List<Vehicle> SeedVehicles()
        {
            int ids = 1;
            var years = new[] { "2020", "2021", "2019", "2018", "2015" };
            Faker<Vehicle> fakeData = new Faker<Vehicle>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Plate, f => f.Vehicle.Vin())
              .RuleFor(m => m.Model, f => f.Vehicle.Model())
              .RuleFor(m => m.Year, f => f.PickRandom(years))
              .RuleFor(m => m.Description, f => f.Vehicle.Type())
              .RuleFor(m => m.Color, f => f.Commerce.Color())
              .RuleFor(m => m.ClientId, f => f.Random.Number(1, 99));
            return fakeData.Generate(100);
        }

        List<Service> SeedServices()
        {
            int ids = 1;
            Faker<Service> fakeData = new Faker<Service>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Name, f => f.Lorem.Word())
              .RuleFor(m => m.Category, f => f.Lorem.Word())
              .RuleFor(m => m.Description, f => f.Lorem.Sentence(5))
              .RuleFor(m => m.Price, f => (double)f.Finance.Amount());
            return fakeData.Generate(100);
        }

        List<Request> SeedRequests()
        {
            int ids = 1;
            var states = new[] { "Activo", "Terminado" };
            Faker<Request> fakeData = new Faker<Request>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.StarDate, f => DateOnly.FromDateTime(f.Date.Past()))
              .RuleFor(m => m.EndDate, f => DateOnly.FromDateTime(f.Date.Past()))
              .RuleFor(m => m.State, f => f.PickRandom(states))
              .RuleFor(m => m.ServiceId, f => f.Random.Number(1, 99));
            return fakeData.Generate(100);
        }

        List<Mechanic> SeedMechanics()
        {
            int ids = 1;
            var roles = new[] { "Master", "Junior", "Aprendiz" };
            var commision = new[] { 20, 30, 40 };
            Faker<Mechanic> fakeData = new Faker<Mechanic>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.Name, f => f.Person.FirstName)
              .RuleFor(m => m.SurName, f => f.Person.LastName)
              .RuleFor(m => m.Phone, f => f.Person.Phone)
              .RuleFor(m => m.Role, f => f.PickRandom(roles))
              .RuleFor(m => m.Email, f => f.Person.Email)
              .RuleFor(m => m.Address, f => f.Person.Address.Street)
              .RuleFor(m => m.Commission, f => f.PickRandom(commision))
              .RuleFor(m => m.Salary, f => (double)f.Finance.Amount())
              .RuleFor(m => m.UserId, f => f.Random.Number(1, 99));
            return fakeData.Generate(100);
        }

        // TODO: falta semilla payroll
        //.RuleFor(m => m.Date, f => DateOnly.FromDateTime(f.Date.Past()))
        //List<Inconvenient> SeedInconvenients()
        //{
        //    int ids = 1;
        //    var states = new[] { "Mecanico", "Financiero", "Social", "Tiempo" };
        //    Faker<Inconvenient> fakedata = new Faker<Inconvenient>("es_MX")
        //      .RuleFor(m => m.Id, f => ids++)
        //      .RuleFor(m => m.Date, f => DateOnly.FromDateTime(f.Date.Past()))
        //      .RuleFor(m => m.State, f => f.PickRandom(states))
        //      .RuleFor(m => m.DaysDelay, f => f.Random.Number(1, 20))
        //      .RuleFor(m => m.ServiceRequesedId, f => f.Random.Number(1, 99))
        //      .RuleFor(m => m.Seen, f => f.Random.Bool())
        //      .RuleFor(m => m.Description, f => f.Name.JobDescriptor())
        //      .RuleFor(m => m.RequestID, f => f.Random.Number(1, 99));
        //    return fakeData.Generate(100);
        //}

    }
}
