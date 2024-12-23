# 💻 **Gestión de Trabajadores: Modo Multiusuario (Versión 3)**

## 🗂️ Índice

| Sección                                      | Descripción                                                               |
|----------------------------------------------|---------------------------------------------------------------------------|
| [📄 Descripción del Proyecto](#📄-descripción-del-proyecto) | Resumen general de la aplicación de gestión de trabajadores y sus mejoras.|
| [📜 Requisitos del Proyecto](#📜-requisitos-del-proyecto)  | Descripción de funcionalidades y principios aplicados en la versión.     |
| [📝 Explicación del Código](#📝-explicación-del-código)    | Detalles sobre las mejoras en el código según buenas prácticas y principios de diseño.|
| [🛠️ Tecnologías Utilizadas](#🛠️-tecnologías-utilizadas) | Herramientas y tecnologías empleadas en el desarrollo de la aplicación.   |
| [📋 Flujo del Programa](#📋-flujo-del-programa)           | Descripción de las opciones del menú y su organización.                   |

---

## 📄 Descripción del Proyecto

> [!NOTE]  
> Esta aplicación en **C#** introduce mejoras significativas en la calidad del código, aplicando **buenas prácticas** de programación orientada a objetos (OOP).

La versión 3 implementa principios como SOLID, DRY y KISS, además de patrones de diseño que optimizan la organización y mantenibilidad del código. La funcionalidad básica de gestión de trabajadores se mantiene, pero con un enfoque en la limpieza y la eficiencia del código.

---

## 📜 Requisitos del Proyecto

> [!IMPORTANT]  
> Se aplican principios de diseño para mejorar la calidad y mantenimiento del código.

### Principios y Prácticas Implementadas

1. **SOLID**: Se aplican los cinco principios para diseñar software más comprensible y flexible.
2. **DRY (Don't Repeat Yourself)**: Se minimiza la duplicación de código para facilitar el mantenimiento.
3. **KISS (Keep It Simple, Stupid)**: Se busca la simplicidad en el diseño del software.
4. **YAGNI (You Aren't Gonna Need It)**: No se añaden características hasta que sean necesarias.
5. **Domain-Driven Design (DDD)**: Se estructura el código basado en el dominio del problema.
6. **Patrones de Diseño de GoF**: Uso de patrones clásicos para resolver problemas comunes en el desarrollo de software.

---

## 📝 Explicación del Código

La versión 3 se centra en **mejorar la calidad del código** mediante la implementación de buenas prácticas y patrones de diseño, lo que permite una mayor escalabilidad y comprensión del software.

### Estructura del Código

- **Clases y Objetos**: Se han reestructurado las clases para asegurar que cada una cumpla con una única responsabilidad, facilitando su comprensión y mantenimiento.
- **Interfaces**: Se utilizan interfaces para definir contratos que pueden ser implementados por varias clases, promoviendo la flexibilidad.
- **Herencia y Polimorfismo**: Se aplican estas técnicas de OOP para extender la funcionalidad de las clases y reducir la duplicación.

> [!TIP]  
> Al seguir estos principios, el código es más robusto y fácil de entender, lo que facilita su mantenimiento a largo plazo.

### Ejemplo de Mejora en el Código

- **Código Anterior**: 
  - Funcionalidades redundantes en varias clases.
  
- **Código Mejorado**: 
  - Implementación de interfaces para funciones comunes, permitiendo que diferentes clases las implementen según sus necesidades.

---

## 🛠️ Tecnologías Utilizadas

| Categoría             | Herramienta                                                                                   |
|-----------------------|-----------------------------------------------------------------------------------------------|
| **Lenguaje**          | <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-thebadge&logo=csharp&logoColor=white" alt="C# Badge"/> |
| **Entorno**           | <img src="https://img.shields.io/badge/.NET-%230512B0.svg?style=for-thebadge&logo=dotnet&logoColor=white" alt=".NET Badge"/> |

---

## 📋 Flujo del Programa

> [!TIP]  
> A continuación se muestra un resumen del menú que cada rol verá al interactuar con el programa, ahora con mejoras en la gestión del código:

### Opciones de Menú por Rol

| Rol           | Opciones Disponibles                                                                                      |
|---------------|----------------------------------------------------------------------------------------------------------|
| **Admin**     | Acceso a **todas las opciones** de la versión 1, con un código optimizado.                              |
| **Manager**   | Opciones: 5 (solo su equipo), 6, 7 (solo su equipo), 9, 10 (solo su equipo), y 12, con mejoras en la gestión de tareas. |
| **Técnico**   | Opciones: 6, 7 (solo tareas de su equipo), 10 (solo para asignarse tareas a sí mismo), y 12, con un manejo más efectivo de tareas. |
