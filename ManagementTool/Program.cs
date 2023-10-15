using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ManagementTool.Areas.Identity.Data;
using System.Reflection.Metadata;
using ManagementTool.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ManagementToolDBContextConnection") ?? throw new InvalidOperationException("Connection string 'ManagementToolDBContextConnection' not found.");
var connectionStringCustom = builder.Configuration.GetConnectionString("ManagementToolCustomDBContextConnection") ?? throw new InvalidOperationException("Connection string 'ManagementToolCustomDBContextConnection' not found.");

builder.Services.AddDbContext<ManagementToolDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ManagementToolCustomDBContext>(options =>
    options.UseSqlServer(connectionStringCustom));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ManagementToolDBContext>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();


