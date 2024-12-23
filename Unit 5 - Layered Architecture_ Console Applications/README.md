# 🌟 **Unidad 5: Arquitectura en Capas: Aplicaciones de Consola**

En este apartado, aprenderás a crear una solución estructurada en capas para una aplicación de consola en .NET utilizando Visual Studio.

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
2. En la pantalla de inicio, selecciona la opción **Crear un proyecto**.

#### **Elegir la plantilla de "Solución en blanco"**

1. En la ventana de **Plantillas de Proyecto**, busca y selecciona la plantilla **Solución en blanco**.
2. Haz clic en **Siguiente**.

#### **Configurar el proyecto**

1. En la ventana de **Configuración del proyecto**, asigna un nombre a la solución en el campo **Nombre de la Solución**.
2. Opcionalmente, especifica la **Ubicación** donde deseas guardar la solución.
3. Haz clic en **Crear**.

> [!NOTE]
> La solución vacía te permitirá organizar tus proyectos en carpetas según la arquitectura en capas.

#### **Visualización de la solución en Visual Studio**

- Visual Studio abrirá la solución vacía, lista para que comiences a agregar los proyectos y estructuras correspondientes.

---

### 📁 **2. Creación de Carpetas de Solución**

#### **Agregar carpetas necesarias en la solución**

1. Haz clic derecho sobre la solución en el **Explorador de Soluciones**.
2. Selecciona **Agregar > Nueva carpeta de soluciones**.
3. Crea las siguientes carpetas, una para cada capa:
   - **Presentation**
   - **Business**
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
├── Presentation
│   └── NombreProyecto.Presentation.ConsoleUI
├── Business
│   ├── NombreProyecto.Business.Contracts
|   |   └── DTOs
│   └── NombreProyecto.Business.Impl
├── Domain
│   └── NombreProyecto.Domain.Models
├── Infrastructure
│   ├── NombreProyecto.Infrastructure.Contracts
│   └── NombreProyecto.Infrastructure.Impl
└── XCutting
    └── NombreProyecto.XCutting.Enums
```

#### **Creación del Proyecto en cada capa**

##### **1. Presentation**

- **Proyecto:** NombreProyecto.Presentation.ConsoleUI

1. Haz clic derecho sobre la carpeta **Presentation** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Aplicación de consola (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Presentation.ConsoleUI`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).
5. Visual Studio creará el proyecto en la carpeta seleccionada.

##### **2. Business**

###### **a. Contracts**

- **Proyecto:** NombreProyecto.Business.Contracts

1. Haz clic derecho sobre la carpeta **Business** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Business.Contracts`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

> [!NOTE]
> La capa `Contracts` define interfaces y contratos que aseguran la independencia de implementación.

###### **b. Impl**

- **Proyecto:** NombreProyecto.Business.Impl

1. Haz clic derecho sobre la carpeta **Business** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Business.Impl`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

##### **3. Domain**

- **Proyecto:** NombreProyecto.Domain.Models

1. Haz clic derecho sobre la carpeta **Domain** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Domain.Models`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

##### **4. Infrastructure**

###### **a. Contracts**

- **Proyecto:** NombreProyecto.Infrastructure.Contracts

1. Haz clic derecho sobre la carpeta **Infrastructure** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Infrastructure.Contracts`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

###### **b. Impl**

- **Proyecto:** NombreProyecto.Infrastructure.Impl

1. Haz clic derecho sobre la carpeta **Infrastructure** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.Infrastructure.Impl`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

##### **5. XCutting**

- **Proyecto:** NombreProyecto.XCutting.Enums

1. Haz clic derecho sobre la carpeta **XCutting** y selecciona **Agregar > Nuevo proyecto...**.
2. Selecciona la plantilla **Biblioteca de clases (.NET Core)**.
3. Configura el proyecto con el nombre: `NombreProyecto.XCutting.Enums`.
4. Selecciona la versión de .NET (recomendado: **.NET 6.0**).

> [!WARNING]
> No agregar dependencias cruzadas entre capas a menos que sea estrictamente necesario, para evitar problemas de acoplamiento.

---

### 🗃️ **4. Detalle de Archivos en Cada Capa**

> [!CAUTION]
> Asegúrate de mantener los archivos y su lógica dentro de la capa correcta para evitar violaciones de la arquitectura.

#### **Presentation**

- **Program.cs:** Configuración inicial de la aplicación.
- **MainMenu.cs:** Manejo de la interacción con el usuario y consultas.

#### **Business**

- **Contracts/DTOs:** Definición de DTOs.
  - Ejemplo: `NombreBDto.cs`.
- **Contracts/Interfaces:** Definición de interfaces de servicios.
  - Ejemplo: `INombreAService.cs`.
- **Impl:** Implementación de la lógica de negocio.
  - Ejemplo: `NombreAService.cs`.

#### **Domain**

- **Models:** Definición de modelos de dominio.
  - Ejemplos: `NombreAModel.cs`, `NombreBModel.cs`.

#### **Infrastructure**

- **Contracts/Entities:** Representación de las entidades de la base de datos.
  - Ejemplos: `NombreAEntity.cs`, `NombreBEntity.cs`.
- **Contracts/Interfaces:** Definición de interfaces de repositorios.
  - Ejemplo: `INombreARepository.cs`.
- **Impl:** Implementación de los repositorios.
  - Ejemplo: `NombreARepository.cs`.

#### **XCutting**

- **Enums:** Definición de enumeraciones y elementos transversales.
  - Ejemplo: `NombreCErrorEnum.cs`.

## 📚 Referencias

[Microsoft Learn: Crear soluciones en Visual Studio](https://learn.microsoft.com/es-es/visualstudio/ide/creating-solutions-and-projects)

[Documentación de .NET: Principios de arquitectura de aplicaciones en capas](https://learn.microsoft.com/es-es/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)

[Guía sobre Bibliotecas de Clases en .NET](https://learn.microsoft.com/es-es/dotnet/standard/class-libraries)

[Configurar dependencias en Visual Studio](https://learn.microsoft.com/es-es/visualstudio/ide/managing-project-references)

[Patrones de diseño en .NET: Organización de código en capas](https://dotnet.microsoft.com/en-us/learn/aspnet/architecture)

[Guía paso a paso: Aplicación de consola en .NET 6](https://www.c-sharpcorner.com/article/creating-console-application-in-net-6)
