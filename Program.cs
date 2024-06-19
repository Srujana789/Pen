using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pen.Data;
using Pen.Models;
using Orion_Pens.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Orion_PensContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Orion_PensContext") ?? throw new InvalidOperationException("Connection string 'Orion_PensContext' not found.")));
builder.Services.AddDbContext<PenContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PenContext") ?? throw new InvalidOperationException("Connection string 'PenContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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
