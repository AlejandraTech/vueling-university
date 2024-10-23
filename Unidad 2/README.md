# 🌟 **Unidad 2: C# 10 sin OOP**

---

## **1. Versionado del lenguaje C# 📅**

🔹 **¿Qué es el versionado de C#?**  
C# actualiza automáticamente su versión según el *framework* del proyecto para aprovechar las nuevas características y mejoras.

💡 **Más información**:  
- [Versionado del lenguaje C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-versioning)

---

## **2. Comentarios 📝**

**Tipos de Comentarios en C#**:

| **Tipo de Comentario**       | **Símbolos**                          | **Ejemplo**                                                                                               |
|------------------------------|---------------------------------------|-----------------------------------------------------------------------------------------------------------|
| **Línea Única**               | `//`                                 | `// Esto es un comentario`                                                                                 |
| **Múltiples Líneas**          | `/* ... */`                          | ``` /* Este es un comentario de varias líneas */ ```                                                 |
| **Documentación XML**         | `///`                                | ``` /// <summary> /// Documenta un método </summary> ```                                              |

🎯 **Tokens útiles en comentarios**:
- **TODO**: Tareas pendientes.
  ```csharp
  // TODO: Completar implementación de este método.
  ```
- **UNDONE**: Revertir cambios realizados.
  ```csharp
  // UNDONE: Revertido el cambio de la variable.
  ```
- **HACK**: Código temporal o poco elegante.
  ```csharp
  // HACK: Solución temporal para evitar una excepción.
  ```

---

## **3. Tipos Primitivos 🎯**

### **Descripción de los Tipos Primitivos**:

| **Tipo**      | **Tamaño**       | **Rango de Valores**                    | **Ejemplo de Uso**                                      |
|---------------|------------------|-----------------------------------------|---------------------------------------------------------|
| **bool**      | 1 byte            | `true` o `false`                        | ``` bool esActivo = true; ```                     |
| **int**       | 4 bytes           | -2,147,483,648 a 2,147,483,647          | ``` int numero = 42; ```                          |
| **decimal**   | 16 bytes          | -7.9 x 10^28 a 7.9 x 10^28              | ``` decimal salario = 1234.56m; ```               |
| **char**      | 2 bytes (UTF-16)  | Caracteres de la tabla UTF-16           | ``` char letra = 'A'; ```                         |
| **string**    | Variable          | Cadena de caracteres                    | ``` string mensaje = "Hola, Mundo"; ```           |
| **DateTime**  | 8 bytes           | Fechas entre 01/01/0001 y 31/12/9999    | ``` DateTime hoy = DateTime.Now; ```              |

---

### **Operadores Comunes en Tipos Numéricos** 🔢

| **Operador**    | **Descripción**           | **Ejemplo**                              |
|-----------------|---------------------------|------------------------------------------|
| `+`             | Suma                      | ``` int suma = 5 + 3; ```          |
| `-`             | Resta                     | ``` int resta = 5 - 3; ```         |
| `*`             | Multiplicación            | ``` int producto = 5 * 3; ```      |
| `/`             | División                  | ``` int division = 6 / 2; ```      |
| `%`             | Módulo (Resto)            | ``` int resto = 7 % 2; ```         |

**Ejemplo Completo**:
```csharp
bool esVerdadero = false;
int edad = 30;
decimal precio = 99.99m;
char inicial = 'J';
string saludo = "¡Hola!";
DateTime hoy = DateTime.Now;
```

---

## **4. Colecciones 🗂️**

### **Tipos de Colecciones**:

| **Colección**          | **Descripción**                                                                 | **Ejemplo**                                           |
|------------------------|---------------------------------------------------------------------------------|-------------------------------------------------------|
| **Array**              | Arreglo de tamaño fijo con elementos del mismo tipo                              | ``` int[] numeros = {1, 2, 3}; ```              |
| **List<T>**            | Lista genérica de tamaño dinámico                                                | ``` List<string> nombres = new List<string>(); ``` |
| **Dictionary<TKey, TValue>** | Colección de pares clave-valor                                          | ``` Dictionary<int, string> diccionario = new Dictionary<int, string>(); ``` |

### **Ejemplo de Uso de Listas**:
```csharp
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
numeros.Add(6);  // Añadir un nuevo número
Console.WriteLine(numeros[0]);  // Imprime el primer número
```

---

## **5. Tipos Avanzados 🚀**

| **Tipo**       | **Descripción**                                                                 | **Ejemplo**                                             |
|----------------|---------------------------------------------------------------------------------|---------------------------------------------------------|
| **Enum**       | Define un conjunto de constantes simbólicas asociadas a valores numéricos        | ``` enum Dias { Lunes, Martes, Miercoles }; ```    |
| **Dynamic**    | Permite cambiar el tipo en tiempo de ejecución                                   | ``` dynamic dato = 5; dato = "Texto"; ```         |
| **Interface**  | Define un contrato para clases sin implementación                               | ``` interface IVehiculo { void Arrancar(); } ```  |
| **Delegate**   | Referencia a un método                                                          | ``` delegate void Operacion(int a, int b); ```    |

---

## **6. Bloques de Control de Flujo 🔄**

### **Condicionales**:

| **Estructura**         | **Ejemplo**                                                                                              |
|------------------------|----------------------------------------------------------------------------------------------------------|
| **if/else**            | ``` if (edad >= 18) { Console.WriteLine("Mayor de edad"); } else { Console.WriteLine("Menor"); } ``` |
| **Operador Ternario**  | ``` string resultado = (edad >= 18) ? "Mayor" : "Menor"; ```                                       |

### **Bucles**:

| **Tipo de Bucle**      | **Descripción**                                                                                           | **Ejemplo**                                                                                               |
|------------------------|-----------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| **for**                | Itera un número específico de veces                                                                       | ``` for (int i = 0; i < 5; i++) { Console.WriteLine(i); } ```                                        |
| **while**              | Repite el código mientras la condición sea verdadera                                                      | ```csharp while (edad < 18) { Console.WriteLine("Menor de edad"); } ```                                    |
| **foreach**            | Itera sobre una colección                                                                                 | ``` foreach (var nombre in nombres) { Console.WriteLine(nombre); } ```                               |

---

### **Manejo de Excepciones**:

**Estructura Try-Catch**:
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

---

## **7. Puntos de Interrupción (Breakpoints) 🛑**

Los *breakpoints* permiten detener la ejecución del programa en un punto específico para inspeccionar el estado de las variables.

### **Tipos de Breakpoints**:
| **Tipo**              | **Descripción**                                                                             |
|-----------------------|---------------------------------------------------------------------------------------------|
| **Simple**            | Detiene la ejecución en una línea específica.                                               |
| **Condicional**       | Se detiene solo cuando se cumple una condición.                                             |

---

## **8. Novedades en C# 10 🔥**

C# 10 introduce varias mejoras y optimizaciones, como los tipos implícitos `global using` y mejoras en la inferencia de tipos.

🌐 **Más información**:  
- [Novedades en C# 10](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)
