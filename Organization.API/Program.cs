using Microsoft.EntityFrameworkCore;
using Organization.Core;
using Organization.Core.Repositories;
using Organization.Core.Services;
using Organization.Data;
using Organization.Data.Repositories;
using Organization.Service;
using System.Text.Json.Serialization;
//First part- builder------------------------------------------------
var builder = WebApplication.CreateBuilder(args);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var policy = "policy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

//:עבור כל אובייקט שתי תלויות
//service
//repository
//Employee
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//Role
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddDbContext<DataContext>();
//Second part- app--------------------------------------------------
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// In Configure method of Startup.cs
app.UseCors(policy);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//Finall part- up in the air --------------------
app.Run();