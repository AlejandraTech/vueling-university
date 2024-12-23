# 🌟 **Unidad 3: C# 7 con OOP**

## 🗂️ **Índice**

| **Sección**                                                            | **Descripción**                                                          |
| ---------------------------------------------------------------------- | ------------------------------------------------------------------------ |
| [📚 Clase y Objeto](#-1-clase-y-objeto)                                | Introducción a los conceptos de clase y objeto en C#.                    |
| [🔧 Componentes de una Clase en C#](#-2-componentes-de-una-clase-en-c) | Campos, propiedades, métodos y modificadores de acceso en C#.            |
| [📏 Principios de OOP](#-3-principios-de-oop)                          | Herencia, encapsulación, abstracción y polimorfismo en programación OOP. |
| [✔️ Ventajas de Usar OOP](#-4-ventajas-de-usar-oop)                    | Beneficios clave del paradigma de programación orientada a objetos.      |
| [📚 Referencias](#-referencias)                                        | Fuentes y recursos adicionales para profundizar en los conceptos de OOP. |

---

## 1. 📚 Clase y Objeto

### 🧐 Introducción a Clases y Objetos

La programación orientada a objetos (OOP, del inglés _Object-Oriented Programming_) organiza el software en torno a **objetos** y sus interacciones. Los conceptos de **clase** y **objeto** son la base de este paradigma.

#### 🏷️ Definiciones Clave:

- **Clase**:

  - Una **clase** es un molde o plantilla que define las características y comportamientos de los objetos que se crearán a partir de ella.
  - Contiene:
    - **Atributos (campos)**: Representan las características o datos del objeto.
    - **Métodos**: Definen las acciones o comportamientos del objeto.
  - Ejemplo del mundo real: La clase "Coche" podría incluir atributos como `marca`, `modelo`, `color` y métodos como `acelerar()` o `frenar()`.

- **Objeto**:
  - Un **objeto** es una instancia de una clase. Cada objeto tiene su propio conjunto de valores para los atributos y puede ejecutar métodos definidos por su clase.
  - Ejemplo del mundo real: Un coche específico (marca "Toyota", modelo "Corolla", color "Rojo").

#### Comparación con otros paradigmas:

| Paradigma               | Características                                                                               |
| ----------------------- | --------------------------------------------------------------------------------------------- |
| **Procedural**          | Organiza el código en funciones independientes.                                               |
| **Orientado a Objetos** | Organiza el código en torno a objetos que interactúan entre sí, con encapsulación y herencia. |
| **Funcional**           | Utiliza funciones puras y evita estados mutables.                                             |

---

### 📊 Modelo Visual

Para comprender este concepto de manera más clara y visual, pensemos en cómo percibimos el mundo a nuestro alrededor:

1. **Percepción Humana**: Recibimos información a través de los sentidos; en este caso, nos centraremos en la **vista**.
2. **La Visión como Pixeles**: Nuestra percepción visual puede imaginarse como una enorme matriz de pequeños puntos de color, similares a los **pixeles** de una pantalla.
3. **Clasificación de los Pixeles**:
   - **Estáticos**: Representan elementos que no cambian de color ni posición, como una montaña o un edificio.
   - **Dinámicos**: Representan elementos en movimiento o que cambian de color, como un coche avanzando por la calle o las hojas de un árbol agitadas por el viento.

**Ejemplo Práctico**:  
Podemos llevar este concepto al mundo de la programación con el siguiente ejemplo de una clase y sus objetos:

#### **Clase: Persona**

Una **clase** es un modelo que define las propiedades (**atributos**) y comportamientos (**métodos**) comunes de un conjunto de objetos.

- **Atributos**:

  - `nombre` (cadena de texto)
  - `edad` (número entero)
  - `género` (cadena de texto)

- **Métodos**:
  - `hablar()`
  - `caminar()`

#### **Objetos de la Clase Persona**:

Cada **objeto** es una instancia de la clase con valores específicos.

1. **Objeto Persona A**:

   - `nombre`: "Juan"
   - `edad`: 30
   - `género`: "masculino"

2. **Objeto Persona B**:
   - `nombre`: "Ana"
   - `edad`: 25
   - `género`: "femenino"

---

**Representación Gráfica**:

```
                      Clase Persona
                 -------------------------
                | Atributos:              |
                | - nombre : string       |
                | - edad : int            |
                | - género : string       |
                | Métodos:                |
                | - hablar()              |
                | - caminar()             |
                 -------------------------

        Objeto Juan                 Objeto Ana
    ---------------------       --------------------
   | nombre: "Juan"      |     | nombre: "Ana"      |
   | edad: 30            |     | edad: 25           |
   | género: "masculino" |     | género: "femenino" |
    ---------------------       --------------------
```

---

### 🔄 Nomenclatura en OOP

La OOP introduce su propia terminología:

| Concepto del mundo real             | Equivalente en OOP    |
| ----------------------------------- | --------------------- |
| Objeto único                        | Objeto                |
| Grupo de objetos similares          | Clase                 |
| Características de los objetos      | Atributos/Propiedades |
| Acciones realizadas por los objetos | Métodos               |
| Jerarquías entre entidades          | Herencia entre clases |

---

### 💻 Ejemplo de Clase y Objeto

```csharp
// Definición de una clase
public class Coche
{
    // Campos
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Velocidad { get; set; }

    // Método para acelerar
    public void Acelerar(int incremento)
    {
        Velocidad += incremento;
    }
}

// Creación de un objeto
Coche miCoche = new Coche
{
    Marca = "Toyota",
    Modelo = "Corolla",
    Velocidad = 0
};

// Invocación de un método
miCoche.Acelerar(20);
Console.WriteLine($"La velocidad del {miCoche.Marca} {miCoche.Modelo} es {miCoche.Velocidad} km/h.");
```

---

### 📈 Diagrama de Clase

Un **diagrama de clase** visualiza la estructura de una clase, sus atributos y métodos, y las relaciones con otras clases. Ejemplo:

```
             Persona
---------------------------------
- Nombre : string
- Edad : int
---------------------------------
+ Hablar() : void
+ Caminar() : void
```

---

## 2. 🔧 Componentes de una Clase en C#

Una clase en C# consta de varios elementos principales que juntos definen su estructura y comportamiento.

### 🧩 Campos

Los **campos** son variables que contienen datos asociados al estado de un objeto.

```csharp
public class Persona
{
    public string Nombre;
    public int Edad;
}
```

### 🧩 Propiedades

Las **propiedades** encapsulan campos, controlando su acceso.

```csharp
public class Persona
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
}
```

### 🧩 Métodos

Los **métodos** definen el comportamiento que una clase puede realizar.

```csharp
public class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }
}
```

---

### ⚙️ Ejemplo de Métodos

```csharp
public class Calculadora
{
    // Método que suma dos números
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    // Método que resta dos números
    public int Restar(int a, int b)
    {
        return a - b;
    }
}

// Uso de los métodos
Calculadora calc = new Calculadora();
int resultadoSuma = calc.Sumar(5, 3); // resultadoSuma será 8
int resultadoResta = calc.Restar(5, 3); // resultadoResta será 2
```

---

### 🔑 Modificadores de Acceso

Los modificadores de acceso determinan la visibilidad de los campos, métodos y propiedades:

| Modificador            | Descripción                                                                    |
| ---------------------- | ------------------------------------------------------------------------------ |
| **public**             | Accesible desde cualquier clase.                                               |
| **private**            | Accesible solo dentro de la propia clase.                                      |
| **protected**          | Accesible dentro de la propia clase y clases derivadas.                        |
| **internal**           | Accesible solo dentro del mismo ensamblado.                                    |
| **protected internal** | Accesible en la misma clase y en clases derivadas dentro del mismo ensamblado. |

---

## 3. 📏 Principios de OOP

Existen cuatro principios fundamentales en la OOP: **Herencia**, **Encapsulación**, **Abstracción** y **Polimorfismo**.

### **Herencia**

Permite que una clase base comparta atributos y métodos con una clase derivada.

```csharp
public class Vehiculo
{
    public int Ruedas { get; set; }
    public void Mover()
    {
        Console.WriteLine("El vehículo se mueve.");
    }
}

// Clase derivada
public class Coche : Vehiculo
{
    public int Puertas { get; set; }

    public void Acelerar()
    {
        Console.WriteLine("El coche acelera.");
    }
}

// Uso
Coche miCoche = new Coche();
miCoche.Ruedas = 4;
miCoche.Puertas = 4;
miCoche.Mover(); // Heredado de Vehiculo
miCoche.Acelerar(); // Método específico de Coche
```

### **Encapsulación**

Protege el estado interno de un objeto y solo expone lo necesario.

```csharp
public class CuentaBancaria
{
    private decimal saldo;

    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
        }
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}

// Uso
CuentaBancaria cuenta = new CuentaBancaria();
cuenta.Depositar(100);
Console.WriteLine("Saldo: " + cuenta.ObtenerSaldo());
```

### Abstracción

Oculta detalles de implementación, mostrando solo características esenciales mediante clases y métodos abstractos.

```csharp
public abstract class Forma
{
    public abstract double CalcularArea(); // Método abstracto
}

public class Circulo : Forma
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

// Uso
Forma miCirculo = new Circulo { Radio = 5 };
Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
```

### **Polimorfismo**

Permite tratar objetos de diferentes tipos de manera uniforme.

```csharp
public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("¡Guau!");
    }
}

public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("¡Miau!");
    }
}

public void HacerSonidoDelAnimal(Animal animal)
{
    animal.HacerSonido(); // Se puede pasar un Perro o un Gato
}

// Uso
HacerSonidoDelAnimal(new Perro()); // ¡Guau!
HacerSonidoDelAnimal(new Gato()); // ¡Miau!
```

---

## 4. ✔️ Ventajas de Usar OOP

Las ventajas de utilizar la programación orientada a objetos incluyen:

- **Reusabilidad**: Se pueden reutilizar clases en diferentes contextos.
- **Modularidad**: Divide sistemas complejos en componentes más simples.
- **Mantenibilidad**: Cambios se pueden realizar sin afectar otras partes.
- **Productividad**: Permite trabajar en paralelo en módulos.
- **Escalabilidad**: Cambios en una clase son fáciles de implementar.
- **Flexibilidad**: Adaptar el código a nuevas necesidades.
- **Testabilidad**: Facilita la creación de pruebas unitarias.
- **Seguridad**: Protege datos críticos con encapsulación.

---

## 📚 Referencias

1. [Microsoft Docs: Introducción a OOP en C#](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/)

2. [GeeksforGeeks: C# y OOP](https://www.geeksforgeeks.org/c-sharp-object-oriented-programming/)

3. [W3Schools: C# Classes](https://www.w3schools.com/cs/cs_classes.php)
