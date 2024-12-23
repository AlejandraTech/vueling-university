# 🌟 **Unidad 12: Versionado**

Esta unidad explora cómo gestionar el versionado de una API en un proyecto .NET. Cubriremos la creación de versiones dentro de la API, la configuración de rutas y cómo controlar el ciclo de vida de las versiones.

## 🗂️ **Índice**

| Sección                                           | Descripción                                                                                       |
| ------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| 🔧 **Configuración Inicial**                      | Instalación de paquetes y configuraciones básicas para habilitar el versionado de la API.         |
| 🛠️ **1. Implementación del Versionado**           | Métodos para versionar la API y configurar los controladores para que soporten varias versiones.  |
| 🗂️ **2. Rutas y Métodos Versionados**             | Ejemplos de cómo estructurar las rutas de la API para soportar múltiples versiones.               |
| 🔧 **3. Configuración de Versionado en Routing**  | Cómo configurar el versionado en las rutas usando `ApiVersioning` y cómo actualizar `Startup.cs`. |
| 🗂️ **4. Mejoras en la Documentación con Swagger** | Configuración de Swagger para mostrar las versiones de la API y sus métodos asociados.            |
| 📚 **Referencias**                                | Enlaces a la documentación oficial de ASP.NET Core sobre versionado y buenas prácticas.           |

## 🔧 **Configuración Inicial**

### 1. **Instalar los paquetes necesarios**

Para habilitar el versionado de la API en .NET, necesitamos instalar el paquete `Microsoft.AspNetCore.Mvc.Versioning`, que proporciona el soporte para gestionar las versiones de nuestra API.

Sigue estos pasos en **Visual Studio** para instalar el paquete:

1. Haz clic derecho sobre el proyecto en el **Explorador de Soluciones**.
2. Selecciona **Administrar paquetes NuGet**.
3. En la ventana de NuGet, busca e instala el paquete `Microsoft.AspNetCore.Mvc.Versioning`.

Este paquete nos permite agregar la lógica necesaria para soportar múltiples versiones en nuestra API de forma sencilla.

### 2. **Configurar los servicios de versionado**

Una vez instalado el paquete, es necesario configurar los servicios de versionado en el archivo `Program.cs` (o `Startup.cs` en versiones anteriores de .NET Core).

Agrega la siguiente configuración para habilitar el versionado de la API:

```csharp
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ApiVersionReader = new HeaderApiVersionReader("X-API-Version");
});
```

En este ejemplo:

- `AssumeDefaultVersionWhenUnspecified`: Asume una versión predeterminada (en este caso, 1.0) cuando no se especifica ninguna versión en la solicitud.
- `DefaultApiVersion`: Especifica la versión predeterminada de la API.
- `ApiVersionReader`: Define el encabezado que se utilizará para identificar la versión de la API (en este caso, `X-API-Version`).

## 🛠️ **1. Implementación del Versionado**

### 1. Crear un controlador con múltiples versiones

Para implementar las versiones, basta con añadir el atributo `[ApiVersion]` a los controladores y acciones. A continuación, te muestro cómo hacerlo.

#### Ejemplo de controladores con versión 1.0 y 2.0

1. En la carpeta `Controllers`, crea un archivo `WeatherForecastController.cs`.

```csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ApiVersioning;

namespace NombreProyecto.Controllers
{
    // Versión 1.0 del controlador
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    public class WeatherForecastControllerV1 : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Versión 1.0 de WeatherForecast" });
        }
    }

    // Versión 2.0 del controlador
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    public class WeatherForecastControllerV2 : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Versión 2.0 de WeatherForecast" });
        }
    }
}
```

En este ejemplo:

- **WeatherForecastControllerV1** maneja la versión 1.0.
- **WeatherForecastControllerV2** maneja la versión 2.0.

Ambos controladores tienen el mismo nombre (`WeatherForecastController`), pero con un sufijo diferente para identificar la versión correspondiente.

## 🗂️ **2. Rutas y Métodos Versionados**

### 1. Controladores con rutas versionadas

Para que las rutas sean claras y fáciles de manejar, puedes organizar tus controladores utilizando rutas específicas que indiquen la versión.

#### Ejemplo de rutas para la versión 1.0 y 2.0

```csharp
// Para la versión 1.0
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class WeatherForecastControllerV1 : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Message = "Versión 1.0 de WeatherForecast" });
    }
}

// Para la versión 2.0
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class WeatherForecastControllerV2 : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Message = "Versión 2.0 de WeatherForecast" });
    }
}
```

En este ejemplo:

- **Ruta para v1.0**: `api/v1/WeatherForecast`
- **Ruta para v2.0**: `api/v2/WeatherForecast`

El número de versión se incluye en la URL, haciendo más transparente para los usuarios qué versión están consumiendo.

## 🔧 **3. Configuración de Versionado en Routing**

### 1. Configuración de rutas de versión en `Program.cs`

Además de configurar los servicios de versionado en `Program.cs`, también necesitamos definir cómo .NET debería gestionar el enrutamiento de versiones. Esto se hace utilizando el `ApiVersioning` y especificando que las versiones pueden ser indicadas en la URL.

```csharp
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ApiVersionReader = new UrlApiVersionReader();
});
```

Aquí, el `UrlApiVersionReader` permite que la versión sea parte de la URL (como se mostró en el ejemplo anterior).

### 2. Configuración de las rutas

Puedes gestionar las rutas dentro del controlador utilizando el siguiente formato:

```csharp
[Route("api/v{version:apiVersion}/[controller]")]
```

Esto asegura que las rutas respondan correctamente a las versiones indicadas en la URL.

## 🗂️ **4. Mejoras en la Documentación con Swagger**

Swagger es una excelente herramienta para documentar tu API. Para facilitar la visualización de las versiones de la API, puedes configurarlo para que muestre las diferentes versiones disponibles.

### 1. Configuración de Swagger para Versionado

Agrega la configuración para Swagger en el archivo `Program.cs` o `Startup.cs` para soportar las versiones de la API:

```csharp
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Mi API",
        Version = "v1",
        Description = "API para gestionar el versionado",
        Contact = new OpenApiContact { Name = "Soporte", Email = "soporte@miempresa.com" }
    });

    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Title = "Mi API",
        Version = "v2",
        Description = "Nueva versión de la API",
        Contact = new OpenApiContact { Name = "Soporte", Email = "soporte@miempresa.com" }
    });

    options.DocInclusionPredicate((version, apiDescription) =>
    {
        var versions = apiDescription.ActionDescriptor
            .EndpointMetadata
            .OfType<ApiVersionAttribute>()
            .SelectMany(attribute => attribute.Versions)
            .ToList();

        return versions.Any(v => $"v{v}" == version);
    });
});
```

Esto configura Swagger para mostrar las versiones `v1` y `v2` y filtrar los métodos que pertenecen a cada versión.

## 📚 **Referencias**

- [Documentación de Versionado en ASP.NET Core](https://learn.microsoft.com/aspnet/core/web-api/advanced/versioning)
- [Swagger para Versionado de API](https://learn.microsoft.com/aspnet/core/tutorials/web-api-help-pages-using-swagger)
- [Prácticas recomendadas para versionado de API](https://restfulapi.net/versioning/)
