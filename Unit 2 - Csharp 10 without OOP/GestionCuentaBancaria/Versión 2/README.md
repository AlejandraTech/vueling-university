# 💻 **Gestión de Cuenta Bancaria Multi-usuario (Versión 2)**

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

> **Note:** Este proyecto está diseñado para ser una aplicación de consola en **C#** que permita gestionar cuentas bancarias de **múltiples usuarios**, **sin usar Programación Orientada a Objetos (POO)**.

La aplicación permite a cada usuario autenticarse con su número de cuenta y PIN, para realizar operaciones como **ingresos**, **retiros**, y **consultas de saldo o movimientos**. El objetivo es mostrar cómo se puede gestionar esta funcionalidad utilizando estructuras de datos como listas.

---

## 📜 Requisitos del Proyecto

> **Important:** La gestión de cuenta bancaria multi-usuario (Versión 2) debe cumplir con las siguientes especificaciones y funcionalidades:

### Requisitos Específicos

1. **Autenticación**:
   - El programa solicitará un número de cuenta y un PIN antes de mostrar el menú de opciones.
   - **Condición clave:** El número de cuenta y el PIN deben coincidir en la misma posición en sus respectivas listas.
   
   > **Warning:** Si el número de cuenta y el PIN no coinciden, el acceso no será concedido.

2. **Operaciones disponibles**:
   - **Después de la autenticación**, el usuario podrá realizar las siguientes operaciones:
     1. **Ingresar dinero** (Money income)
     2. **Retirar dinero** (Money outcome)
     3. **Listar todos los movimientos** (List all movements)
     4. **Listar ingresos** (List incomes)
     5. **Listar retiradas** (List outcomes)
     6. **Consultar saldo actual** (Show current balance)
     7. **Salir** (Exit)
     
   - Cada operación afectará al saldo y movimientos del usuario autenticado, almacenados en listas correspondientes.

3. **Funcionalidad del menú**:
   - El programa preguntará al usuario si desea realizar otra operación tras finalizar una.
   - Si el usuario decide **no realizar más operaciones**, el programa mostrará el saldo actual y finalizará.

---

## 📝 Explicación del Código

El programa implementa una gestión básica de múltiples usuarios utilizando **listas** como estructuras de almacenamiento de datos. A continuación, se presenta el desglose del código:

### Estructuras de Datos Utilizadas

| Lista                      | Descripción                                                                 |
|-----------------------------|-----------------------------------------------------------------------------|
| **Números de cuenta**        | Almacena los números de cuenta de los usuarios.                             |
| **PINs**                     | Lista de códigos PIN correspondientes a cada número de cuenta.              |
| **Saldos**                   | Lista de saldos asociados a cada usuario.                                   |
| **Movimientos**              | Historial de todos los movimientos (ingresos y retiros) de cada usuario.    |
| **Ingresos**                 | Lista que almacena solo los ingresos realizados por cada usuario.           |
| **Retiros**                  | Lista que almacena únicamente los retiros realizados por los usuarios.       |

### Flujo del Programa

1. **Autenticación del Usuario**:
   - El programa solicita **número de cuenta y PIN**.
   - Si coinciden, se concede acceso; si no, el programa solicita nuevamente las credenciales.

2. **Menú de Opciones**:
   
   | Opción                     | Descripción                                      |
   |----------------------------|--------------------------------------------------|
   | **Ingresar dinero**         | Permite agregar dinero al saldo del usuario.     |
   | **Retirar dinero**          | Elimina una cantidad especificada del saldo.     |
   | **Listar todos los movimientos** | Muestra el historial completo del usuario.    |
   | **Listar ingresos**         | Muestra solo los ingresos del usuario.           |
   | **Listar retiros**          | Muestra solo los retiros del usuario.            |
   | **Consultar saldo actual**  | Muestra el saldo disponible en cualquier momento.|
   | **Salir**                   | Ofrece la opción de finalizar o cambiar de cuenta.|

> **Note:** Al realizar una operación, los movimientos se actualizan en las listas de ingresos, retiros y movimientos.

3. **Ingreso y Retiro de Dinero**:
   - **Ingreso**: El usuario introduce una cantidad positiva que se suma a su saldo.
   - **Retiro**: El programa verifica que el monto no exceda el saldo antes de procesar la operación.

4. **Consulta de Movimientos y Saldo**:
   - Se pueden listar los **movimientos**, los **ingresos** o los **retiros** en cualquier momento.
   - La consulta del saldo se puede realizar en cualquier punto del programa.

5. **Salir del Programa**:
   - Al salir, el usuario puede cambiar de cuenta o finalizar la sesión. **El saldo actual** se muestra antes de la salida.

---

## 🛠️ Tecnologías Utilizadas

| Categoría             | Herramienta                                                                 |
|-----------------------|-----------------------------------------------------------------------------|
| **Lenguaje**          | <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-thebadge&logo=csharp&logoColor=white" alt="C# Badge"/> |
| **Entorno**           | <img src="https://img.shields.io/badge/.NET-%230512B0.svg?style=for-thebadge&logo=dotnet&logoColor=white" alt=".NET Badge"/> |

---

## 📋 Flujo del Programa

> **Note:** A continuación se muestra una tabla resumen de las opciones del menú que el usuario puede seleccionar una vez autenticado.

| Opción | Descripción                                      |
|--------|--------------------------------------------------|
| 1      | Ingresar dinero                                  |
| 2      | Retirar dinero                                   |
| 3      | Listar todos los movimientos                     |
| 4      | Listar solo los ingresos                         |
| 5      | Listar solo los retiros                          |
| 6      | Mostrar el saldo actual                          |
| 7      | Salir (cambiar de cuenta o finalizar el programa)|
