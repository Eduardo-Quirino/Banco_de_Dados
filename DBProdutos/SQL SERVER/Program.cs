using Microsoft.EntityFrameworkCore;
using SQL_SERVER.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//String de Coneção Banco MySQL Server
builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer("Server=DESKTOP-A9OU9P7\\SQLEXPRESS; DataBase=DB_Produtos; User Id=sa; Password=WEBquirino1218"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
