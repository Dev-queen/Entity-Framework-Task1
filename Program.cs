using DotNet_Template1.Data;
using DotNet_Template1.Repistories;
using DotNet_Template1.Repistories.Interfaces;
using DotNet_Template1.Services;
using DotNet_Template1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


//builder.Services.AddSingleton<IProductRepistory, ProductRepistory>();
//builder.Services.AddSingleton<IProductServices, ProductServices>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepistory, UserRepistory>();

builder.Services.AddScoped<ITasksRepository, TasksRepository>();
builder.Services.AddScoped<ITasksService, TasksService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


