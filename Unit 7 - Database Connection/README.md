# 🌟 **Unidad 7: Conexión de Base de Datos**

Esta unidad aborda la instalación y configuración de **SQL Server** y **SQL Server Management Studio (SSMS)**, así como la creación y gestión de bases de datos. Además, se explica cómo conectar la base de datos a un proyecto en **Visual Studio** utilizando **Entity Framework Core (EF Core)**.

---

### 🗂️ **Índice**

| Sección                                                    | Descripción                                                                                            |
| ---------------------------------------------------------- | ------------------------------------------------------------------------------------------------------ |
| 🛠️ **Instalación SQL Server Management**                   | Instrucciones para instalar SQL Server y SQL Server Management Studio (SSMS).                          |
| ⚙️ **1. Instalar SQL Server**                              | Pasos para descargar e instalar SQL Server Express y configurar la cadena de conexión.                 |
| ⚙️ **2. Instalar SQL Server Management Studio (SSMS)**     | Guía para descargar, instalar y configurar SSMS.                                                       |
| 🏗️ **Desarrollo de la Base de Datos en SQL Server**        | Proceso de creación de base de datos y tablas en SQL Server Management Studio (SSMS).                  |
| 🆕 **1. Creación de una Nueva Base de Datos**              | Pasos para crear una nueva base de datos en SSMS.                                                      |
| 📊 **2. Creación de Tablas en la Base de Datos**           | Instrucciones detalladas para crear y configurar tablas dentro de una base de datos.                   |
| 🔗 **3. Relacionar Tablas**                                | Guía para establecer relaciones de claves foráneas entre tablas en SQL Server.                         |
| 🔌 **Conexión de la Base de Datos en Visual Studio**       | Procedimiento para conectar la base de datos con un proyecto en Visual Studio.                         |
| 🔧 **1. Configuración de la Conexión de la Base de Datos** | Configuración de la conexión a la base de datos utilizando EF Core Power Tools en Visual Studio.       |
| 🔨 **2. Generar Entidades de la Base de Datos**            | Generación de entidades basadas en las tablas de la base de datos mediante ingeniería inversa.         |
| 🔄 **3. Generar el DbContext**                             | Procedimiento para generar el DbContext a partir de las tablas de la base de datos.                    |
| 📦 **Instalación de Paquetes NuGet**                       | Pasos para instalar y configurar los paquetes NuGet necesarios para trabajar con EF Core.              |
| 🗂️ **Estructura de Carpetas al Conectar la Base de Datos** | Organización de los proyectos y carpetas dentro de una solución al integrar una base de datos.         |
| 📚 **Referencias**                                         | Fuentes y documentación adicional para profundizar en la instalación y el uso de SQL Server y EF Core. |

## 🛠️ Instalación SQL Server Management

Para comenzar a trabajar con bases de datos en SQL Server, es necesario instalar tanto **SQL Server** como **SQL Server Management Studio (SSMS)**. A continuación se detallan los pasos para realizar la instalación:

---

### ⚙️ 1. **Instalar SQL Server**

1. **Acceder al sitio web de Microsoft**:

   - Dirígete a la página oficial de descargas de SQL Server: [Descargas de SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads).

> [!NOTE]  
> Asegúrate de elegir la versión adecuada para tus necesidades, SQL Server Express es ideal para desarrollos y pruebas locales.

2. **Seleccionar SQL Server Express**:

   - Descarga la opción **SQL Server Express** (la versión gratuita) que es adecuada para la mayoría de los desarrollos y pruebas.

3. **Ejecutar el instalador**:

   - Una vez descargado el archivo ejecutable, ejecútalo y selecciona la opción **Básica** para realizar una instalación sencilla.

4. **Seleccionar el idioma y aceptar los términos de licencia**:

   - Elige el idioma de la instalación y acepta los términos de licencia.

5. **Especificar la ubicación de la instalación**:

   - Indica la carpeta de destino donde se instalará SQL Server.

6. **Ejecutar la instalación**:

   - Haz clic en **Instalar** para que el proceso de instalación comience.

7. **Cadena de Conexión**:
   - Una vez finalizada la instalación, puedes conectarte a SQL Server utilizando la siguiente cadena de conexión:
     ```
     Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
     ```

---

### ⚙️ 2. **Instalar SQL Server Management Studio (SSMS)**

