using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Repositories;
using StudentManagement.Repositories.Context;
using StudentManagement.Repositories.IRepository;
using StudentManagement.Repositories.Repository;
using StudentManagement.Services;
using StudentManagement.Services.IServices;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StudentManagementContext>(options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("StudentManagementConnection")
));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(
      CertificateAuthenticationDefaults.AuthenticationScheme)
      .AddCertificate();
//Service injection
builder.Services.AddScoped<IStudentService, StudentService>();
//Repositories Ijnection
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

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
