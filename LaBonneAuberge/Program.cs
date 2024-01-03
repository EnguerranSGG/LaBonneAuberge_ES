using LaBonneAuberge.Data;
using Microsoft.EntityFrameworkCore;
using LaBonneAuberge.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LaBonneAubergeContext>(options=>
options.UseSqlite(builder.Configuration.GetConnectionString("LaBonneAubergeContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LaBonneAubergeContext>(options=>
options.UseSqlite(builder.Configuration.GetConnectionString("LaBonneAubergeContext")?? throw new InvalidOperationException("Connection string 'TodoListContext' not found.")));
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