1. **Acceder a la página de SSMS**:

   - Dirígete a la página de descarga de **SQL Server Management Studio** (SSMS) en [Microsoft SSMS](https://docs.microsoft.com/es-es/sql/ssms/download-sql-server-management-studio-ssms).

2. **Descargar SSMS**:

   - Haz clic en el enlace de descarga para obtener el instalador de SSMS.

3. **Ejecutar el instalador**:

   - Una vez descargado, ejecuta el archivo `.exe` y sigue los pasos del instalador.

4. **Reiniciar el PC**:

   - Después de completar la instalación, es recomendable reiniciar el equipo.

> [!TIP]  
> Reiniciar el equipo después de la instalación de SSMS puede evitar problemas de configuración.

5. **Ejecutar SSMS como administrador**:
   - Para comenzar a usar SSMS, abre el programa **como administrador** y conecta con la instancia de SQL Server previamente instalada.

## 🏗️ Desarrollo de la Base de Datos en SQL Server

### 🆕 1. **Creación de una Nueva Base de Datos**

1. **Abrir SQL Server Management Studio (SSMS)**:

   - Inicia SSMS y conéctate a la instancia de SQL Server usando la cadena de conexión previamente configurada.

2. **Acceder a la carpeta de Bases de Datos**:

   - En el panel de objetos, haz clic derecho sobre la carpeta **Databases** y selecciona **New Database...**.

3. **Configurar la Base de Datos**:

   - En la ventana emergente, ingresa el nombre de la base de datos en el campo **Database Name** y configura otras opciones si es necesario.

4. **Crear la Base de Datos**:
   - Haz clic en **OK** para crear y guardar la base de datos. La nueva base de datos aparecerá en el panel de objetos.

---

### 📊 2. **Creación de Tablas en la Base de Datos**

1. **Acceder a la Carpeta de Tablas**:

   - Navega a **Databases > [Nombre de tu base de datos] > Tables** en el panel de objetos de SSMS.

2. **Crear una Nueva Tabla**:

   - Haz clic derecho sobre **Tables** y selecciona **New > Table...**.

3. **Definir las Columnas de la Tabla**:

   - Ingresa el nombre de cada columna, selecciona el tipo de dato adecuado (por ejemplo, **int**, **varchar**, **decimal**), y decide si permites valores nulos.

4. **Configurar la Columna Autoincremental**:

   - Para una columna que será clave primaria o identificador único, selecciona la columna y en las propiedades de la columna, cambia **Is Identity** a "Yes" para hacerla autoincremental.

5. **Definir la Clave Primaria**:

   - Haz clic derecho sobre la columna que será la clave primaria y selecciona **Set Primary Key**.

6. **Guardar la Tabla**:

   - Haz clic en **Save All** y asigna un nombre a la tabla.

7. **Actualizar la Lista de Tablas**:
   - Haz clic derecho sobre **Tables** y selecciona **Refresh** para ver la nueva tabla en la lista.

---

### 🔗 3. **Relacionar Tablas**

1. **Abrir el Diseñador de Tablas**:

   - Haz clic derecho sobre la tabla que contendrá la clave foránea y selecciona **Design**.

2. **Configurar Relaciones de Clave Foránea**:

   - En el diseñador de la tabla, haz clic derecho en el área en blanco y selecciona **Relationships**.

3. **Añadir una Relación de Clave Foránea**:

   - En la ventana de relaciones, haz clic en **Add** para agregar una nueva relación.

4. **Configurar las Tablas y Columnas para la Relación**:

   - Selecciona las tablas y columnas involucradas en la relación:
     - **Primary key table**: La tabla que contiene la clave primaria.
     - **Foreign key table**: La tabla que tendrá la clave foránea.

5. **Guardar los Cambios**:
   - Haz clic en **Save All** para guardar la relación de clave foránea y las modificaciones realizadas.

> [!IMPORTANT]  
> Asegúrate de que las claves foráneas se configuren correctamente para evitar problemas de integridad referencial en la base de datos.

## 🔌 Conexión de la Base de Datos en Visual Studio

### 🔧 1. **Configuración de la Conexión de la Base de Datos**

1. **Instalar EF Core Power Tools**:

   - **Abrir Visual Studio**.
   - Ve a la barra superior y selecciona **Extensiones > Administrar extensiones**.
   - En la ventana de **Administrador de Extensiones**, selecciona la pestaña **Buscar**.
   - En la barra de búsqueda, escribe **EF Core Power Tools**.
   - Haz clic en **Descargar** junto a la opción **EF Core Power Tools**.
   - **Reinicia Visual Studio** para completar la instalación.
   - Una vez instalado, puedes verificarlo en **Extensiones > Administrar extensiones > Instaladas**.

2. **Iniciar Ingeniería Inversa**:

   - En el **Explorador de Soluciones**, haz clic derecho sobre el proyecto en el que deseas realizar la conexión y selecciona **EF Core Power Tools > Reverse Engineer**.

3. **Seleccionar la Conexión de la Base de Datos**:

   - En la ventana emergente, selecciona la conexión de la base de datos que deseas utilizar o agrega una nueva conexión.

4. **Configurar la Cadena de Conexión**:

   - Ingresa los detalles de la conexión, como el **servidor**, la **autenticación** y el **nombre de la base de datos**.

5. **Probar la Conexión**:

   - Si lo deseas, haz clic en **Test Connection** para verificar que la conexión es exitosa.

6. **Confirmar la Conexión**:
   - Haz clic en **OK** para cerrar la ventana de configuración de la conexión.

---

### 🔨 2. **Generar Entidades de la Base de Datos**

1. Haz clic derecho en el proyecto `NombreProyecto.Infrastructure.Contracts`

2. Selecciona **EF Core Power Tools** > **Reverse Engineer**.

3. **Seleccionar Tablas para Generar las Entidades**:

   - Después de configurar la conexión, selecciona las tablas de la base de datos que deseas usar como entidades.

4. **Configurar la Ruta de las Entidades**:

   - Define una carpeta como **Entities** donde se guardarán las clases generadas.

5. **Generar las Entidades**:
   - Haz clic en **OK** para generar las entidades en el proyecto.

---

### 🔄 3. **Generar el DbContext**

1. Haz clic derecho en el proyecto `NombreProyecto.Infrastructure.Impl`

2. Selecciona **EF Core Power Tools** > **Reverse Engineer**.

3. **Seleccionar las Tablas para Generar el DbContext**:

   - En el proyecto de Visual Studio, selecciona las tablas para generar el **DbContext**.

4. **Configurar la Ruta del DbContext**:

   - Define la ruta para almacenar el **DbContext**, como una carpeta llamada **DbContexts**.

5. **Generar el DbContext**:

   - Haz clic en **OK** para generar el **DbContext** en la ubicación configurada.

6. **Verificar las Entidades y el DbContext**:
   - Asegúrate de que las entidades y el **DbContext** se hayan generado correctamente en sus respectivas carpetas dentro del proyecto.

## 📦 Instalación de Paquetes NuGet

1. **Instalar los Paquetes Necesarios**:

   - En Visual Studio, abre el **Administrador de Paquetes NuGet** e instala los siguientes paquetes necesarios para trabajar con **Entity Framework Core**:
     - `Microsoft.EntityFrameworkCore.SqlServer`
     - `Microsoft.EntityFrameworkCore.Tools`

2. **Actualizar los Paquetes**:

   - Asegúrate de que todos los paquetes estén actualizados a la versión correcta, especialmente si trabajas con versiones específicas de **EF Core**.

3. **Verificar la Instalación**:
   - Una vez instalados los paquetes, verifica que la conexión y la generación de entidades y **DbContext** se hayan completado correctamente.

## 🗂️ Estructura de Carpetas al Conectar la Base de Datos

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
|   |   └── Entities
│   └── NombreProyecto.Infrastructure.Impl
|       └── DbContexts
└── XCutting
    └── NombreProyecto.XCutting.Enums
```

## 📚 Referencias

[Descargas de SQL Server - Microsoft](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)

[Descargar SSMS - Microsoft Docs](https://docs.microsoft.com/es-es/sql/ssms/download-sql-server-management-studio-ssms)

[Crear y administrar bases de datos - SQL Server](https://docs.microsoft.com/es-es/sql/ssms/overview/ssms?view=sql-server-ver15)

[Relaciones de clave foránea en SQL Server](https://docs.microsoft.com/es-es/sql/ssms/objects/foreign-keys?view=sql-server-ver15)

[Introducción a Entity Framework Core](https://learn.microsoft.com/es-es/ef/core/)

[EF Core Power Tools en GitHub](https://github.com/ErikEJ/EFCorePowerTools)

[Guía de instalación y uso de EF Core](https://learn.microsoft.com/es-es/ef/core/get-started/overview/first-app)

[Conectar con bases de datos en Visual Studio](https://learn.microsoft.com/es-es/visualstudio/data-tools/sql-server-data-tools?view=vs-2022)

[Documentación de NuGet para EF Core](https://learn.microsoft.com/es-es/nuget/consume-packages/overview-and-workflow)

[Migraciones con EF Core](https://learn.microsoft.com/es-es/ef/core/managing-schemas/migrations/)
