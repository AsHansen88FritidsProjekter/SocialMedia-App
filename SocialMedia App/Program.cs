using Microsoft.EntityFrameworkCore;
using SocialMedia_App.Data;
using SocialMedia_App.Data.Helpers;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Database Confiquration
string dbConnectionString = builder.Configuration.GetConnectionString("Default") ?? "";
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(dbConnectionString));

var app = builder.Build();

//Seed DB with initial data

using (var scope = app.Services.CreateScope()) 
{  
    var DbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await DbContext.Database.MigrateAsync();
    await DBInitiaizer.SeedAsync(DbContext);

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
