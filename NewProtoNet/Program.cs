using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.Interfaces;
using RestServer.Repositories;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n para permitir el almacenamiento de elementos JSON anidados
builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.WriteIndented = true;
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// Configuraci�n promiscua de los CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Se establece la inyecci�n de dependencias para desacoplar el medio de persistencia
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IAdministratorRepository, AdministratorRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IPurchaseRepository, PurchaseRepository>();
builder.Services.AddTransient<IRecepcionistRepository, RecepcionistRepository>();
builder.Services.AddTransient<ISupplierRepository, SupplierRepository>();
builder.Services.AddTransient<IReportRepository, ReportRepository>();

//Dependencias externas David - Robin
builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();
builder.Services.AddTransient<IClientRepository, ClientRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IRequestRepository, RequestRepository>();
builder.Services.AddTransient<IMechanicRepository, MechanicRepository>();
builder.Services.AddTransient<IPayrollRepository, PayrollRepository>();
builder.Services.AddTransient<IInconvenientRepository, InconvenientRepository>();

// Se configura la librer�a que usa el motor de la BD seg�n la cadena que hay en settings.json
/*
builder.Services.AddDbContext<BaseDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnectString"))
);*/

builder.Services.AddDbContext<BaseDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("LocalDBConnectStringMySQL");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllOrigins");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
