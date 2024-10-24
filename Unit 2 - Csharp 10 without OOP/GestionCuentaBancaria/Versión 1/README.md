# 🌟 **Gestión de Cuenta Bancaria Mono-usuario (Versión 1)**

## 🗂️ Índice

| Sección                                      | Descripción                                                                 |
|----------------------------------------------|-----------------------------------------------------------------------------|
| [📄 Descripción del Proyecto](#📄-descripción-del-proyecto) | Resumen general de la aplicación de gestión de cuenta bancaria.              |
| [📜 Requisitos del Proyecto](#📜-requisitos-del-proyecto)  | Funcionalidades principales de la aplicación.                                |
| [📝 Explicación del Código](#📝-explicación-del-código)    | Desglose detallado del funcionamiento del código paso a paso.                |
| [🛠️ Tecnologías Utilizadas](#🛠️-tecnologías-utilizadas) | Herramientas y tecnologías empleadas en el desarrollo de la aplicación.      |
| [📋 Flujo del Programa](#📋-flujo-del-programa)           | Menú de opciones disponibles para el usuario.                                |

---

## 📄 Descripción del Proyecto

> **Note:** Este proyecto es una aplicación de consola en **C#** que permite gestionar una cuenta bancaria básica. El usuario puede realizar varias operaciones como **ingresos**, **retiros**, **consultar saldo** y **visualizar movimientos**, todo a través de un menú interactivo.

El saldo inicial es de **10 €**, y el usuario puede operar libremente hasta decidir salir del programa.

---

## 📜 Requisitos del Proyecto

> **Important:** El programa debe cumplir con las siguientes funcionalidades principales:

### Funcionalidades Principales

1. **Ingresar dinero**: El usuario puede añadir fondos a su cuenta.
2. **Retirar dinero**: El usuario puede retirar dinero siempre y cuando no exceda su saldo actual.
3. **Listar movimientos**: Se registra cada ingreso y retiro, permitiendo al usuario consultar el historial completo.
4. **Listar ingresos**: El usuario puede consultar una lista exclusiva de los ingresos realizados.
5. **Listar retiros**: El usuario puede consultar una lista exclusiva de los retiros realizados.
6. **Mostrar saldo**: El usuario puede consultar su saldo disponible en cualquier momento.
7. **Salir**: Opción para finalizar el programa.

---

## 📝 Explicación del Código

El programa sigue un flujo sencillo que permite gestionar una cuenta bancaria con las operaciones esenciales como **ingresar dinero**, **retirar dinero**, **consultar movimientos** y **ver el saldo disponible**. A continuación, se detalla su funcionamiento.

### Estructuras de Datos

| Elemento              | Descripción                                                                 |
|-----------------------|-----------------------------------------------------------------------------|
| **Balance**            | Representa el saldo de la cuenta, que se inicializa en **10 €**.            |
| **Movimientos**        | Historial completo de los movimientos (ingresos y retiros).                  |
| **Incomes**            | Lista que almacena solo los ingresos realizados.                            |
| **Outcomes**           | Lista que almacena solo los retiros realizados por el usuario.              |

> **Note:** Estas estructuras permiten almacenar y consultar el estado financiero del usuario de forma sencilla y organizada.

### Funcionalidad de las Opciones

1. **Ingresar Dinero**:
   - El usuario ingresa una cantidad de dinero. El programa valida que sea **un número positivo**.
   - Si es válido, el monto se **suma al saldo**, y se registra tanto en la lista de movimientos como en la lista de ingresos.

2. **Retirar Dinero**:
   - El usuario solicita retirar una cantidad. El programa valida que:
     - El monto no exceda el saldo actual.
     - El monto sea un número positivo.
   - Si la operación es válida, se resta del saldo y se registra en las listas de movimientos y retiros.

> **Warning:** Si el monto a retirar es mayor al saldo disponible, el programa emitirá una advertencia y no procesará la operación.

3. **Listar Movimientos**:
   - El usuario puede consultar un historial completo de todos los movimientos realizados (ingresos y retiros).

4. **Listar Solo Ingresos**:
   - Se muestra una lista que contiene solo los ingresos registrados.

5. **Listar Solo Retiros**:
   - El usuario puede consultar una lista exclusiva con los retiros realizados.

6. **Consultar Saldo**:
   - El usuario puede ver su saldo actual en cualquier momento seleccionando esta opción.

7. **Salir del Programa**:
   - Cuando el usuario elige esta opción, el programa finaliza su ejecución.

> **Important:** El programa valida todas las entradas numéricas y asegura que el usuario no pueda ingresar valores no válidos.

### Validación de Entradas

- En las opciones de **ingresar dinero** y **retirar dinero**, el programa verifica que los valores ingresados sean **numéricos y positivos**.
- Si el valor no es válido, se solicita al usuario que ingrese un monto correcto.

---

## 🛠️ Tecnologías Utilizadas

| Categoría             | Herramienta                                                                 |
|-----------------------|-----------------------------------------------------------------------------|
| **Lenguaje**          | <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-thebadge&logo=csharp&logoColor=white" alt="C# Badge"/> |
| **Entorno**           | <img src="https://img.shields.io/badge/.NET-%230512B0.svg?style=for-thebadge&logo=dotnet&logoColor=white" alt=".NET Badge"/> |

---

## 📋 Flujo del Programa

> **Note:** A continuación se muestra un resumen del menú que el usuario verá al interactuar con el programa:

| Opción | Descripción                                      |
|--------|--------------------------------------------------|
| 1      | Ingresar dinero                                  |
| 2      | Retirar dinero                                   |
| 3      | Listar todos los movimientos                     |
| 4      | Listar solo los ingresos                         |
| 5      | Listar solo los retiros                          |
| 6      | Mostrar el saldo actual                          |
| 7      | Salir del programa                               |
