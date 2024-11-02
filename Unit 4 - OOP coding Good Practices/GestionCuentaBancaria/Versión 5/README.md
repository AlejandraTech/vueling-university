# 💻 **Gestión de Cuenta Bancaria Multi-usuario (Versión 5)**

## 🗂️ Índice

| Sección                                      | Descripción                                                                 |
|----------------------------------------------|-----------------------------------------------------------------------------|
| [📄 Descripción del Proyecto](#📄-descripción-del-proyecto) | Resumen general de la aplicación de gestión bancaria multi-usuario.          |
| [📜 Requisitos del Proyecto](#📜-requisitos-del-proyecto)  | Especificaciones y funcionalidad requerida para la aplicación.               |
| [📝 Explicación del Código](#📝-explicación-del-código)    | Desglose detallado de cómo funciona el código paso a paso.                   |
| [🛠️ Tecnologías Utilizadas](#🛠️-tecnologías-utilizadas) | Herramientas y tecnologías empleadas en el desarrollo de la aplicación.      |
| [📋 Flujo del Programa](#📋-flujo-del-programa)           | Explicación del menú de opciones disponible para los usuarios.               |

---

## 📄 Descripción del Proyecto

> [!NOTE]  
> Este proyecto es una aplicación de consola en **C#** diseñada para gestionar cuentas bancarias de **múltiples usuarios** mediante operaciones de autenticación, ingresos, retiros y consultas de saldo. Emplea principios de Programación Orientada a Objetos (POO) y una arquitectura modular para separar la lógica de negocio, datos y presentación.

La aplicación permite que cada usuario autenticado pueda realizar operaciones bancarias. Cada operación actualiza el saldo y los movimientos del usuario.

---

## 📜 Requisitos del Proyecto

> [!IMPORTANT]  
> La gestión de cuenta bancaria multi-usuario debe cumplir con las siguientes especificaciones y funcionalidades:

### Requisitos Específicos

1. **Autenticación**:
   - La aplicación solicitará un **número de cuenta** y un **PIN**.
   - **Condición clave:** La cuenta y el PIN deben coincidir para permitir el acceso.

> [!WARNING]  
> Si el número de cuenta y el PIN no coinciden, el acceso no será concedido y el usuario deberá intentar de nuevo.

2. **Operaciones disponibles**:
   - **Después de la autenticación**, el usuario podrá realizar las siguientes operaciones:
     1. **Ingresar dinero** (Deposit)
     2. **Retirar dinero** (Withdraw)
     3. **Listar todos los movimientos** (List All Movements)
     4. **Listar ingresos** (List Incomes)
     5. **Listar retiros** (List Outcomes)
     6. **Mostrar saldo actual** (Show Balance)
     7. **Salir** (Exit)

   - Cada operación afecta directamente el saldo y los movimientos del usuario autenticado.

3. **Funcionalidad del menú**:
   - Tras cada operación, el programa preguntará si el usuario desea realizar otra.
   - Si el usuario decide **no realizar más operaciones**, el programa finalizará la sesión.

---

## 📝 Explicación del Código

El código se divide en varias capas y clases que permiten una organización clara y modular de la funcionalidad del sistema bancario.

### Clases Utilizadas

| Clase              | Descripción                                                                   |
|--------------------|-------------------------------------------------------------------------------|
| **AccountDto**     | Representa la cuenta del usuario, con propiedades para el número de cuenta y saldo. |
| **AccountModel**   | Define los detalles de la cuenta (número, PIN, saldo) y las operaciones de autenticación y transacciones. |
| **MainMenu**       | Controla la interacción del usuario, mostrando el menú de opciones y gestionando la entrada de datos. |
| **AccountService** | Implementa las operaciones bancarias (depósitos, retiros, etc.) y la autenticación. |
| **BankRepository** | Proporciona acceso a los datos de cuentas almacenados en `BankEntity`.       |

### Flujo del Programa

1. **Autenticación del Usuario**:
   - El programa solicita el **número de cuenta** y el **PIN**.
   - Si la autenticación es exitosa, se muestra el menú; de lo contrario, se solicita la autenticación de nuevo.

2. **Menú de Opciones**:

   | Opción                     | Descripción                                      |
   |----------------------------|--------------------------------------------------|
   | **Ingresar dinero**        | Permite al usuario agregar dinero a su saldo.    |
   | **Retirar dinero**         | Elimina una cantidad especificada del saldo, si hay suficiente. |
   | **Listar todos los movimientos** | Muestra todas las transacciones realizadas por el usuario. |
   | **Listar ingresos**        | Muestra solo los depósitos realizados.           |
   | **Listar retiros**         | Muestra solo los retiros realizados.             |
   | **Consultar saldo actual** | Muestra el saldo disponible en cualquier momento.|
   | **Salir**                  | Finaliza la sesión del usuario o permite cambiar de cuenta.|

> [!TIP]  
> Tras cada operación, los movimientos del usuario se actualizan en las listas de ingresos, retiros y movimientos.

3. **Operaciones de Ingreso y Retiro**:
   - **Ingreso**: La aplicación solicita una cantidad positiva para agregar al saldo.
   - **Retiro**: La cantidad retirada se verifica contra el saldo disponible.

4. **Consulta de Movimientos y Saldo**:
   - El usuario puede listar todos los movimientos o consultar el saldo en cualquier momento.

5. **Salir del Programa**:
   - Al seleccionar "Salir", el usuario puede cambiar de cuenta o cerrar la aplicación. Se muestra el saldo antes de salir.

---

## 🛠️ Tecnologías Utilizadas

| Categoría             | Herramienta                                                                 |
|-----------------------|-----------------------------------------------------------------------------|
| **Lenguaje**          | <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-thebadge&logo=csharp&logoColor=white" alt="C# Badge"/> |
| **Entorno**           | <img src="https://img.shields.io/badge/.NET-%230512B0.svg?style=for-thebadge&logo=dotnet&logoColor=white" alt=".NET Badge"/> |

---

## 📋 Flujo del Programa

> [!NOTE]  
> A continuación se muestra una tabla con las opciones de menú disponibles para los usuarios tras la autenticación.

| Opción | Descripción                                      |
|--------|--------------------------------------------------|
| 1      | Ingresar dinero                                  |
| 2      | Retirar dinero                                   |
| 3      | Listar todos los movimientos                     |
| 4      | Listar solo los ingresos                         |
| 5      | Listar solo los retiros                          |
| 6      | Mostrar el saldo actual                          |
| 7      | Salir (cambiar de cuenta o finalizar el programa)|
