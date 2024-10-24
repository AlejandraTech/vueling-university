# 🌟 **Unit 3: Csharp 7 with OOP**

### 🗂️ **Índice**

| Sección                                                   | Descripción                                                                 |
|-----------------------------------------------------------|-----------------------------------------------------------------------------|
| [📚 Clase y Objeto](#-1-clase-y-objeto)                  | Introducción a los conceptos de clase y objeto en C#.                      |
| [📊 Modelo Visual](#-modelo-visual)                      | Visualización del concepto de clases y objetos.                             |
| [🔄 Nomenclatura en OOP](#-nomenclatura-en-oop)          | Terminología y cambios en la nomenclatura al usar OOP.                    |
| [💻 Ejemplo de Clase y Objeto](#-ejemplo-de-clase-y-objeto) | Implementación práctica de clase y objeto.                                  |
| [📈 Diagrama de Clase](#-diagrama-de-clase)              | Representación visual de una clase y sus relaciones.                       |
| [🔧 Componentes de una Clase en C#](#-2-campo-método-propiedad-atributo) | Descripción de los elementos que componen una clase.                        |
| [⚙️ Ejemplo de Métodos](#-ejemplo-de-métodos)            | Ejemplos de implementación de métodos en clases.                           |
| [🔑 Modificadores de Acceso](#-modificadores-de-acceso)  | Explicación de los modificadores de acceso y su uso.                       |
| [📏 Principios de OOP](#-3-principios-de-oop)            | Fundamentos de la programación orientada a objetos.                        |
| [✔️ Ventajas de Usar OOP](#-4-beneficios-de-oop)         | Beneficios y ventajas de aplicar OOP en el desarrollo de software.        |
| [🔒 Ejemplo de Seguridad](#-ejemplo-de-seguridad)        | Ejemplo práctico de cómo la encapsulación mejora la seguridad en OOP.      |

---

## 📚 1. Clase y Objeto

### 🧐 Introducción a Clases y Objetos
La programación orientada a objetos (OOP) es un paradigma que organiza el software en **"objetos"**, que son instancias de **"clases"**. Los conceptos de **clase** y **objeto** son fundamentales para OOP.

#### 🏷️ Definiciones Clave:
- **Clase**: Plantilla que define un tipo de objeto. Puede contener:
  - **Atributos** (o campos): Definen el estado del objeto.
  - **Métodos**: Definen el comportamiento del objeto.

- **Objeto**: Instancia de una clase. Cada objeto tiene sus propios valores para los atributos.

### 📊 Modelo Visual
Para entender mejor el concepto, imaginemos cómo percibimos el mundo:

1. **Percepción**: Los humanos reciben información a través de los sentidos. Aquí nos enfocamos en la vista.
2. **Pixeles Humanos**: Nuestra visión puede describirse como una matriz de puntos de color (pixeles).
3. **Clasificación de Pixeles**:
   - **Estáticos**: No cambian de color (ej. una montaña).
   - **Dinámicos**: Cambian de color o posición (ej. un coche en movimiento).

### 🔄 Nomenclatura en OOP
A partir de la analogía anterior, realizamos los siguientes cambios terminológicos:

| Término Original                          | Término en OOP                        |
|-------------------------------------------|---------------------------------------|
| Unidad                                    | Objeto                                |
| Grupo de unidades                         | Clase                                 |
| Cualidades                                | Campos/Propiedades                    |
| Grupo de unidades con características comunes | Clase Hija                        |
| Comportamiento intrínseco                 | Implementación del constructor        |
| Comportamiento reactivo                   | Métodos del objeto                    |

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

### 📈 Diagrama de Clase
Los diagramas de clases representan visualmente las clases y sus relaciones. Un ejemplo simple sería:

```
Coche
-----------
- Marca : string
- Modelo : string
- Velocidad : int
-----------
+ Acelerar(int incremento) : void
```

---

## 🔍 2. Campo, Método, Propiedad, Atributo

### 🔧 Componentes de una Clase en C#
Dentro de una clase en C#, se pueden incluir varios elementos:

- **Campos**: Variables que almacenan datos. 
  ```csharp
  public string Nombre; // campo público
  ```

- **Métodos**: Funciones que definen el comportamiento de la clase. 
  ```csharp
  public void MostrarNombre() 
  {
      Console.WriteLine(Nombre);
  }
  ```

- **Propiedades**: Métodos especiales que permiten acceder a los campos de forma controlada. 
  ```csharp
  private string nombre;
  public string Nombre
  {
      get { return nombre; }
      set { nombre = value; }
  }
  ```

- **Atributos**: Metadatos aplicados a clases, campos o métodos que modifican su comportamiento.

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

### 🔑 Modificadores de Acceso
Los modificadores de acceso determinan la visibilidad de los campos, métodos y propiedades:

| Modificador      | Descripción                                           |
|------------------|------------------------------------------------------|
| **public**       | Accesible desde cualquier clase.                     |
| **private**      | Accesible solo dentro de la propia clase.            |
| **protected**    | Accesible dentro de la propia clase y clases derivadas. |
| **internal**     | Accesible solo dentro del mismo ensamblado.          |
| **protected internal** | Accesible en la misma clase y en clases derivadas dentro del mismo ensamblado. |

---

## 📏 3. Principios de OOP

Los principios de la programación orientada a objetos son fundamentales:

### 1. Herencia
Permite a una clase derivar de otra, heredando sus atributos y métodos. 

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

### 2. Encapsulación
Restringe el acceso a ciertos componentes de un objeto, protegiendo su estado interno.

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

### 3. Abstracción
Oculta detalles de implementación, mostrando solo características esenciales mediante clases abstractas y métodos abstractos.

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

### 4. Polimorfismo
Permite usar objetos de

 diferentes clases de manera intercambiable, utilizando una interfaz común o una clase base.

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

## ✔️ 4. Ventajas de Usar OOP
Las ventajas de utilizar la programación orientada a objetos incluyen:

- **Reusabilidad**: Métodos y clases pueden ser reutilizados.
- **Mantenibilidad**: Cambios se pueden realizar sin afectar otras partes.
- **Productividad**: Permite trabajar en paralelo en módulos.
- **Escalabilidad**: Cambios en una clase son fáciles de implementar.
- **Flexibilidad**: Adaptar el código a nuevas necesidades.
- **Testabilidad**: Facilita la creación de pruebas unitarias.
- **Seguridad**: La encapsulación protege datos sensibles.

### 🔒 Ejemplo de Seguridad

```csharp
public class Usuario
{
    private string password;

    public void EstablecerPassword(string nuevaPassword)
    {
        // Validar la contraseña antes de establecerla
        if (!string.IsNullOrEmpty(nuevaPassword) && nuevaPassword.Length >= 6)
        {
            password = nuevaPassword;
        }
        else
        {
            throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.");
        }
    }

    public bool ValidarPassword(string passwordIntento)
    {
        return password == passwordIntento;
    }
}

// Uso
Usuario usuario = new Usuario();
usuario.EstablecerPassword("miContraseñaSegura");
bool esValido = usuario.ValidarPassword("miContraseñaSegura"); // esValido será true
```
