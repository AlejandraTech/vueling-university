# 💻 **Gestión de Cuenta Bancaria Mono-usuario y Multi-usuario**

### 🗂️ **Índice**

| Sección                                                          | Descripción                                                                 |
|------------------------------------------------------------------|-----------------------------------------------------------------------------|
| [📄 Descripción](#-descripción)                                   | Introducción a las tres versiones del proyecto de gestión bancaria.          |
| [📦 Version 1: Gestión de Cuenta Bancaria Mono-usuario](#-version-1-gestión-de-cuenta-bancaria-mono-usuario) | Descripción y funcionalidades para un único cliente.                        |
| [🛠️ Funcionalidades - Versión 1](#-funcionalidades)               | Lista de operaciones disponibles para el cliente en la versión mono-usuario.|
| [🧭 Cómo funciona - Versión 1](#-cómo-funciona)                   | Detalle del flujo de trabajo y funcionamiento general.                      |
| [🚀 Ejecución del programa - Versión 1](#-ejecución-del-programa) | Ejecución y registro de movimientos.                                        |
| [📦 Version 2: Gestión de Cuenta Bancaria Multi-usuario](#-version-2-gestión-de-cuenta-bancaria-multi-usuario) | Explicación del manejo de múltiples clientes con autenticación.             |
| [🛠️ Funcionalidades - Versión 2](#-funcionalidades-1)             | Funciones de autenticación y operaciones para varios usuarios.              |
| [🧭 Cómo funciona - Versión 2](#-cómo-funciona-1)                 | Descripción del proceso de acceso y operaciones para usuarios autenticados.  |
| [🔑 Autenticación](#-autenticación)                               | Proceso de verificación del número de cuenta y PIN.                         |
| [🗃️ Manejo de datos de usuarios](#-manejo-de-datos-de-usuarios)  | Organización de cuentas, pines y movimientos de cada cliente.               |
| [📦 Version 3: Gestión de Cuenta Bancaria con Programación Orientada a Objetos](#-version-3-gestión-de-cuenta-bancaria-con-programación-orientada-a-objetos) | Implementación utilizando OOP para mayor modularidad y mantenimiento.       |
| [🛠️ Funcionalidades - Versión 3](#-funcionalidades-2)             | Funciones de autenticación y operaciones para varios usuarios utilizando OOP.|
| [🧭 Cómo funciona - Versión 3](#-cómo-funciona-2)                 | Descripción del proceso de acceso y operaciones en un enfoque OOP.          |
| [📚 Recursos adicionales](#-recursos-adicionales)                 | Enlaces a documentación oficial de C# y tutoriales de .NET.                 |

---

## 📄 Descripción
Este proyecto tiene tres versiones para gestionar una cuenta bancaria:

1. **Versión 1: Mono-usuario** - Un único cliente puede realizar operaciones como ingresos y retiradas de dinero.
2. **Versión 2: Multi-usuario** - Varios clientes pueden gestionar sus cuentas bancarias utilizando un número de cuenta y un PIN.
3. **Versión 3: Programación Orientada a Objetos** - Similar a la versión 2, pero estructurada utilizando principios de OOP para mayor modularidad y mantenimiento.

Cada versión está diseñada para practicar el uso de C# 10 y diferentes paradigmas de programación.

---

## 📦 Version 1: Gestión de Cuenta Bancaria Mono-usuario

En esta versión, un único cliente puede interactuar con su cuenta bancaria a través de un menú. El saldo del cliente se almacena en una variable y sobre este saldo se realizan las operaciones de ingreso y retirada.

### 🛠️ Funcionalidades
1. **Money income** (Ingresar dinero): Permite agregar dinero al saldo actual.
2. **Money outcome** (Retirar dinero): Permite retirar dinero del saldo actual, siempre que haya saldo suficiente.
3. **List all movements** (Ver todos los movimientos): Muestra un listado de todos los ingresos y retiradas realizadas.
4. **List incomes** (Ver ingresos): Muestra todos los ingresos realizados.
5. **List outcomes** (Ver retiradas): Muestra todas las retiradas realizadas.
6. **Show current money** (Mostrar saldo actual): Muestra el saldo actual del cliente.
7. **Exit** (Salir): Finaliza el programa.

### 🧭 Cómo funciona
- El programa inicia mostrando un menú con las opciones mencionadas.
- El usuario elige la operación que desea realizar.
- Tras completar la operación, se pregunta si desea realizar otra:
  - Si la respuesta es **sí**, se vuelve al menú.
  - Si la respuesta es **no**, se muestra el saldo actual y el programa finaliza.

### 🚀 Ejecución del programa
- El cliente solo tiene acceso a su cuenta y puede realizar las operaciones anteriores.
- Todos los movimientos (ingresos y retiradas) se registran en listas separadas para mostrar la información correctamente cuando el cliente lo solicite.

### Ejemplo de flujo de trabajo:

| Menú de opciones           | Descripción                                              |
| -------------------------- | -------------------------------------------------------- |
| 1. Money income             | El cliente ingresa una cantidad para añadir al saldo.    |
| 2. Money outcome            | El cliente retira una cantidad del saldo disponible.     |
| 3. List all movements       | Muestra una lista de todos los ingresos y retiradas.     |
| 4. List incomes             | Muestra solo los ingresos realizados.                   |
| 5. List outcomes            | Muestra solo las retiradas realizadas.                  |
| 6. Show current money       | Muestra el saldo actual.                                |
| 7. Exit                     | Finaliza el programa.                                   |

---

## 📦 Version 2: Gestión de Cuenta Bancaria Multi-usuario

La versión 2 amplía la funcionalidad para que varios usuarios puedan interactuar con sus cuentas utilizando un número de cuenta y un PIN. Cada usuario tiene su propio saldo y movimientos, almacenados en listas.

### 🛠️ Funcionalidades
1. **Autenticación**: Antes de mostrar el menú de opciones, el cliente debe ingresar su número de cuenta y PIN.
2. **Money income**: Permite agregar dinero al saldo del cliente autenticado.
3. **Money outcome**: Permite retirar dinero del saldo, si hay suficiente.
4. **List all movements**: Muestra un listado de todos los movimientos del cliente autenticado.
5. **List incomes**: Muestra todos los ingresos del cliente autenticado.
6. **List outcomes**: Muestra todas las retiradas del cliente autenticado.
7. **Show current money**: Muestra el saldo del cliente autenticado.
8. **Exit**: Finaliza la sesión del cliente.

### 🧭 Cómo funciona
- El cliente debe ingresar su **número de cuenta** y **PIN**.
- El programa verifica si los datos coinciden en las listas de cuentas y pines.
- Si los datos son correctos, el cliente accede a su información financiera (saldo y movimientos).
- Tras cada operación, se le pregunta si desea realizar otra operación o finalizar.
  
### 🔑 Autenticación
| Paso                          | Descripción                                                      |
| ----------------------------- | ---------------------------------------------------------------- |
| Ingresar número de cuenta      | El cliente ingresa su número de cuenta único.                    |
| Ingresar PIN                   | El cliente ingresa su PIN asociado al número de cuenta.          |
| Verificación                   | El programa valida si el número de cuenta y PIN coinciden.       |

### 🗃️ Manejo de datos de usuarios
- **Listas de cuentas y PINs**: El i-ésimo número de cuenta tiene asociado el i-ésimo PIN, el i-ésimo saldo y el i-ésimo conjunto de movimientos. De esta manera, toda la información del cliente se encuentra organizada en listas paralelas.
  
| Cliente  | Número de Cuenta | PIN   | Saldo  | Movimientos                |
| -------- | ---------------- | ----- | ------ | -------------------------- |
| Cliente 1| 1001             | 1234  | 1000€  | [Ingreso: 500€, Retiro: 100€]|
| Cliente 2| 1002             | 5678  | 1500€  | [Ingreso: 300€, Retiro: 50€] |
| Cliente 3| 1003             | 9101  | 2000€  | [Ingreso: 700€, Retiro: 200€]|

---

## 📦 Version 3: Gestión de Cuenta Bancaria con Programación Orientada a Objetos

Esta versión reestructura la funcionalidad de la versión 2 utilizando programación orientada a objetos (OOP). Esto permite un diseño más modular y fácil de mantener, donde cada clase representa un aspecto específico del sistema.

### 🛠️ Funcionalidades
1. **Clases**: Se definen clases para representar `Cliente`, `CuentaBancaria` y `Transacción`.
2. **Autenticación**: El cliente se autentica utilizando sus credenciales almacenadas en instancias de `Cliente`.
3. **Operaciones de cuenta**: Los métodos para ingresar y retirar dinero están encapsulados dentro de la clase `CuentaBancaria`.
4. **Registro de movimientos**: Se utilizan instancias de `Transacción` para registrar cada operación, permitiendo un seguimiento detallado.

### 🧭 Cómo funciona
- **Instanciación de objetos**: Al inicio, se crean objetos `Cliente` con su información personal, incluyendo cuentas asociadas.
- **Menú de operaciones**: Al autenticar al usuario, se presenta un menú para realizar operaciones sobre su cuenta.
- **Manejo de errores**: Las excepciones se manejan para asegurar que las operaciones sean seguras.

---

## 📚 Recursos adicionales
- [Documentación oficial de C#](https://learn.microsoft.com/es-es/dotnet/csharp/)
- [Tutoriales de .NET](https://learn.microsoft.com/es-es/dotnet/core/tutorials/)
