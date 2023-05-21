using Microsoft.EntityFrameworkCore;
using Bogus;
using Domain.Entities.Base;
using Domain.Entities;
using Bogus.Extensions.Portugal;
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

namespace RestServer.Data
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
        public DbSet<Client>? Clients { get; set; }
        public DbSet<Vehicle>? Vehicles { get; set; }
        public DbSet<Request>? Requests { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Supplier>? Suppliers { get; set; }

    public DbSet<User>? Users { get; set; }
    public DbSet<Course>? Courses { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Report>? Reports { get; set; }
    public DbSet<Administrator>? Administrators { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Purchase>? Purchases { get; set; }
    public DbSet<Recepcionist>? Recepcionists { get; set; }
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

      modelBuilder.Entity<Category>()
        .HasMany(g => g.Course)
        .WithOne(g => g.Category)
        .HasForeignKey(s => s.CategoryId)
        .OnDelete(DeleteBehavior.Cascade);
      // Cliente->Solicitudes
      modelBuilder.Entity<Client>()
        .HasMany(v => v.Requests)
        .WithOne(c => c.Client);

      // Servicio->Solicitudes
      modelBuilder.Entity<Service>()
        .HasMany(v => v.Requests)
        .WithOne(c => c.Service);

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

      modelBuilder.Entity<Client>().HasData(this.SeedClients());
      modelBuilder.Entity<Supplier>().HasData(this.SeedSuppliers());
      modelBuilder.Entity<Vehicle>().HasData(this.SeedVehicles());
      modelBuilder.Entity<Service>().HasData(this.SeedServices());
      modelBuilder.Entity<Request>().HasData(this.SeedRequests());

      // recepcionista -> usuario
      modelBuilder.Entity<Recepcionist>()
          .HasOne(v => v.User)
          .WithOne(c => c.Recepcionist);

      modelBuilder.Entity<Product>()
          .HasMany(v => v.purchases)
          .WithOne(c => c.Product);

            //mechanic -> request 
            //TODO: relacion de muchos a muchos
            modelBuilder.Entity<Request>()
              .HasMany(c => c.Mechanics)
              .WithMany(s => s.Requests)
              .UsingEntity(j => j.ToTable("RequestMechanic"));
      modelBuilder.Entity<Supplier>()
          .HasMany(v => v.purchases)
          .WithOne(c => c.Supplier);

            //mechanic -> payroll
            //TODO: relacion de muchos a muchos
            modelBuilder.Entity<Mechanic>()
              .HasMany(c => c.Payrolls)
              .WithMany(s => s.Mechanics)
              .UsingEntity(j => j.ToTable("PayrollMechanic"));

            //request -> inconvenients
            modelBuilder.Entity<Request>()
                .HasMany(v => v.Inconvenients)
                .WithOne(c => c.Request);
      modelBuilder.Entity<User>().HasData(this.SeedUsers());
      modelBuilder.Entity<Supplier>().HasData(this.SeedSuppliers());
      modelBuilder.Entity<Report>().HasData(this.SeedReports());
      modelBuilder.Entity<Administrator>().HasData(this.SeedAdministrators());
      modelBuilder.Entity<Recepcionist>().HasData(this.SeedRecepcionists());
      modelBuilder.Entity<Product>().HasData(this.SeedProducts());
      modelBuilder.Entity<Purchase>().HasData(this.SeedPurchases());
            modelBuilder.Entity<Client>().HasData(this.SeedClients());
            modelBuilder.Entity<Supplier>().HasData(this.SeedSuppliers());
            modelBuilder.Entity<Vehicle>().HasData(this.SeedVehicles());
            modelBuilder.Entity<Service>().HasData(this.SeedServices());
            modelBuilder.Entity<Request>().HasData(this.SeedRequests());

            modelBuilder.Entity<Mechanic>().HasData(this.SeedMechanics());
            modelBuilder.Entity<Inconvenient>().HasData(this.SeedInconvenients());
            modelBuilder.Entity<Payroll>().HasData(this.SeedPayrolls());
            /*
            modelBuilder.Entity<User>()
              .HasMany(c => c.Courses)
              .WithMany(s => s.Users)
              .UsingEntity(j => j.ToTable("UserCourses"));

            // Se usa en caso de usar datos por defecto cuando se hace una migración
            modelBuilder.Entity<User>().HasData(this.SeedUsers());*/


    }

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
        .RuleFor(m => m.EndDate, f => DateOnly.FromDateTime(f.Date.Future()))
        .RuleFor(m => m.State, f => f.PickRandom(states))
        .RuleFor(m => m.ServiceId, f => f.Random.Number(1, 99))
        .RuleFor(m => m.ClientId, f => f.Random.Number(1, 99));
      return fakeData.Generate(100);
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
        .RuleFor(m => m.Nit, f => f.Random.Number(1, 999).ToString())
        .RuleFor(m => m.Name, f => f.Person.FirstName)
        .RuleFor(m => m.Company, f => f.Lorem.Word())
        .RuleFor(m => m.SurName, f => f.Person.LastName)
        .RuleFor(m => m.Phone, f => f.Person.Phone)
        .RuleFor(m => m.Email, f => f.Person.Email)
        .RuleFor(m => m.Address, f => f.Commerce.Department());
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
    List<Report> SeedReports()
    {
      int ids = 1;
      var types = new[] { "Nómina", "Inventario", "Clientes", "Vehiculos" };
      Faker<Report> fakeData = new Faker<Report>("es_MX")
        .RuleFor(m => m.Id, f => ids++)
        .RuleFor(m => m.Type, f => f.PickRandom(types));
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

        List<Inconvenient> SeedInconvenients()
        {
            int ids = 1;
            var states = new[] { "Mecanico", "Financiero", "Social", "Tiempo" };
            Faker<Inconvenient> fakedata = new Faker<Inconvenient>("es_MX")
              .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.DateAct, f => DateOnly.FromDateTime(f.Date.Past()))
              .RuleFor(m => m.State, f => f.PickRandom(states))
              .RuleFor(m => m.DaysDelay, f => f.Random.Number(1, 20))
              .RuleFor(m => m.ServiceRequesedId, f => f.Random.Number(1, 99))
              .RuleFor(m => m.Seen, f => f.Random.Bool())
              .RuleFor(m => m.Description, f => f.Name.JobDescriptor())
              .RuleFor(m => m.RequestID, f => f.Random.Number(1, 99));
            return fakedata.Generate(100);
        }

        List<Payroll> SeedPayrolls()
        {
            int ids = 1;
            Faker<Payroll> fakedata = new Faker<Payroll>("es_MX")
                .RuleFor(m => m.Id, f => ids++)
                .RuleFor(m => m.StarDate, f => DateOnly.FromDateTime(f.Date.Past()))
                .RuleFor(m => m.EndDate, f => DateOnly.FromDateTime(f.Date.Past()))
                .RuleFor(m => m.Description, f => f.Name.JobDescriptor())
                .RuleFor(m => m.Accruals, f => (double)f.Finance.Amount())
                .RuleFor(m => m.Deductions, f => (double)f.Finance.Amount())
                .RuleFor(m => m.Settlement, f => (double)f.Finance.Amount());
            return fakedata.Generate(100);

        }
    }

}
