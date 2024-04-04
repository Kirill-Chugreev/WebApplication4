using Microsoft.AspNetCore.Mvc.ApplicationModels;
using WebApplication4;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}");


//Устанавливаем ограничение на первую букву адреса; обязательно N
app.MapControllerRoute(
        name: "news",
        pattern: "news/{id}",
        defaults: new { controller = "News", action = "Details" },
        constraints: new { id = @"^N.+?" }
    );
app.Run();
