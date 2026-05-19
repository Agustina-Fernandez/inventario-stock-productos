# Sistema de Control de Inventario y Stock

## 💻 Descripción
Aplicación de escritorio desarrollada en C# (Windows Forms) para la gestión de inventario de un negocio. El sistema permite administrar el ciclo de vida de los productos (Alta, Baja, Modificación y Consulta) y realizar el control del stock disponible, reflejando los cambios en tiempo real en una base de datos MySQL.

## 🛠️ Tecnologías y Herramientas
* **Lenguaje:** C#
* **Interfaz:** Windows Forms (.NET)
* **Base de Datos:** MySQL Relacional
* **Librerías:** MySql.Data

## 🚀 Funcionalidades Principales
* **Módulo de Productos:** CRUD completo (Agregar, Editar, Eliminar) con visualización dinámica en un componente DataGridView y selección automatizada de celdas al hacer clic.
* **Módulo de Stock:** Registro, actualización en tiempo real y control de cantidades disponibles asociadas a los productos por su ID, registrando la fecha de modificación.
* **Navegación Fluida:** Panel de inicio intuitivo para derivar el flujo de trabajo hacia el inventario o hacia el catálogo de productos.

## 📦 Estructura de la Base de Datos
El sistema interactúa con una base de datos relacional llamada `negocio` que contiene dos tablas principales:
* **`productos`:** Controla `id_producto`, `nombre`, `descripcion` y `precio`.
* **`stock`:** Administra el inventario mediante `id_stock`, `id_producto` (FK), `cantidad` y `fecha_actualizacion`.

## 🔧 Instalación y Uso
1. Clonar este repositorio.
2. Importar el archivo `negocio.sql` en tu servidor local de MySQL (XAMPP / MySQL Workbench).
3. Abrir la solución `.sln` en Visual Studio 2022.
4. Compilar y ejecutar el proyecto.

## 📈 Próximos Pasos (Mejoras a Futuro)
* Reemplazar el ingreso manual de `id_producto` en la pantalla de Stock para mejorar la experiencia de usuario y evitar errores de carga.
* Agregar validaciones para impedir campos vacíos o tipos de datos incorrectos antes de enviar las consultas a la base de datos.
