using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AutomobiliuServisas.Data;
using AutomobiliuServisas.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AutomobiliuServisasContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("AutomobiliuServisasContext")));

builder.Services.AddControllersWithViews();

var app = builder.Build();



using (var scope = app.Services.CreateScope())
{
    var servises = scope.ServiceProvider;
   
    SeedDatacs.Initialize(servises);
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
