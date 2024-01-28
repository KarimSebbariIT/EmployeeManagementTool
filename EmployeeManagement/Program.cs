using AutoMapper;
using EmployeeManagement.Repositories.Context;
using EmployeeManagement.Repositories.IRepositories;
using EmployeeManagement.Repositories.Repositories;
using EmployeeManagement.Repositories.unitOfWork;
using EmployeeManagement.Services.IServices;
using EmployeeManagement.Services.Mapper;
using EmployeeManagement.Services.Services;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// test
// Add services to the container.
builder.Services.AddDbContext<EmployeeContext>(options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("EmployeeDb")
));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(
      CertificateAuthenticationDefaults.AuthenticationScheme)
      .AddCertificate();
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
app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());

app.Run();
