/*
 * Project: HolaMundoAPI-ASP.NET-Core
 * Author: Byron Almeida Coello
 * Institution: Universidad Técnica Estatal de Quevedo (UTEQ)
 * Career: Ingeniería en Sistemas de Información
 * Course: Bases de la Programación Web
 * Framework: ASP.NET Core Web API (.NET 10)
 * Description: API REST básica que devuelve un mensaje Hola Mundo.
 */
 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();

var app = builder.Build();
 
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Define the GET endpoint /api/hola.
app.MapGet("/api/hola", () =>
{
    return Results.Ok(new
    {
        mensaje = "Hola Mundo",
        lenguaje = "C#",
        framework = "ASP.NET Core Web API"
    });
})
.WithName("GetHola");

app.Run();
