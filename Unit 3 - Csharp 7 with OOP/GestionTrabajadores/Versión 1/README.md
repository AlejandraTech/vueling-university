# 💻 **Gestión de Trabajadores: Modo Administrador (Versión 1)**

## 🗂️ Índice

| Sección                                      | Descripción                                                               |
|----------------------------------------------|---------------------------------------------------------------------------|
| [📄 Descripción del Proyecto](#📄-descripción-del-proyecto) | Resumen general de la aplicación de gestión de trabajadores.              |
| [📜 Requisitos del Proyecto](#📜-requisitos-del-proyecto)  | Funcionalidades principales de la aplicación.                             |
| [📝 Explicación del Código](#📝-explicación-del-código)    | Desglose detallado del funcionamiento del código paso a paso.             |
| [🛠️ Tecnologías Utilizadas](#🛠️-tecnologías-utilizadas) | Herramientas y tecnologías empleadas en el desarrollo de la aplicación.   |
| [📋 Flujo del Programa](#📋-flujo-del-programa)           | Menú de opciones disponibles para el usuario.                             |

---

## 📄 Descripción del Proyecto

> [!NOTE]  
> Esta aplicación es una herramienta de consola en **C#** para la gestión de trabajadores en un entorno de administración. Permite registrar trabajadores IT, asignarlos a equipos, gestionar tareas y consultar información estructurada de equipos y tareas.

A través de un menú interactivo, el usuario puede registrar **IT Workers**, crear equipos, asignar gerentes y técnicos, y manejar tareas.

---

## 📜 Requisitos del Proyecto

> [!IMPORTANT]  
> El programa debe cumplir con las siguientes funcionalidades principales:

### Funcionalidades Principales

1. **Registrar un nuevo trabajador IT**: Permite crear un perfil de trabajador con datos personales y experiencia en tecnologías.
2. **Registrar un equipo nuevo**: Crea equipos para asignar trabajadores como técnicos o gerentes.
3. **Registrar una tarea nueva**: Crea tareas que aún no están asignadas a un trabajador.
4. **Listar nombres de todos los equipos**: Muestra todos los equipos registrados.
5. **Listar miembros de equipo**: Permite ver los miembros de un equipo específico, incluyendo gerente y técnicos.
6. **Listar tareas no asignadas**: Muestra las tareas que aún no tienen un trabajador asignado.
7. **Asignar trabajador IT a un equipo como gerente**: Asigna a un trabajador Senior como gerente de un equipo.
8. **Asignar trabajador IT a un equipo como técnico**: Añade un trabajador al equipo como técnico.
9. **Asignar tarea a un trabajador IT**: Asigna una tarea a un trabajador calificado en la tecnología de la tarea.
10. **Dar de baja un trabajador IT**: Permite eliminar un trabajador de todos los equipos en los que esté.
11. **Salir**: Finaliza el programa.

---

## 📝 Explicación del Código

El programa estructura el flujo para gestionar trabajadores IT, tareas y equipos en una empresa. A continuación, se explican los componentes clave.

### Estructuras de Datos

| Elemento              | Descripción                                                                                   |
|-----------------------|-----------------------------------------------------------------------------------------------|
| **Worker**            | Clase base para trabajadores, contiene datos personales como nombre, apellido y fecha de nacimiento. |
| **ITWorker**          | Extiende de **Worker**, incluye experiencia, conocimientos técnicos y nivel de trabajador.     |
| **Team**              | Representa un equipo con un nombre, un gerente y una lista de técnicos.                       |
| **Task**              | Representa una tarea con descripción, tecnología requerida, estado y trabajador asignado.     |

> [!TIP]  
> Estas estructuras proporcionan una forma organizada de almacenar la información de los trabajadores, equipos y tareas, facilitando su acceso y gestión.

### Funcionalidad de las Opciones

1. **Registrar nuevo trabajador IT**:
   - Permite al usuario introducir el nombre, apellido, fecha de nacimiento y conocimientos técnicos del trabajador.
   - Si la edad es inferior a 18 años, se mostrará un error.

> [!WARNING]  
> Un trabajador debe ser mayor de 18 años para poder registrarse como IT Worker.

2. **Registrar un equipo nuevo**:
   - Solicita al usuario el nombre del equipo y lo agrega a la lista de equipos disponibles.

3. **Registrar una tarea nueva**:
   - Permite al usuario crear una tarea especificando la tecnología requerida y su descripción.
   - La tarea queda no asignada hasta que se asigne a un trabajador.

4. **Listar nombres de todos los equipos**:
   - Muestra una lista con todos los nombres de equipos registrados.

5. **Listar miembros de equipo**:
   - Solicita el nombre de un equipo y muestra al gerente y los técnicos asignados a ese equipo.

6. **Listar tareas no asignadas**:
   - Muestra las tareas que aún no han sido asignadas a ningún trabajador.

7. **Asignar trabajador IT a un equipo como gerente**:
   - Asigna a un trabajador Senior como gerente de un equipo. Si el trabajador no tiene nivel Senior, se muestra un error.

> [!IMPORTANT]  
> Solo los trabajadores Senior pueden ser asignados como gerentes de equipo.

8. **Asignar trabajador IT a un equipo como técnico**:
   - Añade un trabajador como técnico en un equipo especificado por el usuario.

9. **Asignar tarea a un trabajador IT**:
   - Asigna una tarea a un trabajador si este posee conocimientos en la tecnología requerida y si la tarea no está finalizada.

> [!CAUTION]  
> Una tarea solo puede ser asignada a un trabajador que tenga conocimientos en la tecnología requerida y que no esté en estado "Done".

10. **Dar de baja un trabajador IT**:
   - Elimina a un trabajador de la lista y lo desvincula de cualquier equipo al que pertenezca.

11. **Salir del programa**:
   - Finaliza la ejecución del programa y cierra la consola.

### Validación de Entradas

- **Registro de Trabajadores y Equipos**: Valida que los datos proporcionados sean correctos, como fechas y niveles de experiencia.
- **Asignación de Gerentes y Técnicos**: Verifica que el trabajador tenga el nivel adecuado y que cumpla con los requisitos mínimos para ser asignado a un equipo.

> [!NOTE]  
> La aplicación realiza validaciones en cada paso para asegurar que solo se ingresen datos correctos.

---

## 🛠️ Tecnologías Utilizadas

| Categoría             | Herramienta                                                                                   |
|-----------------------|-----------------------------------------------------------------------------------------------|
| **Lenguaje**          | <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-thebadge&logo=csharp&logoColor=white" alt="C# Badge"/> |
| **Entorno**           | <img src="https://img.shields.io/badge/.NET-%230512B0.svg?style=for-thebadge&logo=dotnet&logoColor=white" alt=".NET Badge"/> |

---

## 📋 Flujo del Programa

> [!TIP]  
> A continuación se muestra un resumen del menú que el usuario verá al interactuar con el programa:

| Opción | Descripción                                     |
|--------|-------------------------------------------------|
| 1      | Registrar nuevo trabajador IT                   |
| 2      | Registrar nuevo equipo                          |
| 3      | Registrar nueva tarea                           |
| 4      | Listar nombres de todos los equipos             |
| 5      | Listar miembros de equipo por nombre            |
| 6      | Listar tareas no asignadas                      |
| 7      | Asignar trabajador IT como gerente de equipo    |
| 8      | Asignar trabajador IT como técnico de equipo    |
| 9      | Asignar tarea a trabajador IT                   |
| 10     | Dar de baja un trabajador IT                    |
| 11     | Salir del programa                              |
