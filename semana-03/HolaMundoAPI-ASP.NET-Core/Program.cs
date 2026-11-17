
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
