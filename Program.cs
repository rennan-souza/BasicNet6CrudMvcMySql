using Microsoft.EntityFrameworkCore;
using Net6CrudMvcMySql.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Conexão MySQL
builder.Services.AddDbContext<Contexto>(options => options.UseMySql("server=localhost;initial catalog=CRUD_MVC;uid=admin;pwd=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql")));

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
