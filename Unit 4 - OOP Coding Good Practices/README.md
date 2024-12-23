# 🌟 **Unidad 4: Buenas Prácticas de Codificación en OOP**

### 🗂️ **Índice**

| Sección                                                                                   | Descripción                                                                                    |
| ----------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| [📜 Convenciones de Codificación en C#](#1-convenciones-de-codificación-en-c)             | Principales convenciones de codificación para asegurar claridad y consistencia en C#.          |
| [🌐 Principios de Diseño: SOLID, CUPID, GRASP](#2-principios-de-diseño-solid-cupid-grasp) | Principios clave para estructurar el código en programación orientada a objetos.               |
| [🎯 Acrónimos Importantes](#3-más-acrónimos-importantes)                                  | Explicación de acrónimos populares como DRY, KISS y YAGNI.                                     |
| [🧹 Código Limpio](#4-código-limpio)                                                      | Principios y prácticas para mantener el código comprensible y libre de elementos innecesarios. |
| [📐 Domain-Driven Design (DDD)](#5-domain-driven-design-ddd)                              | Conceptos clave de DDD para diseñar el software basado en el dominio del negocio.              |
| [📚 Patrones de Diseño de GoF](#6-patrones-de-diseño-de-gof)                              | Patrones clásicos de diseño para resolver problemas comunes de desarrollo de software.         |

---

## **1. 📜 Convenciones de Codificación en C#**

Las convenciones de codificación de C# aseguran consistencia y claridad. Entre las más importantes tenemos:

| **Aspecto**                  | **Descripción**                                                                                                    |
| ---------------------------- | ------------------------------------------------------------------------------------------------------------------ |
| **Nombres**                  | Clases en _PascalCase_, métodos en _camelCase_. Ej.: `public class CuentaBancaria` y `public void AgregarSaldo()`. |
| **Layout**                   | Utiliza espacio uniforme y comentarios claros para mejorar la legibilidad.                                         |
| **Interpolación de cadenas** | Preferir `$"{variable}"` para evitar concatenación excesiva.                                                       |
| **Uso de `var`**             | Usar `var` solo si el tipo de variable es evidente en la declaración.                                              |
| **Manejo de errores**        | Implementar `try-catch` en métodos que interactúan con recursos externos.                                          |

> [!TIP]
> 🔗 Más detalles en la [guía oficial](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).

---

## **2. 🌐 Principios de Diseño: SOLID, CUPID, GRASP**

### **Principios SOLID**

| **Principio**             | **Descripción**                                                                              |
| ------------------------- | -------------------------------------------------------------------------------------------- |
| **Single Responsibility** | Cada clase debe tener una única responsabilidad o razón para cambiar.                        |
| **Open-Closed**           | Las clases deben estar abiertas para extensión, pero cerradas para modificación.             |
| **Liskov Substitution**   | Las clases derivadas deben poder usarse en lugar de sus clases base sin problemas.           |
| **Interface Segregation** | Preferir interfaces específicas para cada cliente en lugar de interfaces generales.          |
| **Dependency Inversion**  | Los módulos de alto nivel no deben depender de módulos de bajo nivel, sino de abstracciones. |

#### **Ejemplo de Principio SOLID - Single Responsibility**:

```csharp
public class Reporte
{
    public void Generar() { /* Genera reporte */ }
}

public class EnviarReporte
{
    public void Enviar(Reporte reporte) { /* Envía el reporte */ }
}
```

> [!TIP]
> Aplicar el Principio SOLID ayuda a que el código sea más mantenible y fácil de expandir sin efectos colaterales.

### **Principios CUPID**

| **Principio**       | **Descripción**                                                                        |
| ------------------- | -------------------------------------------------------------------------------------- |
| **Composable**      | Crear componentes independientes que funcionen bien juntos.                            |
| **Unix Philosophy** | "Haz una cosa y hazla bien." Diseña cada componente con una función específica.        |
| **Predictable**     | El sistema debe comportarse de forma consistente y ser fácil de monitorear y predecir. |
| **Idiomatic**       | Sigue las convenciones y prácticas estándar del lenguaje.                              |
| **Domain-based**    | Usa terminología y estructura que reflejen el dominio real del sistema.                |

### **Patrones de Diseño GRASP**

| **Patrón**             | **Descripción**                                                                  |
| ---------------------- | -------------------------------------------------------------------------------- |
| **Controller**         | Gestiona datos de entrada desde la capa de presentación.                         |
| **Creator**            | Designa la clase responsable de crear instancias de otra clase.                  |
| **Indirection**        | Introduce una capa intermedia entre formatos de datos diferentes.                |
| **Information Expert** | Asigna responsabilidades a la clase con la mayor información sobre otras clases. |

> [!CAUTION]
> Usar los patrones sin entender su contexto específico puede complicar en lugar de simplificar el código.

---

## **3. 🎯 Más Acrónimos Importantes**

| **Acrónimo** | **Significado**            | **Descripción**                                                                     |
| ------------ | -------------------------- | ----------------------------------------------------------------------------------- |
| **YAGNI**    | _You Ain't Gonna Need It!_ | No añadas funcionalidad que no es necesaria.                                        |
| **DRY**      | _Don't Repeat Yourself!_   | Cada parte de conocimiento debe tener una única representación clara en el sistema. |
| **KISS**     | _Keep It Simple, Stupid!_  | Prefiere soluciones simples a complejas; simplifica siempre que sea posible.        |

> [!NOTE]  
> Aplicar DRY y KISS puede evitar errores y redundancias a largo plazo, haciendo el código más claro y manejable.

---

## **4. 🧹 Código Limpio**

Aplicar el _Clean Code_ significa escribir código que sea fácil de entender y modificar.

### **Principios de Código Limpio**:

| **Principio**                 | **Descripción**                                                                  |
| ----------------------------- | -------------------------------------------------------------------------------- |
| **Nombres significativos**    | Usa nombres de variables, clases y métodos que indiquen claramente su propósito. |
| **Evita código no usado**     | Remueve funciones o variables sin uso para reducir el desorden.                  |
| **Organización y estructura** | Mantén una estructura lógica, usa métodos pequeños y claros.                     |
| **Evita "números mágicos"**   | Reemplaza valores numéricos directos con constantes significativas.              |
| **Pruebas unitarias**         | Escribe tests para validar la funcionalidad y facilitar el mantenimiento.        |

> [!WARNING]  
> No eliminar el código no utilizado puede llevar a errores difíciles de diagnosticar, especialmente en sistemas grandes.

---

## **5. 📐 Domain-Driven Design (DDD)**

**DDD** es una filosofía que busca reflejar el dominio real en el diseño del software para hacerlo más comprensible y alineado con los objetivos del negocio.

### **Elementos Clave de DDD**:

| **Elemento**             | **Descripción**                                                          |
| ------------------------ | ------------------------------------------------------------------------ |
| **Entidades**            | Objetos con identidad única y un ciclo de vida continuo.                 |
| **Objetos de Valor**     | Objetos que representan una característica y no tienen identidad propia. |
| **Agregados**            | Clúster de objetos que se tratan como una unidad.                        |
| **Repositorios**         | Interfaces para acceso a datos y almacenamiento de objetos de dominio.   |
| **Servicios de Dominio** | Orquestan la lógica que involucra varias entidades y repositorios.       |

#### **Ejemplo de un Repositorio**:

```csharp
public interface IRepositorioCliente
{
    Cliente ObtenerClientePorId(int id);
    void Guardar(Cliente cliente);
}
```

> [!IMPORTANT]  
> Entender el contexto y el dominio del negocio es esencial antes de implementar patrones de DDD para evitar un diseño innecesariamente complejo.

---

## **6. 📚 Patrones de Diseño de GoF**

Los **Patrones de GoF (Gang of Four)** son soluciones estándar a problemas comunes de diseño en el desarrollo de software.

### **Patrones Creacionales**

| **Patrón**         | **Descripción**                                                                                          |
| ------------------ | -------------------------------------------------------------------------------------------------------- |
| **Singleton**      | Asegura que solo haya una instancia de una clase y proporciona un acceso global a ella.                  |
| **Factory Method** | Define una interfaz para crear objetos, pero permite a las subclases decidir qué clase instanciar.       |
| **Builder**        | Separa la construcción de un objeto complejo de su representación para crear diferentes configuraciones. |

#### **Ejemplo de Singleton**:

```csharp
public class Singleton
{
    private static Singleton instancia;
    private Singleton() {}

    public static Singleton Instancia
    {
        get
        {
            if (instancia == null) instancia = new Singleton();
            return instancia;
        }
    }
}
```

> [!NOTE]  
> Los patrones creacionales permiten construir objetos de forma más flexible y escalable, especialmente cuando sus dependencias son complejas.

### **Patrones Estructurales**

| **Patrón**    | **Descripción**                                                                        |
| ------------- | -------------------------------------------------------------------------------------- |
| **Adapter**   | Permite que interfaces incompatibles trabajen juntas mediante una clase adaptadora.    |
| **Facade**    | Proporciona una interfaz simplificada para un subsistema complejo.                     |
| **Decorator** | Agrega comportamiento adicional a un objeto dinámicamente sin modificar su estructura. |

> [!TIP]
> Usa Facade para reducir la complejidad de sistemas que exponen demasiados detalles de implementación.

### **Patrones de Comportamiento**

| **Patrón**          | **Descripción**                                                                        |
| ------------------- | -------------------------------------------------------------------------------------- |
| **Observer**        | Permite que múltiples objetos se suscriban a eventos generados por otro objeto.        |
| **Strategy**        | Define una familia de algoritmos y los encapsula en clases intercambiables.            |
| **Template Method** | Define el esqueleto de un algoritmo en un método, delegando algunos pasos a subclases. |

> [!CAUTION]  
> Seleccionar patrones de diseño sin un análisis cuidadoso puede llevar a una sobrecarga innecesaria, aumentando la complejidad del sistema.

---

## 📚 Referencias

#### **1. Convenciones de Codificación en C#**

- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [C# Coding Best Practices](https://www.pluralsight.com)

#### **2. Principios de Diseño: SOLID, CUPID, GRASP**

- [Clean Architecture: A Craftsman's Guide to Software Structure and Design](https://www.oreilly.com)
- [CUPID Principles for Software Design](https://github.com)
- [Object-Oriented Design Principles](https://www.objectmentor.com)

#### **3. Acrónimos Importantes: DRY, KISS, YAGNI**

- [YAGNI and Other Principles](https://www.altexsoft.com)
- [KISS in Software Development](https://www.thoughtworks.com)

#### **4. Código Limpio**

- [Clean Code: A Handbook of Agile Software Craftsmanship](https://www.oreilly.com)
- [10 Tips for Writing Clean Code](https://medium.com)

#### **5. Domain-Driven Design (DDD)**

- [Domain-Driven Design: Tackling Complexity in the Heart of Software](https://www.dddcommunity.org)
- [An Introduction to DDD](https://www.baeldung.com)

#### **6. Patrones de Diseño de GoF**

- [Design Patterns: Elements of Reusable Object-Oriented Software](https://www.oreilly.com)
- [Design Patterns Tutorial](https://refactoring.guru)
- [Design Patterns in Object-Oriented Programming](https://www.geeksforgeeks.org)
