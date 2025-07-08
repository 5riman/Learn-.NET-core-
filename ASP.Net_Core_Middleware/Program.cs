using Microsoft.AspNetCore.Mvc.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello from middleware!\n");
//    await next(context);
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello this is Sriman");
//});


//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );
app.MapControllers();

app.Run();
