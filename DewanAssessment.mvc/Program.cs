using System.Text;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System;
using System.Collections.Immutable;
// using Microsoft.EntityFrameworkCore;
using DewanAssessment.mvc.Context;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using DewanAssessment.mvc.Ripository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("mysql");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))));


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(IBaseRipository<>),typeof(BaseRipository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseMySql(connectionString , ServerVersion.AutoDetect(connectionString))); //  ServiceLifetime.Scoped);  Adjust lifetime as needed

// builder.Services.AddDbContext<AppDbContext>(options =>
//  options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
