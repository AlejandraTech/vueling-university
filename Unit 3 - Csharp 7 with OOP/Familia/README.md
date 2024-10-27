# 🌟 **Familia**

## 🗂️ **Índice**

| Sección                                        | Descripción                                                                 |
|------------------------------------------------|-----------------------------------------------------------------------------|
| [📄 Descripción del Proyecto](#📄-descripción-del-proyecto)     | Resumen general del proyecto sobre principios de POO en C#.                 |
| [📜 Requisitos del Proyecto](#📜-requisitos-del-proyecto)       | Detalle de las funcionalidades y objetivos del ejercicio.                   |
| [📝 Explicación del Código](#📝-explicación-del-código)          | Análisis de las clases, herencia y estructura general del código.           |
| [🛠️ Tecnologías Utilizadas](#🛠️-tecnologías-utilizadas)         | Herramientas y tecnologías empleadas en el desarrollo de la aplicación.     |
| [📋 Flujo del Programa](#📋-flujo-del-programa)                  | Descripción del menú de opciones para el usuario.                           |
| [📚 Recursos adicionales](#📚-recursos-adicionales)              | Enlaces y documentación relevante para aprender C# y .NET.                  |

---

## 📄 Descripción del Proyecto

> **Nota:** Este proyecto en **C#** ilustra los principios de **Programación Orientada a Objetos (POO)** mediante una estructura familiar básica (abuelo, padre, hijo).

Las clases `Grandfather`, `Father` y `Son` demuestran conceptos de **herencia** y **control de acceso** con los modificadores `public`, `protected` y `private`. A través de una aplicación de consola, el usuario puede ver y modificar los valores de los campos definidos para cada miembro de la familia, explorando cómo se comportan los niveles de acceso.

---

## 📜 Requisitos del Proyecto

Este proyecto cubre los conceptos de **herencia**, **encapsulación** y uso de **modificadores de acceso** en POO mediante las siguientes funcionalidades:

### Funcionalidades Principales

1. **Definición de Clases y Campos**:
   - Clase `Grandfather` con tres campos de diferentes accesos: `public`, `protected` y `private`.
   - Clase `Father`, que hereda de `Grandfather`, con sus propios campos `public`, `protected` y `private`.
   - Clase `Son`, que hereda de `Father`, con sus propios campos `public`, `protected` y `private`.

2. **Constructor Completo en `Son`**:
   - Constructor en `Son` que asigna valores a los nueve campos, tanto heredados como propios.

3. **Mostrar y Modificar Valores**:
   - Método en `Son` que muestra los valores actuales de los nueve campos.
   - Método para modificar estos valores y mostrarlos de nuevo en la consola.

4. **Menú Interactivo**:
   - Un menú de consola con las opciones:
     - **1**: Mostrar valores.
     - **2**: Modificar valores.
     - **3**: Salir.

---

## 📝 Explicación del Código

El proyecto utiliza una estructura jerárquica de clases basada en la familia para demostrar los conceptos de programación orientada a objetos **POO**. Aquí se detalla cómo están construidas las clases y el funcionamiento de sus distintas características:

### Estructuras de Datos

| Clase           | Descripción                                                                                             |
|-----------------|---------------------------------------------------------------------------------------------------------|
| **Grandfather** | Clase base que representa al abuelo, con atributos: apellido (`public`), trabajo (`protected`), y edad (`private`). |
| **Father**      | Hereda de `Grandfather` e incluye nombre (`public`), hobby (`protected`) y edad (`private`).            |
| **Son**         | Hereda de `Father` e incluye apodo (`public`), deporte favorito (`protected`) y edad (`private`).      |

> **Nota:** La jerarquía de clases permite que cada generación tenga campos adicionales, demostrando cómo los atributos y métodos pueden transmitirse y controlarse en niveles de acceso.

### Funcionalidad de las Opciones

1. **Mostrar Valores**:
   - El método `DisplayValues` en la clase `Son` imprime los valores de los nueve campos, respetando la encapsulación mediante getters en caso de que los campos sean `private`.

2. **Modificar Valores**:
   - `ModifyValues` permite cambiar los valores de los campos en cada clase y luego muestra los cambios.
   - La validación de los datos utiliza expresiones regulares y control numérico para mantener la integridad de los datos.

3. **Menú Interactivo**:
   - El menú de opciones en consola funciona en un bucle `while`, permitiendo al usuario:
     - Ver los valores actuales.
     - Modificar los valores de los campos.
     - Salir del programa.

---

## 🛠️ Tecnologías Utilizadas

| Categoría             | Herramienta                                                                 |
|-----------------------|-----------------------------------------------------------------------------|
| **Lenguaje**          | <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-thebadge&logo=csharp&logoColor=white" alt="C# Badge"/> |
| **Entorno**           | <img src="https://img.shields.io/badge/.NET-%230512B0.svg?style=for-thebadge&logo=dotnet&logoColor=white" alt=".NET Badge"/> |

---

## 📋 Flujo del Programa

| Opción | Descripción                                                                 |
|--------|-----------------------------------------------------------------------------|
| 1      | Mostrar valores de todos los campos heredados y propios de `Son`.           |
| 2      | Modificar los valores de los campos, con validación de datos.               |
| 3      | Salir del programa.                                                         |

> **Importante:** El menú interactivo y la validación de entradas permiten que el usuario explore la estructura de la clase `Son` y sus campos heredados.

---

## 📚 Recursos adicionales

- [Documentación oficial de C#](https://learn.microsoft.com/es-es/dotnet/csharp/)
- [Tutoriales de .NET](https://learn.microsoft.com/es-es/dotnet/core/tutorials/)
