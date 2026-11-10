# Biblioteca-ACA-ProgramacionA 📚
---

Sistema de Gestión de Biblioteca desarrollado en C# (Windows Forms) con arquitectura en 4 capas y persistencia de datos en SQL Server.

---

## 📌 Descripción del Proyecto

*Biblioteca-ACA-ProgramacionA* es una solución de software orientada al control transaccional de un catálogo bibliográfico.
El sistema automatiza el registro de libros, autores, editoriales/categorías y usuarios, permitiendo gestionar préstamos de ejemplares, devoluciones, días de mora y cálculo automático de penalizaciones económicas.

---

## 🏗️ Arquitectura del Sistema

El sistema implementa una *arquitectura en 4 capas*:

1. *Capa de Presentación (UI):* Formularios en C# Windows Forms.
2. *Capa de Lógica de Negocio (BLL):* Reglas del dominio, validación de stock y cálculo de retrasos
3. *Capa de Acceso a Datos (DAL):* Persistencia mediante ADO.NET y consultas parametrizadas.
4. *Capa de Base de Datos:* Motor relacional *SQL Server* (Biblioteca-ACA-ProgramacionA).

---

## 🛠️ Tecnologías Utilizadas

- *Lenguaje:* C#
- *Interfaz Gráfica:* Windows Forms (WinForms)
- *Base de Datos:* Microsoft SQL Server
- *Acceso a Datos:* ADO.NET
- *Diagramación:* Mermaid / Markdown

---

## 🚀 Funcionalidades Principales

- *Gestión de Catálogos (CRUD):* Libros, Autores, Categorías/Editoriales y Usuarios.
- *Módulo de Préstamos:* Registro transaccional y descuento automático de inventario.
- *Módulo de Devoluciones:* Retorno de libros, cálculo de días de mora y cobro de multas.
- *Módulo de Consultas y Reportes:* Reportes de stock, usuarios morosos e historial.

---

## 🗄️ Estructura de Base de Datos

- Autor
- Categoria
- Libro
- Usuario
- Prestamo
- DetallePrestamo
- Devolucion

---

## ⚙️ Instalación y Configuración

1. Clonar este repositorio.
2. Ejecutar el script SQL incluido (SQLQueryBasededatosBiblioteca.sql) en SQL Server.
3. Configurar la cadena de conexión en la clase Conexion.cs.
4. Compilar y ejecutar desde Visual Studio.
