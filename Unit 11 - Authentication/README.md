# 🌟 **Unidad 11: Autenticación**

Esta unidad aborda la implementación de un sistema de autenticación en un proyecto utilizando .NET. Se cubren aspectos como la configuración de la autenticación basada en JWT (JSON Web Tokens), la creación de un servicio para generar y validar tokens, la configuración de middleware, y la protección de endpoints.

### 🗂️ **Índice**

| Sección                                         | Descripción                                                                                                |
| ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| 🔧 **Configuración Inicial**                    | Instalación de paquetes y ajustes en `appsettings.json` para manejar autenticación con JWT.                |
| 🔐 **1. Generación de Tokens JWT**              | Creación de un servicio para generar y validar tokens JWT en el proyecto.                                  |
| 📦 **2. Configuración de Servicios en IoC**     | Registro de servicios de autenticación y autorización en el contenedor de inyección de dependencias (IoC). |
| 🛡️ **3. Middleware de Autenticación**           | Implementación de middleware para validar usuarios autenticados.                                           |
| 🔒 **4. Protección de Endpoints**               | Ejemplo de cómo proteger endpoints con autenticación y autorización.                                       |
| 🗂️ **Estructura de Carpetas con Autenticación** | Organización del proyecto para integrar la autenticación en .NET.                                          |
| 📚 **Referencias**                              | Enlaces a la documentación oficial de autenticación en .NET y JWT.                                         |

## 🔧 **Configuración Inicial**

### 1. **Instalar los paquetes necesarios**

Para empezar a trabajar con autenticación JWT en .NET, necesitas instalar los siguientes paquetes NuGet:

1. **Microsoft.AspNetCore.Authentication.JwtBearer**: Este paquete permite la autenticación utilizando JWT.
2. **System.IdentityModel.Tokens.Jwt**: Este paquete es necesario para la creación y validación de los tokens JWT.

Puedes instalar estos paquetes desde Visual Studio de la siguiente forma:

- Haz clic derecho en el proyecto desde el **Explorador de Soluciones**.
- Selecciona **Administrar paquetes NuGet**.
- Busca e instala los siguientes paquetes:
  - `Microsoft.AspNetCore.Authentication.JwtBearer`
  - `System.IdentityModel.Tokens.Jwt`

---

### 2. **Configurar JWT en `appsettings.json`**

Agrega la configuración de JWT en el archivo `appsettings.json`. Este archivo debe contener las claves necesarias para emitir tokens, como la clave secreta, el emisor, y el receptor.

Ejemplo de configuración:

```json
{
  "JwtSettings": {
    "SecretKey": "TuClaveSecretaMuySegura123!",
    "Issuer": "NombreProyecto",
    "Audience": "NombreProyectoUsuarios",
    "TokenExpirationMinutes": 60
  }
}
```

## 🔐 **1. Generación de Tokens JWT**

Para generar y validar tokens JWT, crea un servicio que maneje la creación del token. A continuación, se muestra cómo hacerlo.

### 1. Crear el servicio `JwtTokenService`

1. En la carpeta `Infrastructure/Impl/Authentication`, crea un archivo llamado `JwtTokenService.cs`.

2. El código del servicio se encargará de generar el token JWT a partir de un `userId` y `userName`, además de manejar la configuración necesaria.

```csharp
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace NombreProyecto.Infrastructure.Impl.Authentication
{
    public class JwtTokenService
    {
        private readonly string _secretKey;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly int _expirationMinutes;

        public JwtTokenService(IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            _secretKey = jwtSettings["SecretKey"];
            _issuer = jwtSettings["Issuer"];
            _audience = jwtSettings["Audience"];
            _expirationMinutes = int.Parse(jwtSettings["TokenExpirationMinutes"]);
        }

        public string GenerateToken(string userId, string userName)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId),
                new Claim(JwtRegisteredClaimNames.UniqueName, userName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _issuer,
                _audience,
                claims,
                expires: DateTime.UtcNow.AddMinutes(_expirationMinutes),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
```

Este servicio toma los parámetros de configuración definidos en el archivo `appsettings.json` y genera un token JWT utilizando la clave secreta para firmarlo.

