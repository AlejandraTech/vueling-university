# 🌟 **Unidad 6: Arquitectura en Capas: Web APIs**

En este apartado, aprenderás a implementar una arquitectura en capas para una Web API en .NET utilizando Visual Studio. Esta estructura promueve la separación de responsabilidades y facilita el mantenimiento y escalabilidad del proyecto.

---

### 🗂️ **Índice**

| Sección                                                     | Descripción                                                                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| 🏗️ **Creación de la Estructura por Capas en Visual Studio** | Introducción a la creación de una solución estructurada en capas en .NET utilizando Visual Studio.          |
| 🗂️ **1. Creación de una Solución Vacía**                    | Pasos para crear una solución vacía en Visual Studio y configurarla para una arquitectura en capas.         |
| 📁 **2. Creación de Carpetas de Solución**                  | Instrucciones para agregar las carpetas necesarias en la solución para organizar las capas del proyecto.    |
| 🛠️ **3. Creación de Proyectos y Librerías**                 | Detalle sobre cómo crear los proyectos correspondientes a cada capa de la solución y su estructura.         |
| 🗃️ **4. Detalle de Archivos en Cada Capa**                  | Explicación de los archivos y su lógica correspondiente en cada capa del proyecto.                          |
| 📚 **Referencias**                                          | Fuentes y enlaces útiles para aprender más sobre la creación de soluciones y arquitectura en capas en .NET. |

---

## 🏗️ **Creación de la Estructura por Capas en Visual Studio**

### 🗂️ **1. Creación de una Solución Vacía**

#### **Abrir Visual Studio y seleccionar "Crear un proyecto"**

1. Inicia Visual Studio.
2. En la pantalla principal, selecciona la opción **Crear un proyecto**.

#### **Elegir la plantilla de "Solución en blanco"**

1. Busca y selecciona la plantilla **Solución en blanco** en la ventana de plantillas de proyecto.
2. Haz clic en **Siguiente**.

#### **Configurar el proyecto**

1. Asigna un nombre a la solución en el campo **Nombre de la Solución**.
2. Opcionalmente, especifica la **Ubicación** donde deseas guardar la solución.
3. Haz clic en **Crear**.

> [!NOTE]
> La solución vacía te permitirá organizar tus proyectos en carpetas según la arquitectura en capas.

#### **Visualización de la solución en Visual Studio**

- Visual Studio abrirá la solución vacía, lista para que comiences a añadir los proyectos y carpetas necesarias.

---

### 📁 **2. Creación de Carpetas de Solución**

#### **Agregar carpetas para cada capa**

1. Haz clic derecho sobre la solución en el **Explorador de Soluciones**.
2. Selecciona **Agregar > Nueva carpeta de soluciones**.
3. Crea las siguientes carpetas:
   - **DistributedServices**
   - **Library**
   - **Domain**
   - **Infrastructure**
   - **XCutting**

> [!TIP]
> Estas carpetas te ayudarán a organizar tu código para mantener una arquitectura limpia y escalable.

> [!NOTE]
> 📌 Estas carpetas solo serán visibles en Visual Studio y no en el sistema de archivos.

---

### 🛠️ **3. Creación de Proyectos y Librerías**

> [!IMPORTANT]
> Asegúrate de usar la misma versión de .NET para todos los proyectos de la solución, idealmente **.NET 6.0** o superior.

#### **Estructura sugerida:**

```plaintext
NombreProyecto
│
├── DistributedServices
│   └── NombreProyecto.DistributedServices.WebAPIUI
├── Library
│   ├── NombreProyecto.Library.Contracts
|   |   └── DTOs
│   └── NombreProyecto.Library.Impl
├── Domain
│   └── NombreProyecto.Domain.Models
├── Infrastructure
│   ├── NombreProyecto.Infrastructure.Contracts
│   └── NombreProyecto.Infrastructure.Impl
└── XCutting
    └── NombreProyecto.XCutting.Enums
```

---

#### **Creación del Proyecto en Cada Capa**

##### **1. DistributedServices**

- **Proyecto:** NombreProyecto.DistributedServices.WebAPIUI

