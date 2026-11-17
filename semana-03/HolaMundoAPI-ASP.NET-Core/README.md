# HolaMundoAPI

API REST desarrollada con C# y ASP.NET Core Web API como parte de la actividad práctica de la asignatura Bases de la Programación Web.

## Tecnologías utilizadas

- Lenguaje: C#
- Framework: ASP.NET Core Web API
- SDK: .NET 10
- Entorno de desarrollo: Visual Studio Code
- Herramienta de pruebas: Postman

## Requisitos previos

- Windows 10/11.
- .NET 10 SDK.
- Visual Studio Code.
- Postman.

## Instalación y ejecución

1. Clonar el repositorio:

   ```bash
   git clone URL_DEL_REPOSITORIO
   ```

2. Entrar en la carpeta:

   ```bash
   cd HolaMundoAPI
   ```

3. Restaurar dependencias:

   ```bash
   dotnet restore
   ```

4. Ejecutar la aplicación:

   ```bash
   dotnet run --no-launch-profile --urls "http://localhost:5000"
   ```

## Endpoint disponible

| Método | Ruta | Descripción |
|---|---|---|
| GET | /api/hola | Devuelve un mensaje de bienvenida |

## Prueba de la API

URL:

`http://localhost:5000/api/hola`

Respuesta JSON esperada:

```json
{
  "mensaje": "Hola Mundo",
  "lenguaje": "C#",
  "framework": "ASP.NET Core Web API"
}
```

Código HTTP esperado: **200 OK**.

## Autor

Byron Almeida

Proyecto académico – Universidad Técnica Estatal de Quevedo.