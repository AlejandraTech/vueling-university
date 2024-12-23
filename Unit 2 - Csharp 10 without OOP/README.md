# 🌟 **Unidad 2: C# 10 sin OOP**

### 🗂️ **Índice**

| Sección                                                                          | Descripción                                                      |
| -------------------------------------------------------------------------------- | ---------------------------------------------------------------- |
| [🛠️ Versionado del Lenguaje C#](#1-versionado-del-lenguaje-c)                    | Cómo la versión del compilador C# afecta el proyecto.            |
| [📝 Comentarios](#2-comentarios)                                                 | Tipos de comentarios y tokens útiles en C#.                      |
| [📊 Tipos Primitivos](#3-tipos-primitivos)                                       | Introducción a los tipos básicos de datos en C#.                 |
| [🗃️ Colecciones](#4-colecciones)                                                 | Estructuras de datos comunes en C#.                              |
| [🧩 Tipos Avanzados](#5-tipos-avanzados)                                         | Otros tipos complejos y útiles en C#.                            |
| [🔄 Bloques de Control de Flujo](#6-bloques-de-control-de-flujo)                 | Declaraciones y estructuras que controlan el flujo del programa. |
| [🎯 Puntos de Interrupción (Breakpoints)](#7-puntos-de-interrupción-breakpoints) | Uso de breakpoints para la depuración.                           |
| [🔍 Más Funcionalidades](#8-más-funcionalidades)                                 | Novedades de C# 10 y su evolución.                               |

---

## 1. 🛠️ **Versionado del Lenguaje C#**

Cada nueva versión de C# introduce nuevas funcionalidades que pueden ser aprovechadas en los proyectos. La versión del compilador utilizada determina las características del lenguaje disponibles.

- **Versionado basado en el Framework**: El compilador de C# selecciona automáticamente la versión del lenguaje según el _framework_ objetivo del proyecto.

  - **Ejemplo**: Si el proyecto está configurado para usar **.NET 6**, el compilador utilizará **C# 10** de forma predeterminada.

> [!TIP]
> 💡 **Más detalles** sobre las versiones de C# pueden encontrarse en la [documentación de versionado del lenguaje C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-versioning).

---

## 2. 📝 **Comentarios**

Los comentarios son esenciales para documentar el código y dejar notas importantes para otros desarrolladores. Existen varios tipos de comentarios en C#:

### Tipos de comentarios:

1. **Comentarios de línea única**:

   ```csharp
   // Cualquier texto hasta el final de la línea se considera un comentario
   ```

2. **Comentarios de múltiples líneas**:

   ```csharp
   /*
   Puedes escribir tantas líneas como necesites en este formato
   */
   ```

3. **Comentarios de documentación XML**: Se utilizan para generar documentación automáticamente.
   ```csharp
   /// <summary>
   /// Este método hace tal cosa...
   /// </summary>
   ```

### Tokens útiles en la lista de tareas:

- **TODO**: Indica que hay algo pendiente por terminar.

  ```csharp
  // TODO {Id del desarrollador} {fecha} -> {descripción de la tarea pendiente}
  ```

- **UNDONE**: Indica que se deshizo un cambio.

  ```csharp
  // UNDONE {Descripción del cambio deshecho y motivo}
  ```

- **HACK**: Código no ortodoxo usado para solucionar un problema específico.
  ```csharp
  // HACK {Explicación de por qué se usa este código no convencional}
  ```

---

## 3. 📊 **Tipos Primitivos**

Los tipos primitivos son los bloques de construcción fundamentales de C#. Cada tipo tiene un tamaño en memoria, un rango de valores y operadores asociados.

### **Descripción de los Tipos Primitivos**:

| **Tipo**     | **Tamaño**       | **Rango de Valores**                 | **Ejemplo de Uso**                |
| ------------ | ---------------- | ------------------------------------ | --------------------------------- |
| **bool**     | 1 byte           | `true` o `false`                     | `bool esActivo = true;`           |
| **int**      | 4 bytes          | -2,147,483,648 a 2,147,483,647       | `int numero = 42;`                |
| **decimal**  | 16 bytes         | -7.9 x 10^28 a 7.9 x 10^28           | `decimal salario = 1234.56m;`     |
| **char**     | 2 bytes (UTF-16) | Caracteres de la tabla UTF-16        | `char letra = 'A';`               |
| **string**   | Variable         | Cadena de caracteres                 | `string mensaje = "Hola, Mundo";` |
| **DateTime** | 8 bytes          | Fechas entre 01/01/0001 y 31/12/9999 | `DateTime hoy = DateTime.Now;`    |

---

### **Operadores Comunes en Tipos Numéricos** 🔢

| **Operador** | **Descripción** | **Ejemplo**             |
| ------------ | --------------- | ----------------------- |
| `+`          | Suma            | `int suma = 5 + 3;`     |
| `-`          | Resta           | `int resta = 5 - 3;`    |
| `*`          | Multiplicación  | `int producto = 5 * 3;` |
| `/`          | División        | `int division = 6 / 2;` |
| `%`          | Módulo (Resto)  | `int resto = 7 % 2;`    |

**Ejemplo Completo**:

```csharp
bool esVerdadero = false;
int edad = 30;
decimal precio = 99.99m;
char inicial = 'J';
string saludo = "¡Hola!";
DateTime hoy = DateTime.Now;
```

> [!NOTE]
> 🔗 **Más información sobre tipos primitivos en**:
>
> - [bool](https://learn.microsoft.com/en-us/dotnet/api/system.boolean?view=net-6.0)
> - [int](https://learn.microsoft.com/en-us/dotnet/api/system.int32?view=net-6.0)
> - [decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal?view=net-6.0)
> - [char](https://learn.microsoft.com/en-us/dotnet/api/system.char?view=net-6.0)

---

## 4. 🗃️ **Colecciones**

Las colecciones permiten almacenar y gestionar múltiples elementos en C#. A continuación se presentan los tipos comunes de colecciones:

### Tipos comunes de colecciones:

| **Colección**                | **Descripción**                                     | **Ejemplo**                                                            |
| ---------------------------- | --------------------------------------------------- | ---------------------------------------------------------------------- |
| **Array**                    | Arreglo de tamaño fijo con elementos del mismo tipo | `int[] numeros = {1, 2, 3};`                                           |
| **List<T>**                  | Lista genérica de tamaño dinámico                   | `List<string> nombres = new List<string>();`                           |
| **Dictionary<TKey, TValue>** | Colección de pares clave-valor                      | `Dictionary<int, string> diccionario = new Dictionary<int, string>();` |

### **Ejemplo de Uso de Listas**:

```csharp
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
numeros.Add(6);  // Añadir un nuevo número
Console.WriteLine(numeros[0]);  // Imprime el primer número
```

### **Ejemplo de Uso de Dictionary**:

```csharp
Dictionary<int, string> students = new Dictionary<int, string> {
    {1, "Juan"},
    {2, "Maria"}
};
```

> [!NOTE]
> 🔗 **Más información en**: [System.Collections.Generic](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-6.0)

---

## 5. 🧩 **Tipos Avanzados**

C# proporciona tipos más avanzados que amplían la funcionalidad de los tipos primitivos.

### Tipos avanzados:

| **Tipo**             | **Descripción**                                                                                    | **Ejemplo**                                              |
| -------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------- |
| **Enum**             | Define un conjunto de constantes simbólicas asociadas a valores numéricos                          | `enum Dias { Lunes, Martes, Miercoles };`                |
| **Dynamic**          | Permite cambiar el tipo en tiempo de ejecución                                                     | `dynamic dato = 5; dato = "Texto";`                      |
| **Interface**        | Define un contrato para clases sin implementación                                                  | `interface IVehiculo { void Arrancar(); }`               |
| **Delegate**         | Referencia a un método                                                                             | `delegate void Operacion(int a, int b);`                 |
| **Nullable<T> (T?)** | Un tipo que puede contener `null` además de sus valores normales.                                  | `int? numero = null;`                                    |
| **Var**              | Variable cuyo tipo se infiere en tiempo de compilación.                                            | `var nombre = "Juan";`                                   |
| **Record**           | Tipo de referencia inmutable que se utiliza para crear objetos de datos.                           | `record Persona(string Nombre, int Edad);`               |
| **Tuple**            | Estructura que permite almacenar un conjunto de elementos de diferentes tipos.                     | `var persona = (Nombre: "Juan", Edad: 30);`              |
| **Struct**           | Tipo de valor que puede contener varios tipos de datos y tiene comportamiento similar a una clase. | `struct Punto { public int X; public int Y; }`           |
| **Task**             | Representa una operación asincrónica.                                                              | `Task<string> tarea = Task.Run(() => "Hola");`           |
| **IEnumerable<T>**   | Interfaz que define un iterador para una colección, permitiendo iteración sobre sus elementos.     | `IEnumerable<int> numeros = new List<int> { 1, 2, 3 };`  |
| **IQueryable<T>**    | Interfaz que permite realizar consultas sobre un conjunto de datos.                                | `IQueryable<Persona> query = db.Personas.AsQueryable();` |
| **Action<T>**        | Representa un método que no devuelve un valor y puede tomar uno o más argumentos.                  | `Action<string> imprimir = Console.WriteLine;`           |
| **Func<T, TResult>** | Representa un método que devuelve un valor y puede tomar uno o más argumentos.                     | `Func<int, int> cuadrado = x => x * x;`                  |

### Otros tipos avanzados:

- **Anonymous Types**: Tipos creados sin un nombre explícito, útil para encapsular datos temporales.  
  `var persona = new { Nombre = "Juan", Edad = 30 };`
- **Async/Await**: Palabras clave para trabajar con programación asincrónica de manera más sencilla.
- **Span<T>**: Tipo que proporciona una vista sobre una porción de un array o de otra estructura de datos en memoria, permitiendo manipulación eficiente.  
  `Span<int> rango = stackalloc int[10];`

---

## 6. 🔄 **Bloques de Control de Flujo**

Los bloques de control de flujo determinan cómo se ejecuta el código en función de condiciones o repeticiones.

### Condicionales:

| **Estructura**        | **Ejemplo**                                                                                    |
| --------------------- | ---------------------------------------------------------------------------------------------- |
| **if/else**           | `if (edad >= 18) { Console.WriteLine("Mayor de edad"); } else { Console.WriteLine("Menor"); }` |
| **Operador Ternario** | `string resultado = (edad >= 18) ? "Mayor" : "Menor";`                                         |

### Iteraciones:

| **Tipo de Bucle** | **Descripción**                                      | **Ejemplo**                                                      |
| ----------------- | ---------------------------------------------------- | ---------------------------------------------------------------- |
| **for**           | Itera un número específico de veces                  | `for (int i = 0; i < 5; i++) { Console.WriteLine(i); }`          |
| **while**         | Repite el código mientras la condición sea verdadera | `while (edad < 18) { Console.WriteLine("Menor de edad"); }`      |
| **foreach**       | Itera sobre una colección                            | `foreach (var nombre in nombres) { Console.WriteLine(nombre); }` |

### Manejo de Excepciones:

- **try-catch** para manejar errores durante la ejecución.
- **finally** asegura que se ejecuten ciertas acciones, incluso si ocurre una excepción.

```csharp
try
{
    int resultado = 10 / 0;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: División por cero");
}
finally
{
    Console.WriteLine("Operación finalizada.");
}
```

### Uso de recursos:

- **using** para liberar recursos no administrados automáticamente, como archivos o conexiones de red.
  ```csharp
  using (var resource = new Resource()) {
      // Uso del recurso
  }
  ```

---

## 7. 🎯 **Puntos de Interrupción (Breakpoints)**

Los _breakpoints_ permiten detener la ejecución del programa en un punto específico para inspeccionar el estado de las variables.

### **Tipos de Breakpoints**:

| **Tipo**                              | **Descripción**                                                                                                |
| ------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| **Simple**                            | Detiene la ejecución en una línea específica.                                                                  |
| **Condicional**                       | Se detiene solo cuando se cumple una condición específica.                                                     |
| **De línea**                          | Se activa al llegar a una línea de código determinada, permitiendo la inspección en esa línea.                 |
| **De función**                        | Se activa al entrar o salir de una función específica, útil para rastrear el flujo de ejecución.               |
| **De excepción**                      | Se activa cuando ocurre una excepción específica, permitiendo investigar el error en ese momento.              |
| **De datos**                          | Se activa cuando el valor de una variable específica cambia, facilitando la depuración de estados.             |
| **Logpoints**                         | Permiten registrar información en lugar de detener la ejecución, útiles para monitorear sin parar el programa. |
| **Puntos de interrupción remotos**    | Permiten detener la ejecución en un entorno remoto, útil en aplicaciones distribuidas o servicios en la nube.  |
| **Breakpoints de evaluación**         | Se detiene y permite evaluar expresiones complejas en ese punto específico.                                    |
| **Puntos de interrupción de retorno** | Se activan cuando se devuelve de una función, permitiendo verificar el valor de retorno.                       |
| **Breakpoints de acceso**             | Se activan cuando se accede a una variable o propiedad específica, útil para rastrear accesos indebidos.       |

---

## 8. 🔍 **Más Funcionalidades**

C# 10 incluye mejoras y nuevas características que facilitan la programación.

### Novedades de C# 10:

- **Directivas globales de uso**: Permiten definir espacios de nombres y directivas de uso aplicables a todo el archivo.
- **Espacios de nombres por archivo**: Simplifican la declaración de espacios de nombres.
- **Estructuras de registro**: Mejoran la creación de estructuras inmutables.

> [!NOTE]
> 🔗 **Consulta más detalles en**: [What's new in C# 10](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)

---

## 📚 **Referencias**

1. **Documentación de C#**
   - [C# Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)
   - [C# Language Reference](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/)
2. **Novedades de C#**
   - [What's New in C# 10](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)
3. **Depuración en Visual Studio**

   - [Debugging in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/debugger/debugging-in-visual-studio?view=vs-2022)

4. **Control de Flujo**

   - [Control Flow in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/flow-control/)

5. **Tipos de Datos**

   - [C# Primitive Data Types](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/data-types)
   - [Nullable Types](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/nullable-types/)

6. **Colecciones en C#**
   - [Collections in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/collections/)
7. **Pruebas Unitarias**

   - [Unit Testing in .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/)

8. **Git y Control de Versiones**

   - [Git Documentation](https://git-scm.com/doc)
   - [Getting Started with Git](https://git-scm.com/book/en/v2/Getting-Started-About-Version-Control)

9. **Recursos de Aprendizaje**
   - [Microsoft Learn - C#](https://learn.microsoft.com/en-us/training/browse/?products=dotnet&languages=csharp)
   - [Codecademy - Learn C#](https://www.codecademy.com/learn/learn-c-sharp)
   - [Pluralsight - C# Path](https://www.pluralsight.com/paths/csharp)
