# 🌟 **Unidad 1: Entorno de Desarrollo**

### 🗂️ **Índice**

| Sección                                                                                          | Descripción                                                                 |
|--------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------|
| [📜 Flujo de Programación Clásico](#1-flujo-de-programación-clásico)                             | Proceso básico para desarrollar un programa de principio a fin.              |
| [🛠️ Variante de Compilación: Compilación Multilenguaje](#2-variante-de-compilación-compilación-multilenguaje) | Cómo compilar programas en múltiples lenguajes de alto nivel (HLL).          |
| [🌍 Variante de Ejecución: Ejecución Multiplataforma](#3-variante-de-ejecución-ejecución-multiplataforma)   | Cómo ejecutar código en diferentes plataformas con el mismo comportamiento.  |
| [💻 Variante de Ejecución: Código Gestionado](#4-variante-de-ejecución-código-gestionado)        | Uso de máquinas virtuales (VM) para gestionar la ejecución de código.        |
| [🔍 Introducción a .NET](#5-introducción-a-net)                                                  | Visión general del ecosistema de .NET, sus características y componentes.    |
| [🔧 Clasificación de Herramientas de Desarrollo](#6-clasificación-de-herramientas-de-desarrollo)  | Diferentes tipos de herramientas de software usadas para programar.          |
| [🛠️ Visual Studio 2022](#7-visual-studio-2022)                                                   | Uso de Visual Studio 2022 como entorno de desarrollo integrado (IDE).        |
| [🖥️ Proyecto de Consola .NET 6 en VS2022](#8-proyecto-de-consola-net-6-en-vs2022)                | Cómo crear y gestionar proyectos de consola en .NET 6 utilizando Visual Studio. |
| [🛡️ Control de Versiones con GitHub y VS2022](#9-control-de-versiones-con-github-y-vs2022)        | Uso de Git y GitHub con Visual Studio para el control de versiones.          |

---

## 1. 📜 **Flujo de Programación Clásico**

El flujo de desarrollo clásico implica una serie de pasos secuenciales para crear un programa. Este es el proceso estándar para cualquier lenguaje de programación:

1. **Entender la tarea a resolver**: Antes de escribir código, es fundamental entender completamente los requisitos del problema o la tarea que se va a resolver.

> [!TIP]  
> **Ejemplo**: Si te piden escribir un programa que calcule la media de una lista de números, asegúrate de comprender si los números pueden ser decimales, enteros, si habrá una cantidad mínima o máxima, etc.

2. **Resolver dudas**: Asegúrate de aclarar cualquier confusión antes de comenzar a programar, haciendo preguntas relevantes.

3. **Seleccionar un Lenguaje de Alto Nivel (HLL)**: Elegir el lenguaje que mejor se ajuste a las necesidades del proyecto.

> [!NOTE]  
> **Ejemplos de HLL**: C#, Java, Python.

4. **Escribir el código en HLL**: Utilizar un editor de código o un IDE para escribir el programa en el HLL seleccionado.

5. **Compilar el código HLL en Lenguaje de Máquina (MLL)**: Este proceso convierte el código legible por humanos en un formato que el procesador de la computadora puede ejecutar directamente.

6. **Ejecutar el código MLL**: Una vez compilado, el código se ejecuta en la máquina para observar si el programa funciona correctamente.

7. **Probar y depurar**: Ejecutar pruebas para verificar que el programa cumple con los requisitos originales. Si hay errores, corregirlos y repetir este paso hasta que el programa sea funcional.

> [!IMPORTANT]  
> Asegúrate de seguir los pasos de depuración minuciosamente, ya que detectar errores en esta etapa puede evitar problemas mayores en el futuro.

---

## 2. 🛠️ **Variante de Compilación: Compilación Multilenguaje**

Este tipo de compilación permite que un programa esté compuesto por partes escritas en diferentes lenguajes de programación, todos ellos traducidos a un **Lenguaje Intermedio (IL)**, antes de ser finalmente compilados en **Lenguaje de Máquina (MLL)**.

### Proceso:
1. **Compilación HLL a IL**: Los diferentes lenguajes se compilan a un Lenguaje Intermedio común, por ejemplo, el **CIL (Common Intermediate Language)**.
2. **Compilación IL a MLL**: Finalmente, el IL se traduce al código de máquina específico para ser ejecutado en un procesador.

> [!NOTE]  
> Este proceso permite un entorno de trabajo más flexible al usar múltiples lenguajes en el mismo proyecto.

---

## 3. 🌍 **Variante de Ejecución: Ejecución Multiplataforma**

Esta variante permite que el mismo código pueda ser ejecutado en diferentes sistemas operativos o plataformas sin necesidad de reescribir el programa.

### Proceso:
- **Compiladores específicos para cada plataforma**: Después de compilar a IL, existen compiladores que traducen ese IL en códigos de máquina específicos para cada plataforma, como Windows, Linux, Android, etc.

> [!WARNING]  
> Asegúrate de probar el código en cada plataforma objetivo, ya que pequeños detalles pueden variar y afectar el comportamiento del programa.

---

## 4. 💻 **Variante de Ejecución: Código Gestionado**

El **código gestionado** se ejecuta dentro de una máquina virtual (VM) que gestiona aspectos como la memoria, la seguridad y el manejo de excepciones.

### Características:
1. **Máquina Virtual (VM)**: La VM ejecuta cada instrucción del código, verificando que sea segura antes de enviarla al procesador.
2. **Excepciones**: Si una instrucción podría causar un error de ejecución, la VM levanta una excepción antes de ejecutar el código.
3. **Recolección de basura**: La VM también se encarga de liberar memoria utilizada por variables que ya no se están usando (Garbage Collection).

> [!CAUTION]  
> En proyectos grandes, la dependencia de la VM puede influir en el rendimiento, ya que las VMs pueden ser menos eficientes que el código compilado directamente.

---

## 5. 🔍 **Introducción a .NET**

**.NET** es una plataforma de desarrollo creada por Microsoft que soporta múltiples lenguajes de programación y ofrece un entorno de ejecución controlado (Managed Code).

| **Componentes Principales** |
|----------------------------|
| **Compilación Multilenguaje** → .NET permite escribir código en varios lenguajes como C#, F#, VB.Net, que se compilan al CIL común. |
| **Biblioteca Base (BCL)** → Proporciona clases y métodos predefinidos que ayudan a los desarrolladores a crear software sin necesidad de reinventar soluciones comunes. |
| **Herramienta de Gestión de Paquetes (NuGet)** → Permite descargar bibliotecas de terceros para añadir funcionalidades a las aplicaciones. |

> [!TIP]  
> Usa paquetes de NuGet para añadir funcionalidades específicas a tu aplicación en lugar de desarrollar todo desde cero.

---

## 6. 🔧 **Clasificación de Herramientas de Desarrollo**

Las herramientas de desarrollo de software se pueden clasificar en varias categorías según su funcionalidad:

| **Clasificación de Herramientas** | **Descripción**                                                                                              |
|-----------------------------------|--------------------------------------------------------------------------------------------------------------|
| **Equipo Mínimo**                 | Un editor de texto para escribir código y un compilador en la línea de comandos.                              |
| **IDE (Entorno de Desarrollo Integrado)** | Un entorno que incluye editor de código, depurador y herramientas de compilación. Ejemplo: Visual Studio. |
| **SDK (Kit de Desarrollo de Software)**  | Un IDE que incluye además librerías predefinidas listas para usar. Ejemplo: SDK de .NET.                    |
| **Framework**                     | Un SDK que incluye una máquina virtual para ejecutar código gestionado. Ejemplo: .NET o Java.                |

> [!NOTE]  
> La elección de herramientas dependerá del tipo de proyecto y las necesidades del equipo de desarrollo.

---

## 7. 🛠️ **Visual Studio 2022**

**Visual Studio** es un IDE potente y versátil. En este curso se utiliza **Visual Studio 2022 Community Edition** para escribir, compilar, ejecutar y depurar código en **C#**, el lenguaje de elección para proyectos back-end.

### Características:
- Soporte para proyectos .NET 6 de consola y WebAPI.
- Gestión de dependencias a través de NuGet.
- Herramientas de depuración avanzadas y soporte para control de versiones (Git).

> [!IMPORTANT]  
> Visual Studio facilita el trabajo en equipo, especialmente cuando se combina con GitHub para el control de versiones.

---

## 8. 🖥️ **Proyecto de Consola .NET 6 en VS2022**

Pasos básicos para crear un proyecto de consola en **.NET 6** usando Visual Studio 2022:

1. Abrir Visual Studio y crear una solución usando la plantilla **Solución Vacía**.
2. Agregar un proyecto de consola dentro de la solución.
3. Seleccionar la versión **.NET 6** y agregar dependencias según

 sea necesario.

> [!TIP]  
> Usar soluciones vacías permite una organización más clara y modular de tus proyectos.

---

## 9. 🛡️ **Control de Versiones con GitHub y VS2022**

**GitHub** se integra fácilmente con Visual Studio 2022 para gestionar el control de versiones de un proyecto.

### Beneficios:
- Crear **repositorios locales y remotos**.
- Trabajar en **ramas separadas** (por ejemplo, master y development).
- Realizar **pull requests** y manejar cambios de código colaborativos.

### Pasos:
1. Crear una cuenta en GitHub y enlazarla con Visual Studio.
2. Crear un nuevo repositorio Git y asociarlo al proyecto local en Visual Studio.
3. Administrar ramas y realizar commits, push y pull directamente desde el IDE.

> [!WARNING]  
> Realiza commits regularmente para evitar perder avances significativos en caso de errores.

---

### 📚 **Referencias**
- [Documentación oficial de .NET](https://learn.microsoft.com/en-us/dotnet/)
- [Documentación oficial de C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Try .NET online](https://dotnetfiddle.net/)
