// Program.cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "¡Hola Mundo!");
app.MapGet("/api", () => new { Message = "¡Hola desde la API!" });

app.Run();