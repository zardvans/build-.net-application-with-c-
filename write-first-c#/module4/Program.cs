var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    Console.WriteLine("This is the first line.");
    Console.WriteLine("This is the second line.");
});

app.Run();
