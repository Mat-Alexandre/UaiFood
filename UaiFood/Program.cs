using Microsoft.EntityFrameworkCore;
using UaiFood.Context;
using UaiFood.Controllers;

var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
// Add services to the container.
builder.Services.AddDbContext<OrganizationContext>(options => options.UseNpgsql(
    configuration["Connnectionstrings:OrganizationDBConnection"])
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

#region Endpoit definitions

// This endpoint should be accessible only for authorized users
app.MapPost("/api/organizationemployee", OrganizationEmployeesController.CreateEmployee);
app.MapGet("/api/organizationemployee", OrganizationEmployeesController.GetEmployee);

#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();