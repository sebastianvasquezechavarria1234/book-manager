// Program.cs
using ExamenMVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1) A�ade el DbContext ANTES de Build():
builder.Services.AddDbContext<ExamenMvcContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexion"))
);

builder.Services.AddDbContext<CrudSebastianVasquezContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexionCrud"))
);

// 2) A�ade el MVC:
builder.Services.AddControllersWithViews();

// Ahora s� construye la app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Ruta por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
