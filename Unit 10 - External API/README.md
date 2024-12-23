# 🌟 **Unidad 10: API Externa**

Esta unidad explica cómo conectar e integrar una API externa en un proyecto utilizando .NET. Incluye la configuración del cliente HTTP, el registro de servicios, la creación de DTOs, y la integración con controladores.

## 🗂️ **Índice**

| Sección                                             | Descripción                                                                                      |
| --------------------------------------------------- | ------------------------------------------------------------------------------------------------ |
| 🔧 **Configuración Inicial**                        | Instrucciones para configurar el archivo `appsettings.json` con la URL base de la API externa.   |
| 🔌 **1. Creación del Cliente HTTP**                 | Pasos para crear una clase cliente que consuma endpoints de la API externa.                      |
| 📦 **2. Registro de Servicios en el IoC Container** | Configuración de `Program.cs` para registrar el cliente y los servicios relacionados.            |
| 📋 **3. Diseño de DTOs para la API**                | Creación de objetos de transferencia de datos (DTOs) para mapear las respuestas de la API.       |
| 🛠️ **4. Creación de Interfaces y Servicios**        | Definición de interfaces y clases de implementación para interactuar con la API externa.         |
| 🌐 **5. Integración con los Controladores**         | Configuración de controladores para exponer los datos obtenidos de la API a través de endpoints. |
| 🗂️ **Estructura de Carpetas con API Externa**       | Organización de carpetas y proyectos al integrar una API externa.                                |
| 📚 **Referencias**                                  | Documentación y recursos adicionales para trabajar con APIs en .NET.                             |

## 🔧 **Configuración Inicial**

1. Abre el archivo `appsettings.json` ubicado en la carpeta `DistributedServices`.
2. Añade la configuración para la URL base de la API externa bajo la clave `ExternalApis`:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ExternalApis": {
    "MyApi": {
      "BaseUrl": "https://api.external-service.com/v1"
    }
  }
}
```

## 🔌 **1. Creación del Cliente HTTP**

1. En la carpeta `Infrastructure/Impl`, crea una subcarpeta llamada `ExternalApis`.
2. Añade una clase `ApiClient` para manejar solicitudes HTTP:

```csharp
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NombreProyecto.Infrastructure.Impl.ExternalApis
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TResponse> GetAsync<TResponse>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TResponse>(content);
        }
    }
}
```

## 📦 **2. Registro de Servicios en el IoC Container**

1. Abre el archivo `Program.cs` en `DistributedServices`.
2. Registra el cliente HTTP y su configuración en el contenedor de inyección de dependencias:

```csharp
builder.Services.AddHttpClient<ApiClient>(client =>
{
    var baseUrl = builder.Configuration["ExternalApis:MyApi:BaseUrl"];
    client.BaseAddress = new Uri(baseUrl);
});
```

## 📋 **3. Diseño de DTOs para la API**

1. En `Library/Contracts`, crea la subcarpeta `DTOs/ExternalApis`.
2. Añade un archivo `ApiResponseDTO.cs` para definir un modelo de datos que coincida con la estructura de la respuesta de la API:

```csharp
namespace NombreProyecto.Library.Contracts.DTOs.ExternalApis
{
    public class ApiResponseDTO
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
    }
}
```

## 🛠️ **4. Creación de Interfaces y Servicios**

### **1. Crear la Interfaz**

1. En `Infrastructure/Contracts`, crea un archivo `IApiService.cs`:

```csharp
using System.Threading.Tasks;
using NombreProyecto.Library.Contracts.DTOs.ExternalApis;

namespace NombreProyecto.Infrastructure.Contracts
{
    public interface IApiService
    {
        Task<ApiResponseDTO> GetDataAsync(string endpoint);
    }
}
```

---

### **2. Implementar el Servicio**

1. En `Infrastructure/Impl/ExternalApis`, añade una clase `ApiService` que implemente `IApiService`:

```csharp
using System.Threading.Tasks;
using NombreProyecto.Library.Contracts.DTOs.ExternalApis;
using NombreProyecto.Infrastructure.Contracts;

namespace NombreProyecto.Infrastructure.Impl.ExternalApis
{
    public class ApiService : IApiService
    {
        private readonly ApiClient _client;

        public ApiService(ApiClient client)
        {
            _client = client;
        }

        public async Task<ApiResponseDTO> GetDataAsync(string endpoint)
        {
            return await _client.GetAsync<ApiResponseDTO>(endpoint);
        }
    }
}
```

---

### **3. Registrar el Servicio**

1. En `Program.cs`, registra la implementación de `IApiService`:

```csharp
builder.Services.AddScoped<IApiService, ApiService>();
```

---

## 🌐 **5. Integración con los Controladores**

1. En `DistributedServices/WebAPIUI/Controllers`, crea un archivo `ApiController.cs`:

```csharp
using Microsoft.AspNetCore.Mvc;
using NombreProyecto.Infrastructure.Contracts;

namespace NombreProyecto.DistributedServices.WebAPIUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly IApiService _apiService;

        public ApiController(IApiService apiService)
        {
            _apiService = apiService;
        }

        [HttpGet("{endpoint}")]
        public async Task<IActionResult> GetData(string endpoint)
        {
            var result = await _apiService.GetDataAsync(endpoint);
            return Ok(result);
        }
    }
}
```

2. Este controlador permite consumir datos de la API externa a través de un endpoint RESTful.

## 🗂️ **Estructura de Carpetas con API Externa**

```plaintext
NombreProyecto
│
├── DistributedServices
│   ├── NombreProyecto.DistributedServices.WebAPIUI
│   │   └── Controllers
│   │       └── ApiController.cs
│   ├── appsettings.json
│   └── Program.cs
│
├── Library
│   ├── NombreProyecto.Library.Contracts
│   │   └── DTOs
│   │       └── ExternalApis
│   │           └── ApiResponseDTO.cs
│   └── NombreProyecto.Library.Impl
│
├── Domain
│   └── NombreProyecto.Domain.Models
│
├── Infrastructure
│   ├── NombreProyecto.Infrastructure.Contracts
│   │   └── IApiService.cs
│   │
│   └── NombreProyecto.Infrastructure.Impl
│       ├── DbContexts
│       └── ExternalApis
│           ├── ApiClient.cs
│           └── ApiService.cs
│
├── XCutting
│   └── NombreProyecto.XCutting.Enums
│
└── Testing
    └── NombreProyecto.Testing.NombreCapa
```

### **Nuevas Carpetas y Archivos Generados**

- **DistributedServices**

  - **`Controllers`**
    - `ApiController.cs`: Controlador para exponer datos de la API externa.

- **Library**

  - **`DTOs/ExternalApis`**
    - `ApiResponseDTO.cs`: DTO para mapear las respuestas de la API externa.

- **Infrastructure**
  - **`Contracts`**
    - `IApiService.cs`: Interfaz para el servicio de la API.
  - **`Impl/ExternalApis`**
    - `ApiClient.cs`: Clase para manejar las solicitudes HTTP.
    - `ApiService.cs`: Implementación del servicio de la API.

## 📚 **Referencias**

- [Documentación oficial de HttpClient](https://learn.microsoft.com/dotnet/api/system.net.http.httpclient)
- [Guía para consumir APIs en .NET](https://learn.microsoft.com/dotnet/csharp/tutorials/console-webapiclient)
- [Uso de System.Text.Json](https://learn.microsoft.com/dotnet/standard/serialization/system-text-json-overview)