## 📦 **2. Configuración de Servicios en IoC**

En esta sección, configuramos los servicios en el contenedor de inyección de dependencias (IoC) de .NET para que estén disponibles en toda la aplicación.

### 1. Registrar el servicio `JwtTokenService`

1. Abre el archivo `Program.cs` y agrega el siguiente código para registrar el servicio `JwtTokenService`:

```csharp
builder.Services.AddSingleton<JwtTokenService>();
```

---

### 2. Configurar la autenticación en `Program.cs`

Después de registrar el servicio, necesitas configurar el middleware de autenticación JWT. Esto permite que .NET valide el token enviado en cada solicitud.

```csharp
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    var jwtSettings = builder.Configuration.GetSection("JwtSettings");
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]))
    };
});

builder.Services.AddAuthorization();
```

Este código configura el middleware para usar JWT y validar el token en cada solicitud, asegurando que el `Issuer`, el `Audience` y la firma sean correctos.

## 🛡️ **3. Middleware de Autenticación**

El middleware es una capa adicional que valida si el usuario está autenticado antes de acceder a un endpoint protegido.

### 1. Crear el middleware de autenticación

1. En la carpeta `DistributedServices/WebAPIUI/Middleware`, crea el archivo `AuthenticationMiddleware.cs`:

```csharp
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace NombreProyecto.DistributedServices.WebAPIUI.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.User.Identity.IsAuthenticated)
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("No autorizado");
                return;
            }

            await _next(context);
        }
    }
}
```

---

### 2. Registrar el middleware en `Program.cs`

Finalmente, debes registrar el middleware en la cadena de procesamiento de solicitudes:

```csharp
app.UseMiddleware<AuthenticationMiddleware>();
```

Este middleware verifica si el usuario está autenticado antes de permitirle el acceso a los recursos del servidor.

## 🔒 **4. Protección de Endpoints**

### 1. Crear un controlador protegido

1. Abre o crea el archivo `AuthController.cs` en la carpeta `Controllers` para implementar un endpoint que utilice el servicio de autenticación.

```csharp
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NombreProyecto.Infrastructure.Impl.Authentication;

namespace NombreProyecto.DistributedServices.WebAPIUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtTokenService _tokenService;

        public AuthController(JwtTokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "admin" && request.Password == "password")
            {
                var token = _tokenService.GenerateToken("1", "admin");
                return Ok(new { Token = token });
            }

            return Unauthorized("Credenciales inválidas");
        }

        [Authorize]
        [HttpGet("protected")]
        public IActionResult ProtectedEndpoint()
        {
            return Ok("Acceso autorizado");
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
```

---

### 2. Protege el endpoint con el atributo `[Authorize]`

El atributo `[Authorize]` en el controlador o en los métodos de acción asegura que solo los usuarios autenticados puedan acceder a esos endpoints.

## 🗂️ **Estructura de Carpetas con Autenticación**

La estructura recomendada del proyecto sería algo como esto:

```plaintext
NombreProyecto
│
├── DistributedServices
│   ├── NombreProyecto.DistributedServices.WebAPIUI
│   │   ├── Controllers
│   │   └── Middleware
│   ├── appsettings.json
│   └── Program.cs
├── Library
│   ├── NombreProyecto.Library.Contracts
|   |   └── DTOs
│   └── NombreProyecto.Library.Impl
├── Domain
│   └── NombreProyecto.Domain.Models
├── Infrastructure
│   ├── NombreProyecto.Infrastructure.Contracts
|   |   └── Entities
│   └── NombreProyecto.Infrastructure.Impl
|       ├── DbContexts
│       └── Authentication
│           └── JwtTokenService.cs
└── Testing
    └── NombreProyecto.Testing.NombreCapa
```

## 📚 **Referencias**

- [Documentación de autenticación con JWT](https://learn.microsoft.com/aspnet/core/security/authentication/jwt)
- [Guía sobre tokens en .NET](https://learn.microsoft.com/dotnet/api/system.identitymodel.tokens.jwt)
- [Configuración de middleware en ASP.NET Core](https://learn.microsoft.com/aspnet/core/fundamentals/middleware)
