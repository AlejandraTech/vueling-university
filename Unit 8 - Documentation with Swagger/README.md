# 🌟 **Unidad 8: Documentación con Swagger**

En esta unidad se cubren los pasos para integrar **Swagger** en un proyecto de **.NET** utilizando **Visual Studio**. Swagger permite documentar y probar automáticamente los endpoints de una API.

---

### 🗂️ **Índice**

| Sección                                               | Descripción                                                                                     |
| ----------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| ⚙️ **Instalar Paquetes NuGet de Swagger**             | Instrucciones para instalar los paquetes necesarios para Swagger.                               |
| 🏗️ **Configurar Swagger en el Proyecto**              | Pasos para configurar Swagger en el proyecto y habilitar su uso.                                |
| 📦 **Instalar y Configurar Swagger en Visual Studio** | Guía paso a paso para agregar Swagger a tu API en **Visual Studio**.                            |
| 🆕 **Crear un Controlador de API**                    | Instrucciones para crear un controlador de API y exponer los endpoints.                         |
| 🔧 **Ejecutar el Proyecto y Probar Swagger**          | Cómo ejecutar el proyecto y acceder a Swagger para ver la documentación y probar los endpoints. |
| 🗂️ **Estructura de Carpetas con Swagger**             | Organización de los proyectos y carpetas dentro de una solución al integrar Swagger.            |
| 📚 **Referencias**                                    | Enlaces a la documentación oficial y recursos adicionales sobre Swagger en .NET.                |

## ⚙️ Instalación de Paquetes NuGet de Swagger

Para poder usar Swagger en un proyecto de **.NET**, debemos instalar los paquetes NuGet necesarios. A continuación se detallan los pasos para hacerlo:

1. **Abrir el proyecto en Visual Studio**.

2. **Acceder al Administrador de Paquetes NuGet**:

   - Haz clic derecho sobre el proyecto `NombreProyecto.DistributedServices.WebAPIUI` en el **Explorador de Soluciones**.
   - Selecciona **Administrar paquetes NuGet**.

3. **Buscar los paquetes necesarios**:

   - En la ventana de paquetes NuGet, ve a la pestaña **Examinar** y busca los siguientes paquetes:
     - `Swashbuckle.AspNetCore`
     - `Swashbuckle.AspNetCore.Annotations` (opcional, para anotaciones adicionales).

4. **Instalar los paquetes**:

   - Selecciona los paquetes mencionados y haz clic en **Instalar**.

5. **Confirmar la instalación**:
   - Asegúrate de que los paquetes se hayan instalado correctamente revisando la sección de **Paquetes Instalados**.

## 🏗️ Configurar Swagger en el Proyecto

Una vez instalados los paquetes de Swagger, debemos configurarlo en el proyecto para habilitar la documentación y pruebas de los endpoints de la API.

1. **Abrir el archivo `Program.cs`**:

   - En el proyecto `NombreProyecto.DistributedServices.WebAPIUI`, abre el archivo `Program.cs`.

2. **Agregar la configuración de Swagger**:

   Dentro del método `ConfigureServices`, agrega el siguiente código para habilitar Swagger:

   ```csharp
   builder.Services.AddSwaggerGen();
   ```

3. **Configurar la interfaz de Swagger**:
   Dentro del método `Configure`, agrega el siguiente código para habilitar la interfaz gráfica de Swagger en el navegador:

   ```csharp
   if (app.Environment.IsDevelopment())
   {
       app.UseSwagger();
       app.UseSwaggerUI();
   }
   ```

## 📦 Instalación y Configuración de Swagger en Visual Studio

1. **Configurar los Servicios de Swagger**:

   - En el archivo `Program.cs`, dentro del método `ConfigureServices`, asegúrate de tener las siguientes líneas para habilitar Swagger:

     ```csharp
     builder.Services.AddEndpointsApiExplorer();
     builder.Services.AddSwaggerGen();
     ```

2. **Habilitar Swagger UI**:

   - En el método `Configure`, asegúrate de que Swagger UI esté habilitado cuando el proyecto esté en el entorno de desarrollo:

     ```csharp
     if (app.Environment.IsDevelopment())
     {
         app.UseSwagger();
         app.UseSwaggerUI();
     }
     ```

3. **Configurar la URL base para Swagger (opcional)**:

   - Si deseas cambiar la URL base donde Swagger estará disponible, puedes hacerlo modificando la configuración en el archivo `Program.cs`. Por ejemplo:

     ```csharp
     app.UseSwaggerUI(c =>
     {
         c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API v1");
         c.RoutePrefix = string.Empty; // Para que Swagger esté disponible en la raíz
     });
     ```

## 🆕 Crear un Controlador de API

Para probar Swagger, necesitamos crear un controlador de API con algunos endpoints.

1. **Navegar a la carpeta `Controllers`**:

   - En el proyecto `NombreProyecto.DistributedServices.WebAPIUI`, haz clic derecho en la carpeta **Controllers**.

2. **Agregar un nuevo controlador**:

   - Selecciona **Agregar > Controlador...**.
   - Elige la opción **Controlador API: en blanco**.
   - Asigna un nombre a tu controlador, por ejemplo, `ProductsController`.

3. **Agregar métodos al controlador**:

   - Dentro de tu controlador, agrega algunos métodos para que Swagger pueda documentarlos. Un ejemplo básico podría ser:

     ```csharp
     [ApiController]
     [Route("api/[controller]")]
     public class ProductsController : ControllerBase
     {
         [HttpGet]
         public IActionResult GetProducts()
         {
             return Ok(new List<string> { "Product1", "Product2", "Product3" });
         }

         [HttpGet("{id}")]
         public IActionResult GetProduct(int id)
         {
             return Ok($"Product {id}");
         }
     }
     ```

4. **Guardar los cambios**:
   - Guarda el controlador y asegúrate de que todo esté correctamente compilado.

## 🔧 Ejecutar el Proyecto y Probar Swagger

1. **Ejecutar el Proyecto**:

   - Presiona **Ctrl + F5** o haz clic en el botón de **Iniciar** para ejecutar el proyecto.

2. **Acceder a Swagger**:

   - Si todo está correctamente configurado, al abrir tu navegador y acceder a `https://localhost:<puerto>/swagger`, deberías ver la interfaz de Swagger con los endpoints documentados automáticamente.

3. **Probar los Endpoints**:
   - Desde la interfaz de Swagger, puedes probar los endpoints de tu API directamente, enviando solicitudes **GET** y visualizando las respuestas.

## 🗂️ Estructura de Carpetas con Swagger

```plaintext
NombreProyecto
│
├── DistributedServices
│   ├── NombreProyecto.DistributedServices.WebAPIUI
|   |   └── Controllers
│   ├── appsettings.json
|   └── Program.cs
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
|       └── DbContexts
└── XCutting
    └── NombreProyecto.XCutting.Enums
```

## 📚 Referencias

[Swagger en ASP.NET Core - Microsoft Docs](https://learn.microsoft.com/es-es/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0)

[Swashbuckle.AspNetCore en NuGet](https://www.nuget.org/packages/Swashbuckle.AspNetCore)

[Documentación Swagger UI](https://swagger.io/tools/swagger-ui/)

[Configuración avanzada de Swagger](https://learn.microsoft.com/es-es/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-6.0)
