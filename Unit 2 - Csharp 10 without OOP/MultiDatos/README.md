# 💻 **Validación de Entradas en un Programa de Datos**

## 🗂️ **Índice**

| Sección                                        | Descripción                                                                 |
|------------------------------------------------|-----------------------------------------------------------------------------|
| [📄 Descripción del Proyecto](#📄-descripción-del-proyecto)     | Resumen general del proyecto sobre la entrada de datos en consola en C#.                 |
| [📜 Requisitos del Proyecto](#📜-requisitos-del-proyecto)       | Detalle de las funcionalidades y objetivos del ejercicio.                   |
| [📝 Explicación del Código](#📝-explicación-del-código)          | Análisis del flujo de datos y las validaciones implementadas en el código.           |
| [🛠️ Tecnologías Utilizadas](#🛠️-tecnologías-utilizadas)         | Herramientas y tecnologías empleadas en el desarrollo de la aplicación.     |
| [📋 Flujo del Programa](#📋-flujo-del-programa)                  | Descripción del proceso de entrada de datos y salida de resultados.                           |
| [📚 Recursos adicionales](#📚-recursos-adicionales)              | Enlaces y documentación relevante para aprender C# y manejo de entradas.                  |

---

## 📄 Descripción del Proyecto

> [!NOTE]
> Este proyecto en **C#** tiene como objetivo practicar la recopilación de datos del usuario a través de una consola sin la implementación de Programación Orientada a Objetos (OOP).

El programa solicita al usuario que ingrese varios tipos de datos, incluyendo un valor booleano, un número entero, un número decimal, un carácter, un texto y una fecha/hora. Después de recibir los datos, el programa realiza varias operaciones y muestra los resultados en la consola.

---

## 📜 Requisitos del Proyecto

Este proyecto cubre la entrada y validación de datos en C# mediante las siguientes funcionalidades:

### Funcionalidades Principales

1. **Ingreso de Datos**:
   - Solicitar al usuario que introduzca un valor booleano.
   - Solicitar un número entero.
   - Solicitar un número decimal.
   - Solicitar un carácter.
   - Solicitar un texto.
   - Solicitar una fecha y hora.

2. **Operaciones y Resultados**:
   - Calcular la negación del valor booleano.
   - Realizar la división del número entero por el número decimal.
   - Formatear y mostrar el texto con el carácter.
   - Determinar el último segundo del último día del mes correspondiente a la fecha proporcionada.

---

## 📝 Explicación del Código

El proyecto implementa un flujo sencillo para la entrada de datos del usuario, validando cada tipo de dato antes de procesarlo. A continuación, se describen las operaciones y estructuras utilizadas:

### Flujo de Entrada de Datos

1. **Entrada del Valor Booleano**:
   - Se solicita al usuario que introduzca un valor booleano (true/false) y se valida su entrada.

2. **Entrada del Número Entero**:
   - Se pide un número entero, que también se valida antes de continuar.

3. **Entrada del Número Decimal**:
   - Se solicita un número decimal, con validación adicional para asegurar que no sea cero.

4. **Entrada del Carácter y Texto**:
   - Se pide al usuario que introduzca un carácter y un texto, ambos validados antes de ser procesados.

5. **Entrada de Fecha y Hora**:
   - Se solicita una fecha y hora en el formato especificado, que se valida y se utiliza para calcular el último segundo del mes correspondiente.

### Resultados Presentados

| Resultado                                         | Descripción                                                                 |
|---------------------------------------------------|-----------------------------------------------------------------------------|
| Negación del booleano                             | Se muestra el valor negado del booleano introducido.                       |
| Resultado de la división                          | Se calcula y muestra el resultado de dividir el número entero por el decimal. |
| Texto formateado                                  | Se muestra el texto entre paréntesis, con el carácter antes y después.     |
| Último segundo del último día del mes             | Se determina y muestra el último segundo del mes correspondiente a la fecha introducida. |

> [!TIP]
> Hay que asegurarse de que el formato al introducir los datos es correcto, especialmente para la fecha y el número decimal.

---

## 🛠️ Tecnologías Utilizadas

| Categoría             | Herramienta                                                                 |
|-----------------------|-----------------------------------------------------------------------------|
| **Lenguaje**          | <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-thebadge&logo=csharp&logoColor=white" alt="C# Badge"/> |

---

## 📋 Flujo del Programa

| Opción | Descripción                                                                 |
|--------|-----------------------------------------------------------------------------|
| 1      | Ingresar un valor booleano y validar la entrada.                           |
| 2      | Ingresar un número entero y validar la entrada.                           |
| 3      | Ingresar un número decimal y validar que no sea cero.                     |
| 4      | Ingresar un carácter y un texto.                                         |
| 5      | Ingresar una fecha y hora en el formato especificado.                     |
| 6      | Mostrar los resultados calculados.                                         |

> [!IMPORTANT]
> Es esencial validar todas las entradas para evitar errores en las operaciones posteriores.

---

## 📚 Recursos adicionales

- [Documentación oficial de C#](https://learn.microsoft.com/es-es/dotnet/csharp/)
- [Tutoriales sobre manejo de entradas en C#](https://learn.microsoft.com/es-es/dotnet/csharp/programming-guide/inside-a-program/)
