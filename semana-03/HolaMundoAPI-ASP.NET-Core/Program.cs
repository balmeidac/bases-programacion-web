/*
 * Project: HolaMundoAPI-ASP.NET-Core
 * Authors: Byron Almeida, Thalia Andrade y Yaritza Mora
 * Institution: Universidad Técnica Estatal de Quevedo (UTEQ)
 * Career: Ingeniería en Sistemas de Información
 * Course: Bases de la Programación Web
 * Framework: ASP.NET Core Web API (.NET 10)
 * Description: API REST básica que devuelve un mensaje Hola Mundo.
 */
 
var builder = WebApplication.CreateBuilder(args);

// Registra los controladores
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Conecta las rutas de los controladores
app.MapControllers();

app.Run();
