using Microsoft.EntityFrameworkCore;
using SchoolSystem.Application.Services;
using SchoolSystem.Core.Interfaces;
using SchoolSystem.Infrastructure.Repositories;
using SchoolSystem.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews(); // Add MVC services

// Register repositories
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IClassRoomRepository, ClassRoomRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();

// Register IClassRoomRepository

// Register services
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<ClassService>(); // Add this line to register ClassService
builder.Services.AddScoped<TeacherService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
        pattern: "{controller=Home}/{action=Index}"); // Default routing for MVC

app.Run();