1. Haz clic derecho en la carpeta **DistributedServices** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **ASP.NET Core Web API**.
3. Configura el proyecto con el nombre: `NombreProyecto.DistributedServices.WebAPIUI`.
4. Marca las opciones:
   - **Configurar para HTTPS**
   - **Habilitar compatibilidad con OpenAPI**
   - **Utilizar controladores**
5. Selecciona la versión de .NET (recomendado: **.NET 6.0**) y haz clic en **Crear**.

##### **2. Library**

###### **a. Contracts**

- **Proyecto:** NombreProyecto.Library.Contracts

1. Haz clic derecho en la carpeta **Library** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Library.Contracts`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

###### **b. Impl**

- **Proyecto:** NombreProyecto.Library.Impl

1. Haz clic derecho en la carpeta **Library** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Library.Impl`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

##### **3. Domain**

- **Proyecto:** NombreProyecto.Domain.Models

1. Haz clic derecho en la carpeta **Domain** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Domain.Models`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

##### **4. Infrastructure**

###### **a. Contracts**

- **Proyecto:** NombreProyecto.Infrastructure.Contracts

1. Haz clic derecho en la carpeta **Infrastructure** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Infrastructure.Contracts`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

###### **b. Impl**

- **Proyecto:** NombreProyecto.Infrastructure.Impl

1. Haz clic derecho en la carpeta **Infrastructure** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Infrastructure.Impl`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

##### **5. XCutting**

- **Proyecto:** NombreProyecto.XCutting.Enums

1. Haz clic derecho en la carpeta **XCutting** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.XCutting.Enums`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

---

### 🗃️ **4. Detalle de Archivos en Cada Capa**

> [!CAUTION]
> Asegúrate de mantener los archivos y su lógica dentro de la capa correcta para evitar violaciones de la arquitectura.

#### **DistributedServices**

- **/Controllers:** Contiene los controladores de la API que gestionan las solicitudes HTTP.
  - Ejemplo: `NombreController.cs`.
- **Program.cs:** Archivo principal para la configuración inicial de la API.
- **appsettings.json:** Archivo de configuración para ajustes del proyecto (e.g., cadenas de conexión).

#### **Library**

- **Contracts/DTOs:** Contiene los objetos de transferencia de datos (DTOs).
  - Ejemplo: `NombreBDto.cs`.
- **Contracts/Interfaces:** Contiene las interfaces para los servicios de negocio.
  - Ejemplo: `INombreAService.cs`.
- **Impl:** Contiene las implementaciones de los servicios de negocio.
  - Ejemplo: `NombreAService.cs`.

#### **Domain**

- **Models:** Contiene los modelos de dominio, que representan las entidades del negocio.
  - Ejemplos: `NombreAModel.cs`, `NombreBModel.cs`.

#### **Infrastructure**

- **Contracts/Entities:** Contiene las entidades que representan las tablas de la base de datos.
  - Ejemplos: `NombreAEntity.cs`, `NombreBEntity.cs`.
- **Contracts/Interfaces:** Contiene las interfaces para los repositorios.
  - Ejemplo: `INombreARepository.cs`.
- **Impl:** Contiene las implementaciones de los repositorios.
  - Ejemplos: `NombreARepository.cs`, `NombreBRepository.cs`.

#### **XCutting**

- **Enums:** Contiene las enumeraciones y componentes transversales comunes.
  - Ejemplo: `NombreCErrorEnum.cs`.

## 📚 Referencias

[Documentación de .NET: Crear y configurar una Web API en .NET](https://learn.microsoft.com/es-es/aspnet/core/web-api/?view=aspnetcore-6.0)

[Patrón de arquitectura en capas en aplicaciones .NET](https://learn.microsoft.com/es-es/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)

[Introducción a las bibliotecas de clases en .NET](https://learn.microsoft.com/es-es/dotnet/standard/class-libraries)

[Documentación de .NET: Crear y administrar soluciones y proyectos en Visual Studio](https://learn.microsoft.com/es-es/visualstudio/ide/creating-solutions-and-projects)

[Configuración de HTTPS en aplicaciones ASP.NET Core](https://learn.microsoft.com/es-es/aspnet/core/security/enforcing-https)

[Guía completa sobre la implementación de servicios en .NET](https://www.c-sharpcorner.com/article/implementing-services-in-asp-net-core/)
