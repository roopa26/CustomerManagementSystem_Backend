using CustomerManagementSystem_Backend.Engine;
using CustomerManagementSystem_Backend.Manager;
using CustomerManagementSystem_Backend.Models;
using CustomerManagementSystem_Backend.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
IConfiguration _configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CmsContext>(option =>
{
    option.UseSqlServer(_configuration.GetConnectionString("CmsContext"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICustomerManger,CustomerManager>();
builder.Services.AddTransient<ICustomerEngine,CustomerEngine>();
builder.Services.AddTransient<ICustomerInterface, CustomerRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
