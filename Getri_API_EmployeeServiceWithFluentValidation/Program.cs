using FluentValidation.AspNetCore;
using Getri_API_EmployeeServiceWithFluentValidation.EntityFramework;
using Getri_API_EmployeeServiceWithFluentValidation.Repository;
using Getri_API_EmployeeServiceWithFluentValidation.Validation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EmployeeDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeConnection")));
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddFluentValidation(
                                    m => { 
                                        m.RegisterValidatorsFromAssemblyContaining<EmployeeValidation>(); 
                                    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
