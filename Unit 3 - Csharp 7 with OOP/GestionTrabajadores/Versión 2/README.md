# 💻 **Gestión de Trabajadores: Modo Multiusuario (Versión 2)**

## 🗂️ Índice

| Sección                                      | Descripción                                                               |
|----------------------------------------------|---------------------------------------------------------------------------|
| [📄 Descripción del Proyecto](#📄-descripción-del-proyecto) | Resumen general de la aplicación de gestión de trabajadores con roles.              |
| [📜 Requisitos del Proyecto](#📜-requisitos-del-proyecto)  | Funcionalidades y permisos según los roles.                             |
| [📝 Explicación del Código](#📝-explicación-del-código)    | Detalles del flujo y de la implementación del control de acceso basado en roles.    |
| [🛠️ Tecnologías Utilizadas](#🛠️-tecnologías-utilizadas) | Herramientas y tecnologías empleadas en el desarrollo de la aplicación.   |
| [📋 Flujo del Programa](#📋-flujo-del-programa)           | Menú de opciones disponibles para cada rol de usuario.                   |

---

## 📄 Descripción del Proyecto

> [!NOTE]  
> Esta aplicación en **C#** amplía la funcionalidad de la versión 1, añadiendo un sistema de **roles multiusuario**.

Los usuarios deben identificarse mediante su **Id de trabajador** antes de poder acceder a la pantalla principal. Las opciones disponibles para cada usuario dependen de su rol, lo que garantiza que solo tengan acceso a las opciones relevantes.

---

## 📜 Requisitos del Proyecto

> [!IMPORTANT]  
> El sistema de roles permite acceder a diferentes funcionalidades según el **Id de trabajador**.

### Funcionalidades y Roles

1. **Modo Admin (Id: 0)**:  
   El usuario Admin tiene acceso a **todas las opciones** disponibles en la versión 1.

2. **Modo Manager (Id: ITWorker asignado como Manager de un equipo)**:  
   Los usuarios con rol de Manager tienen acceso a las siguientes opciones:
   
   - **Opción 5**: Listar los miembros de su propio equipo.
   - **Opción 6**: Listar tareas no asignadas.
   - **Opción 7**: Asignar un trabajador como técnico en su equipo.
   - **Opción 9**: Asignar una tarea a un trabajador en su equipo.
   - **Opción 10**: Dar de baja un trabajador de su equipo.
   - **Opción 12**: Salir.

> [!NOTE]  
> En el modo Manager, las opciones de listar miembros de equipo (5) y asignar tareas (7) están limitadas al propio equipo del usuario.

3. **Modo Técnico (Id: ITWorker no asignado como Manager)**:  
   Los usuarios sin rol de Manager tienen acceso restringido a las siguientes opciones:
   
   - **Opción 6**: Listar tareas no asignadas.
   - **Opción 7**: Listar tareas asignadas a su equipo.
   - **Opción 10**: Asignarse tareas a sí mismos.
   - **Opción 12**: Salir.

> [!WARNING]  
> Un usuario técnico solo puede asignarse tareas a sí mismo y visualizar tareas asignadas a su equipo.

4. **Otros Id de Trabajador**:  
   Si el **Id de trabajador** introducido no corresponde a ninguno de los roles anteriores, se mostrará la pantalla de login de nuevo hasta que el usuario introduzca un Id válido.

---

## 📝 Explicación del Código

El flujo del programa incluye un **sistema de autenticación simplificado**, basado en el Id de trabajador, que permite gestionar la interacción y las opciones disponibles según el rol.

### Autenticación y Control de Acceso

- **Pantalla de Login**:
  - Al iniciar el programa, se solicita el **Id de trabajador**.
  - Dependiendo del Id ingresado, se define el nivel de acceso:
    - **Id 0** (Admin): Acceso completo.
    - **Id Manager**: Acceso restringido a opciones de gestión de equipo.
    - **Id Técnico**: Acceso a opciones básicas y de autogestión.
  - Si el Id ingresado no corresponde a ninguno de estos roles, se muestra nuevamente la pantalla de login.

> [!TIP]  
> Al utilizar el Id de trabajador, el sistema autentica y personaliza la experiencia de usuario, asignando las opciones del menú según su rol.

### Funcionalidad de las Opciones por Rol

#### Opciones para Admin (Id 0)

El usuario Admin tiene acceso a **todas las funcionalidades** definidas en la versión 1, incluyendo la creación y gestión completa de trabajadores, equipos y tareas.

#### Opciones para Manager

Un Manager tiene acceso a las siguientes funciones específicas:

- **Listar miembros del equipo** (Opción 5): Solo muestra los miembros de su propio equipo.
- **Listar tareas no asignadas** (Opción 6): Muestra todas las tareas que aún no tienen asignación.
- **Asignar trabajador a su equipo** (Opción 7): Permite añadir técnicos al equipo bajo su gestión.
- **Asignar tareas** (Opción 9): El Manager puede asignar tareas a técnicos dentro de su equipo.
- **Dar de baja trabajadores** (Opción 10): Solo se permite dar de baja a trabajadores de su equipo.
- **Salir** (Opción 12): Finaliza la sesión del Manager.

> [!CAUTION]  
> Los Managers solo pueden gestionar trabajadores y tareas de su propio equipo; no pueden afectar otros equipos.

#### Opciones para Técnicos

Un usuario en rol Técnico cuenta con acceso limitado:

- **Listar tareas no asignadas** (Opción 6): Ve todas las tareas que aún no tienen asignación.
- **Listar tareas de su equipo** (Opción 7): Solo puede ver las tareas asignadas a su equipo.
- **Asignarse tareas a sí mismo** (Opción 10): Tiene la opción de autogestionarse tareas.
- **Salir** (Opción 12): Finaliza su sesión de usuario.

> [!NOTE]  
> Los técnicos no pueden asignar tareas a otros trabajadores ni gestionar miembros de equipo.

### Validación de Roles

- **Id de Trabajador**: Verifica que el Id corresponda a un rol definido.
- **Acceso a Opciones**: Restringe el acceso a las opciones del menú según el rol asignado.
- **Redirección a Login**: Si el Id de trabajador no cumple con los requisitos de ningún rol, el sistema redirige automáticamente al usuario a la pantalla de login.

---

## 🛠️ Tecnologías Utilizadas

| Categoría             | Herramienta                                                                                   |
|-----------------------|-----------------------------------------------------------------------------------------------|
| **Lenguaje**          | <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-thebadge&logo=csharp&logoColor=white" alt="C# Badge"/> |
| **Entorno**           | <img src="https://img.shields.io/badge/.NET-%230512B0.svg?style=for-thebadge&logo=dotnet&logoColor=white" alt=".NET Badge"/> |

---

## 📋 Flujo del Programa

> [!TIP]  
> A continuación se muestra un resumen del menú que cada rol verá al interactuar con el programa:

### Opciones de Menú por Rol

| Rol           | Opciones Disponibles                                                                                      |
|---------------|----------------------------------------------------------------------------------------------------------|
| **Admin**     | Acceso a **todas las opciones** de la versión 1.                                                          |
| **Manager**   | Opciones: 5 (solo su equipo), 6, 7 (solo su equipo), 9, 10 (solo su equipo), y 12.                        |
| **Técnico**   | Opciones: 6, 7 (solo tareas de su equipo), 10 (solo para asignarse tareas a sí mismo), y 12.             |
