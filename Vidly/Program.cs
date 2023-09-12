using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();


app.MapControllerRoute(
    "CustomerDetails",
    "/Home/Customer/Details/{id}",
    new {controller = "Home" , action = "CustomerDetails"}
    );

//app.MapControllerRoute(
//    "MovieByReleaseDate",
//    "movie/released/{year}/{month}",
//    new { controller = "Movie", action = "ByReleaseDate" },

//     //the below validation is not working for .net6 version
//    new { year = "\\d{4}$", month = "\\d{2}$" }
//    ) ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
