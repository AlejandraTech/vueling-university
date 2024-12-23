# 🌟 **Unidad 9: Pruebas Unitarias en APIs**

En esta unidad aprenderemos a estructurar y escribir pruebas unitarias para APIs utilizando **xUnit** y **Moq**. Se explicará cómo configurar el proyecto de pruebas, instalar las dependencias necesarias, y diseñar pruebas efectivas mediante el patrón **Arrange-Act-Assert**.

---

### 🗂️ **Índice**

| Sección                                                 | Descripción                                                                                        |
| ------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| 📁 **Creación del Proyecto de Tests**                   | Pasos para crear y configurar un proyecto de pruebas unitarias con xUnit.                          |
| 📦 **Instalación de Paquetes NuGet**                    | Instrucciones para instalar las dependencias necesarias en el proyecto.                            |
| 🏗️ **Estructura del Código de Tests**                   | Explicación del patrón **Arrange-Act-Assert** para estructurar las pruebas.                        |
| ✍️ **Ejemplo de Test Unitario**                         | Código de ejemplo para crear pruebas unitarias con xUnit y Moq.                                    |
| 🗂️ **Estructura de Carpetas con las Pruebas Unitarias** | Organización de los proyectos y carpetas dentro de una solución al integrar las pruebas unitarias. |
| 📚 **Referencias**                                      | Recursos adicionales para profundizar en pruebas unitarias y frameworks.                           |

---

## 📁 **Creación del Proyecto de Tests**

Para empezar con las pruebas unitarias, es necesario crear un nuevo proyecto de pruebas en la solución de tu aplicación.

1. **Crear una carpeta para pruebas**:

   - Dentro de la solución, crea una nueva carpeta llamada `Testing`.

2. **Agregar un proyecto de pruebas**:

   - Haz clic derecho en la carpeta **DistributedServices** y selecciona **Agregar > Nuevo proyecto...**.

3. **Seleccionar la plantilla adecuada**:

   - Elige la plantilla **Proyecto de pruebas xUnit**.

4. **Configurar el proyecto**:
   - Nombra el proyecto como: `NombreProyecto.Testing.NombreCapa` (por ejemplo, `MiApp.Testing.DistributedServices`).
   - Selecciona la versión de .NET deseada (recomendado: **.NET 6.0**).

---

## 📦 **Instalación de Paquetes NuGet**

Para realizar pruebas unitarias, se necesitan algunos paquetes adicionales que faciliten la creación de pruebas y la simulación de dependencias. Sigue estos pasos:

1. **Acceder a NuGet**:

   - Haz clic derecho en el proyecto de pruebas dentro del **Explorador de Soluciones**.
   - Selecciona **Administrar paquetes NuGet**.

2. **Buscar e instalar paquetes**:

   - En la pestaña **Explorar**, busca los siguientes paquetes y haz clic en **Instalar**:
     - `xunit`
     - `Moq`
     - `xunit.runner.visualstudio` _(opcional, mejora la integración con Visual Studio)_.

3. **Verificar dependencias**:
   - Confirma que las dependencias estén correctamente instaladas en la sección **Referencias** del proyecto.

---

## 🏗️ **Estructura del Código de Tests**

La estructura de los tests unitarios sigue un patrón conocido como **Arrange-Act-Assert**:

1. **Arrange**:

   - Configura el entorno necesario para la prueba.
   - Inicializa variables, crea mocks y define sus comportamientos.

2. **Act**:

   - Llama al método o funcionalidad que se desea probar.

3. **Assert**:
   - Verifica que los resultados obtenidos sean los esperados utilizando aserciones.

---

### ✍️ **Ejemplo de Test Unitario**

A continuación, se presenta un ejemplo básico de un test unitario que utiliza **xUnit** para la estructura de las pruebas y **Moq** para simular dependencias:

```csharp
using Moq;
using NombreProyecto.Domain.Models; // Importa el namespace correcto para las entidades o servicios.
using Xunit;

namespace NombreProyecto.Testing.DistributedServices
{
    public class EjemploUnitTests
    {
        [Fact] // Indica que este método es una prueba unitaria.
        public void MetodoATestear_ResultadoEsperado_CasoExitoso()
        {
            // Arrange: Configuramos los mocks y los datos iniciales.
            var mockServicio = new Mock<IServicio>();
            mockServicio.Setup(s => s.MetodoDependencia(It.IsAny<int>())).Returns("Valor esperado");

            var clasePrueba = new ClaseBajoPrueba(mockServicio.Object);

            // Act: Llamamos al método que queremos probar.
            var resultado = clasePrueba.MetodoATestear(42);

            // Assert: Comparamos el resultado con el valor esperado.
            Assert.Equal("Valor esperado", resultado);
        }
    }
}
```

> [!NOTE]
>
> - **Mocking**: `Moq` permite crear objetos simulados para pruebas unitarias, definiendo el comportamiento esperado de dependencias externas.
> - **Atributos en xUnit**:
>   - `[Fact]`: Define un método de prueba unitaria simple.
>   - `[Theory]`: Permite ejecutar pruebas con diferentes conjuntos de datos.

## 🗂️ Estructura de Carpetas con las Pruebas Unitarias

```plaintext
NombreProyecto
│
├── DistributedServices
│   └── NombreProyecto.DistributedServices.WebAPIUI
|   |   └── Controllers
│   ├── appsettings.json
|   └── Program.cs
├── Library
│   ├── NombreProyecto.Library.Contracts
|   |   └── DTOs
│   └── NombreProyecto.Library.Impl
├── Domain
│   └── NombreProyecto.Domain.Models
├── Infrastructure
│   ├── NombreProyecto.Infrastructure.Contracts
|   |   └── Entities
│   └── NombreProyecto.Infrastructure.Impl
|       └── DbContexts
├── XCutting
|    └── NombreProyecto.XCutting.Enums
└── Testing
     └── NombreProyecto.Testing.NombreCapa
```

## 📚 **Referencias**

- [xUnit Documentation](https://xunit.net/docs)
- [Moq Library GitHub](https://github.com/moq/moq4)
- [Getting Started with xUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)
- [Moq Quickstart](https://learn.microsoft.com/en-us/ef/core/testing/)
- [Patterns for Unit Testing](https://martinfowler.com/bliki/TestPyramid.html)
- [Arrange-Act-Assert Pattern](https://en.wikipedia.org/wiki/Arrange_Act_Assert)
