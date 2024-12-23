using Microsoft.EntityFrameworkCore;
using StarWarsRoutes.Infrastructure.Contracts;
using StarWarsRoutes.Infrastructure.Impl;
using StarWarsRoutes.Infrastructure.Impl.DBContexts;
using StarWarsRoutes.Library.Contracts;
using StarWarsRoutes.Library.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<ImperialRoutesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ImperialRoutes")));

// External Api
builder.Services.Configure<ExternalServicesClient>(
    builder.Configuration.GetSection("ExternalApis"));

// Register Services
builder.Services.AddScoped<IRouteService, RouteService>();
builder.Services.AddScoped<IPriceCalculatorService, PriceCalculatorService>();
builder.Services.AddScoped<IRouteRepository, RouteRepository>();
builder.Services.AddScoped<IPlanetRepository, PlanetRepository>();
builder.Services.AddHttpClient<IExternalServicesClient, ExternalServicesClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
