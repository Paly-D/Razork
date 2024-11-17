using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieCatalogApi.Entities;
using MovieCatalogApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MovieCatalogDbContext>(
        /*options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection")*/
        options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=F4LOBD;Trusted_Connection=True;MultipleActiveResultSets=true"));

builder.Services.AddScoped<IMovieCatalogDataService, MovieCatalogDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
