# 💻 **Gestión de Trabajadores**

### 🗂️ **Índice**

| Sección                                                          | Descripción                                                                 |
|------------------------------------------------------------------|-----------------------------------------------------------------------------|
| [📄 Descripción](#-descripción)                                   | Introducción a las versiones del proyecto de gestión de trabajadores.       |
| [📦 Version 1: Gestión de Trabajadores - Modo Admin](#-version-1-gestión-de-trabajadores---modo-admin) | Descripción y funcionalidades de la gestión de trabajadores en modo admin.  |
| [🛠️ Funcionalidades - Versión 1](#-funcionalidades)               | Lista de operaciones disponibles en la versión de gestión de trabajadores.   |
| [🧭 Cómo funciona - Versión 1](#-cómo-funciona)                   | Detalle del flujo de trabajo y funcionamiento general.                      |
| [📦 Version 2: Gestión de Trabajadores - Modo Multiusuario](#-version-2-gestión-de-trabajadores---modo-multiusuario) | Explicación del manejo de múltiples trabajadores con autenticación.         |
| [🛠️ Funcionalidades - Versión 2](#-funcionalidades-1)             | Funciones de autenticación y operaciones para varios trabajadores.          |
| [🧭 Cómo funciona - Versión 2](#-cómo-funciona-1)                 | Descripción del proceso de acceso y operaciones para trabajadores autenticados.|
| [🔑 Autenticación](#-autenticación)                               | Proceso de verificación del ID del trabajador.                             |
| [🗃️ Manejo de datos de trabajadores](#-manejo-de-datos-de-trabajadores) | Organización de trabajadores, equipos y tareas.                             |
| [📦 Version 3: Mejora de Código con Buenas Prácticas](#-version-3-mejora-de-código-con-buenas-prácticas) | Introducción a las mejores prácticas en OOP para el código del proyecto.    |
| [🛠️ Funcionalidades - Versión 3](#-funcionalidades-2)             | Enfoque en las prácticas recomendadas y principios de diseño.              |
| [📚 Recursos adicionales](#-recursos-adicionales)                 | Enlaces a documentación oficial de C# y tutoriales de .NET.                 |

---

## 📄 Descripción
Este proyecto tiene dos versiones para gestionar trabajadores en una organización:

1. **Versión 1: Modo Admin** - Un administrador puede realizar operaciones de gestión de trabajadores, equipos y tareas.
2. **Versión 2: Modo Multiusuario** - Permite a varios trabajadores interactuar con sus asignaciones y equipos a través de un sistema de autenticación.

Cada versión está diseñada para practicar el uso de C# 10 y Programación Orientada a Objetos (OOP).

---

## 📦 Version 1: Gestión de Trabajadores - Modo Admin

En esta versión, un administrador puede interactuar con un menú que permite gestionar IT workers, equipos y tareas.

### 🛠️ Funcionalidades
1. **Registrar nuevo trabajador IT**: Permite añadir un nuevo trabajador IT con sus datos.
2. **Registrar nuevo equipo**: Permite crear un nuevo equipo de trabajadores.
3. **Registrar nueva tarea**: Permite crear una tarea no asignada a ningún trabajador.
4. **Listar todos los nombres de equipos**: Muestra la lista de equipos registrados.
5. **Listar miembros del equipo por nombre de equipo**: Muestra los miembros de un equipo específico.
6. **Listar tareas no asignadas**: Muestra todas las tareas que aún no han sido asignadas a ningún trabajador.
7. **Listar asignaciones de tareas por nombre de equipo**: Muestra las tareas asignadas a un equipo específico.
8. **Asignar trabajador IT a un equipo como manager**: Permite designar a un trabajador IT como manager de un equipo.
9. **Asignar trabajador IT a un equipo como técnico**: Permite designar a un trabajador IT como técnico en un equipo.
10. **Asignar tarea a trabajador IT**: Permite asignar una tarea a un trabajador IT.
11. **Desregistrar trabajador IT**: Permite eliminar un trabajador IT del sistema.
12. **Salir**: Finaliza el programa.

### 🧭 Cómo funciona
- El programa inicia mostrando un menú con las opciones mencionadas.
- El administrador elige la operación que desea realizar.
- Tras completar la operación, se pregunta si desea realizar otra:
  - Si la respuesta es **sí**, se vuelve al menú.
  - Si la respuesta es **no**, se cierra la aplicación.

### Ejemplo de flujo de trabajo:

| Menú de opciones           | Descripción                                              |
| -------------------------- | -------------------------------------------------------- |
| 1. Registrar nuevo trabajador IT | El administrador introduce los datos del nuevo trabajador IT. |
| 2. Registrar nuevo equipo       | Se solicita el nombre del nuevo equipo a registrar.      |
| 3. Registrar nueva tarea        | Se introduce la descripción y tecnología de la tarea.    |
| 4. Listar todos los nombres de equipos | Muestra todos los equipos registrados.                    |
| 5. Listar miembros por equipo   | Muestra los miembros de un equipo seleccionado.          |
| 6. Listar tareas no asignadas   | Muestra las tareas que aún no tienen asignación.        |
| 7. Listar asignaciones por equipo| Muestra las tareas asignadas a un equipo específico.     |
| 8. Asignar manager              | Designa a un trabajador IT como manager de un equipo.    |
| 9. Asignar técnico              | Designa a un trabajador IT como técnico de un equipo.    |
| 10. Asignar tarea a trabajador IT | Asigna una tarea a un trabajador IT específico.         |
| 11. Desregistrar trabajador IT   | Elimina a un trabajador IT del sistema.                  |
| 12. Salir                       | Finaliza el programa.                                   |

---

## 📦 Version 2: Gestión de Trabajadores - Modo Multiusuario

La versión 2 amplía la funcionalidad para que varios trabajadores puedan interactuar con sus asignaciones y equipos utilizando su ID de trabajador.

### 🛠️ Funcionalidades
1. **Autenticación**: Antes de mostrar el menú de opciones, el trabajador debe ingresar su ID.
2. **Listar miembros del equipo**: Muestra los miembros del equipo al que pertenece el trabajador autenticado.
3. **Listar tareas no asignadas**: Muestra las tareas no asignadas disponibles para el trabajador autenticado.
4. **Listar asignaciones de tareas**: Muestra las tareas asignadas al equipo del trabajador autenticado.
5. **Asignar tarea a sí mismo**: Permite que el trabajador se asigne tareas que cumplan con sus habilidades.
6. **Salir**: Finaliza la sesión del trabajador.

### 🧭 Cómo funciona
- El trabajador debe ingresar su **ID** para acceder al sistema.
- Si el ID es 0, se le permite acceder al menú completo de admin.
- Si el ID corresponde a un manager, se le muestran opciones limitadas relacionadas a su equipo.
- Si el ID corresponde a un técnico, se le muestran solo las opciones relacionadas con su propio equipo.

### 🔑 Autenticación
| Paso                          | Descripción                                                      |
| ----------------------------- | ---------------------------------------------------------------- |
| Ingresar ID del trabajador     | El trabajador introduce su ID para acceder.                     |
| Verificación                   | El programa valida si el ID corresponde a un trabajador existente.|

### 🗃️ Manejo de datos de trabajadores
- **Listas de trabajadores, equipos y tareas**: Organiza los datos de todos los trabajadores, los equipos a los que pertenecen y las tareas que se les han asignado.

| Trabajador  | ID  | Nombre | Apellido | Experiencia (años) | Conocimientos Técnicos | Nivel   |
|-------------|-----|--------|----------|-------------------|-----------------------|---------|
| Trabajador 1| 1001| Juan   | Pérez    | 6                 | [C#, SQL]             | Senior  |
| Trabajador 2| 1002| María  | Gómez    | 4                 | [Java, Python]        | Medium  |
| Trabajador 3| 1003| Luis   | Fernández| 2                 | [HTML, CSS]           | Junior  |

---

## 📦 Version 3: Mejora de Código con Buenas Prácticas

La Versión 3 implementa mejoras en la calidad del código y sigue principios de diseño en programación orientada a objetos.

### 🛠️ Funcionalidades - Versión 3
1. **Convenciones de Codificación en C#**: Se aplican convenciones para asegurar claridad y consistencia en el código.
2. **Principios de Diseño**: Se utilizan principios como SOLID, CUPID y GRASP para estructurar el código.
3. **Acrónimos Importantes**: Implementación de principios como DRY (Don't Repeat Yourself), KISS (Keep It Simple, Stupid) y YAGNI (You Aren't Gonna Need It).
4. **Código Limpio**: Se mantienen prácticas para mantener el código comprensible y libre de elementos innecesarios.
5. **Domain-Driven Design (DDD)**: Aplicación de conceptos clave de DDD para el diseño del software basado en el dominio del negocio.
6. **Patrones de Diseño de GoF**: Uso de patrones clásicos para resolver problemas comunes en el desarrollo de software.

---

## 📚 Recursos adicionales
- [Documentación oficial de C#](https://learn.microsoft.com/es-es/dotnet/csharp/)
- [Tutoriales de .NET](https://learn.microsoft.com/es-es/dotnet/core/tutorials/)
