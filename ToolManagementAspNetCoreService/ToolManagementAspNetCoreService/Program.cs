
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ToolManagementAspNetCoreService.BLL.Services.UserServices;
using ToolManagementAspNetCoreService.BLL.UserServices;
using ToolManagementAspNetCoreService.DAL.Repositories.UserRepository;
using ToolManagementAspNetCoreService.Domain;
using ToolManagementAspNetCoreService.Domain.DBContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
#region DBContext
builder.Services.AddScoped<DbContext, TaskManagementDBContext>();
builder.Services.AddDbContext<TaskManagementDBContext>(optionns =>
            optionns.UseSqlServer(builder.Configuration.GetConnectionString("TaskManagementDBContext")));
#endregion
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "ToolManagement Asp.Net Core Service", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "RoundTheCode.DotNet6 v1");
        c.RoutePrefix = string.Empty;
    });
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

#region User
//Get 
app.MapGet("api/User", (IUserService userService) => userService.Users());
app.MapGet("api/User/{id}", (IUserService userService, int id) => userService.GetByID(id));

//Post
app.MapPost("api/User", (User user, IUserService userService) => userService.Create(user));

//Put
app.MapPut("api/User", (User user, IUserService userService) => userService.Edit(user));

//Delete
app.MapDelete("api/User", (int id, IUserService userService) => userService.Delete(id));
#endregion

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
