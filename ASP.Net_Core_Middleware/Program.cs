var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from middleware!\n");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello this is Sriman");
});


//app.MapGet("/", () => "Hello World!");

app.Run();
