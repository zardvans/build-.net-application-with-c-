var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    // Console.WriteLine("Hello World");
    // Console.Write("Congratulations!");
    // Console.Write(" ");
    // Console.Write("You wrote your first lines of code.");    
    Console.WriteLine("Congrats!");
    Console.Write("You wrote your first lines of code.");
});

app.Run(); 
