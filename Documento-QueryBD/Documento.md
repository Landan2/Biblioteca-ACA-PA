# ACA - Programación Avanzada

# Sistema de Gestión de Biblioteca

---

## PORTADA

**CORPORACION UNFICADA NACIONAL DE LA EDUCACION SUPERIOR**

**INGENIERIA DE SISTEMAS / PROGRAMACION AVANZADA**

### ACA - Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**\
\[Laura ximena Bejarano Acosta y Claudith Beltran Landero\]

**Docente:**\
\[Veronica Castro Munar\]

**Fecha:**\
\[Bogóta, 07, noviembre 2026\]

---------------------------------------------------------------------------

# CONTRAPORTADA

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** \[Laura ximena Bejarano Acosta y Claudith Beltran Landero\]\
**Programa:** \[Ingenieria de sistemas\]\
**Grupo:** \[Grupo\]\
**Docente:** \[Veronica Castro Munar\]\
**Institución:** \[Corporacion Unificada Nacional de la Edcucacion Superior - CUN\]\
**Año:** \[2026\]

------------------------------------------------------------------------

# TABLA DE CONTENIDO

1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones
15. Referencias bibliográficas



------------------------------------------------------------------------

# 1. INTRODUCCIÓN

La construcción de aplicaciones de escritorio orientadas a la administración de datos requiere una arquitectura sólida que garantice la estabilidad del sistema y la fluidez del usuario. En el presente documento, este trabajo aborda la implementación técnica de un Sistema de Gestión de Biblioteca desarrollado en C# con Windows Forms y almacenamiento en SQL Server, aplicando principios de Programación Orientada a Objetos y una arquitectura por capas.A lo largo del desarrollo se implementan componentes clave como el control transaccional de préstamos y devoluciones, el filtrado y actualización dinámica del catálogo bibliográfico y la creación de consultas complejas para la emisión de reportes.

La aplicación permite gestionar **libros, autores, editoriales, préstamos, reportes.** El resultado es un producto software funcional, diseñado bajo estándares de programación modular que facilitan el mantenimiento y escalabilidad del sistema.


------------------------------------------------------------------------

# 2. OBJETIVOS

## 2.1 Objetivo general

Desarrollar e implementar un Sistema de Gestión de Biblioteca mediante una aplicación de escritorio en **C#, Windows Forms y SQL Server**, bajo una arquitectura modular que garantice la estabilidad del sistema, la consistencia de los datos y la automatización eficiente de los procesos de inventario, préstamos y generación de reportes., utilizando Programación Orientada a
Objetos, una base de datos relacional y una arquitectura por capas.


## 2.2 Objetivos específicos

-   Diseñar e implementar la base de datos relacional en SQL Server, definiendo las entidades **libros, autores, editoriales, préstamos, reportes.**, relaciones y restricciones de integridad necesarias para asegurar el almacenamiento consistente de la información bibliográfica.
-   Desarrollar la interfaz gráfica de usuario en Windows Forms, construyendo formularios intuitivos y modulares que faciliten la ejecución de las operaciones CRUD (crear, leer, actualizar y eliminar) para el catálogo y la gestión de usuarios.
-   Programar la lógica de negocio y el control transaccional en C# para la gestión en tiempo real de préstamos y devoluciones, asegurando el seguimiento preciso del estado del inventario y evitando inconsistencias en las fechas y disponibilidad.
-   Construir un módulo de consultas complejas y reportes que permita filtrar el catálogo bibliográfico dinámicamente y emitir informes operativos sobre el estado de los préstamos, optimizando el tiempo de respuesta en la toma de decisiones administrativas.

------------------------------------------------------------------------

# 3. PLANTEAMIENTO DEL PROBLEMA

## 3.1 Descripción del problema

En la actualidad, la institución educativa enfrenta importantes limitaciones operativas en la administración de su biblioteca debido a la ausencia de un sistema informático centralizado y automatizado. Procesos clave como el registro de material bibliográfico (libros, autores y editoriales), el control de usuarios y el seguimiento de préstamos y devoluciones se realizan mediante métodos manuales o herramientas ofimáticas aisladas. Esta dinámica genera reprocesos en la gestión diaria, incrementa el riesgo de pérdida o duplicidad de información y dificulta conocer en tiempo real la disponibilidad real del catálogo.

Asimismo, la falta de una arquitectura de datos estructurada impide llevar un control estricto sobre las fechas de vencimiento de los préstamos, el estado físico de los libros y el historial de uso por parte de los usuarios. Esta desorganización afecta la toma de decisiones administrativas, ya que la consolidación de datos para la emisión de reportes e informes de gestión requiere un esfuerzo considerable y carece de la precisión necesaria.

Ante esta situación, se hace indispensable el desarrollo e implementación de una aplicación de escritorio robusta sobre C#, Windows Forms y SQL Server. Esta solución tecnológica permitirá centralizar la información bibliográfica, automatizar el ciclo transaccional de préstamos y devoluciones y garantizar la integridad y consistencia de los datos almacenados, transformando la administración de la biblioteca en un proceso eficiente, seguro y escalable.

## 3.2 Justificación

Desde la perspectiva institucional, es indispensable migrar de un esquema de gestión manual o fragmentado a un entorno digital centralizado. La implementación del sistema resolverá de forma directa los problemas de inconsistencia y pérdida de datos, al tiempo que optimizará los tiempos de atención y respuesta en la biblioteca.

## 3.3 Alcance

Entre los beneficios operativos principales destacan:

-   Automatización del ciclo transaccional: Garantiza el seguimiento preciso de los préstamos y devoluciones en tiempo real, evitando discrepancias en el inventario y facilitando el control de fechas de entrega.
-   Optimización de la toma de decisiones: La capacidad de generar reportes detallados y consolidados permite al personal administrativo evaluar el estado del catálogo, identificar los materiales más demandados y planificar adquisiciones futuras de forma informada.
-   Eficiencia en la atención al usuario: Agiliza la búsqueda y consulta de libros por autor, editorial o disponibilidad, mejorando significativamente la experiencia de estudiantes y docentes.
- Desarrollo robusto con C# y .NET Framework: C# es un lenguaje de programación orientado a objetos, fuertemente tipado y de alto rendimiento. Proporciona una estructura clara mediante la separación en capas (Presentación, Lógica de Negocio y Acceso a Datos), lo que facilita el mantenimiento, la modularidad y la escalabilidad a futuro del código.
- Interfaz ágil y nativa con Windows Forms: Windows Forms ofrece un entorno maduro para la construcción de interfaces gráficas de usuario (GUI) en plataformas Windows. Permite diseñar formularios intuitivos, livianos y de rápida curva de aprendizaje para los operadores del sistema, reduciendo los tiempos de capacitación del personal.

### Fuera del alcance


-   Delimitación y Alcance del Proyecto
-   Plataformas y Accesibilidad Web / Móvil
- Gestión Económica y Sanciones

------------------------------------------------------------------------

# 4. ANÁLISIS DE REQUERIMIENTOS

## 4.1 Descripción general

El Sistema de Gestión de Biblioteca permitirá administrar de manera centralizada la información relacionada con libros, autores, editoriales y usuarios, optimizando el catálogo bibliográfico y garantizando la integridad de los datos. Asimismo, la aplicación automatizará los procesos operativos de registro de préstamos, control de devoluciones, consulta dinámica de inventario y emisión de reportes gerenciales, proporcionando al personal administrativo una herramienta eficiente en entorno de escritorio para la toma de decisiones y el seguimiento del ciclo de vida del material bibliográfico.

## 4.2 Actores del sistema

  -----------------------------------------------------------------------
   -----------------------------------------------------------------------
 

  | Actor | Descripción |
| :--- | :--- |
| **Bibliotecario / Administrador** | Usuario principal con acceso total. Gestiona el catálogo de libros, autores y editoriales. |
| **Asistente de Biblioteca** | Usuario operativo que realiza búsquedas, préstamos y devoluciones en mostrador. |
  -----------------------------------------------------------------------


## 4.3 Requerimientos funcionales

| Código | Requerimiento | Descripción |
| :--- | :--- | :--- |
| **RF01** | **Gestionar libros** | Registrar, consultar, actualizar, eliminar y buscar libros en el catálogo bibliográfico. |
| **RF02** | **Gestionar autores** | Registrar, consultar, actualizar, eliminar y asociar autores al material bibliográfico. |
| **RF03** | **Gestionar categorías** | Registrar, consultar, actualizar y eliminar las categorías o géneros de los libros. |
| **RF04** | **Gestionar usuarios** | Registrar, consultar, actualizar y eliminar la información de los usuarios (estudiantes/docentes). |
| **RF05** | **Registrar préstamos** | Registrar las salidas de libros y actualizar automáticamente la disponibilidad del inventario. |
| **RF06** | **Registrar devoluciones** | Registrar la recepción de libros prestados y calcular días de retraso o penalización cuando aplique. |
| **RF07** | **Realizar consultas** | Consultar libros disponibles, préstamos activos, historial de transacciones y usuarios con entregas pendientes. |
| **RF08** | **Generar reportes** | Emitir e imprimir informes detallados sobre el estado del inventario, préstamos por periodo y morosidad de usuarios. |
  -----------------------------------------------------------------------

## 4.4 Requerimientos no funcionales

| Código | Requerimiento | Descripción |
| :--- | :--- | :--- |
| **RNF01** | **Usabilidad** | El sistema debe contar con una interfaz estándar en Windows Forms que permita al operador completar un registro o consulta en no más de 3 clics principales. |
| **RNF02** | **Seguridad y Validación** | El sistema debe restringir el ingreso de caracteres inválidos o dañinos en los formularios de entrada mediante comprobación de tipos de datos antes del envío a la base de datos. |
| **RNF03** | **Mantenibilidad** | El proyecto debe ser desarrollado bajo estándares de código limpio en C#, manteniendo una tasa de acoplamiento baja que permita modificar componentes sin afectar el resto del sistema. |
| **RNF04** | **Arquitectura del sistema** | La aplicación debe estar estructurada obligatoriamente en tres capas lógicas (Presentación, Lógica de Negocio y Acceso a Datos) para garantizar el desacoplamiento de componentes. |
| **RNF05** | **Tolerancia a fallos** | El sistema debe capturar cualquier excepción no controlada en tiempo de ejecución sin provocar el cierre inesperado del programa, registrando el evento y notificando al usuario. |
| **RNF06** | **Integridad y Persistencia** | La base de datos en SQL Server debe cumplir las propiedades ACID (Atomicidad, Consistencia, Aislamiento y Durabilidad) en la ejecución de transacciones concurrentes. |
| **RNF07** | **Seguridad en consultas** | Toda comunicación entre la aplicación C# y SQL Server debe emplear exclusivamente consultas parametrizadas para neutralizar riesgos de inyección SQL. |
| **RNF08** | **Tiempo de respuesta** | Las búsquedas del catálogo y la carga de datos en pantallas principales deben ejecutarse en un tiempo máximo de 2 segundos bajo condiciones normales de red local. |
-----------------------------------------------------------------------

## 4.5 Reglas de negocio

### RN01 -- Código único del libro

No se permitirá registrar dos libros con el mismo código.

### RN02 -- Datos obligatorios

No se permitirá almacenar registros con campos obligatorios vacíos.

### RN03 -- Usuario existente

No se podrá registrar un préstamo para un usuario inexistente.

### RN04 -- Libro existente

No se podrá registrar un préstamo para un libro inexistente.

### RN05 -- Disponibilidad

No se podrá prestar un libro cuando no existan ejemplares disponibles.

### RN06 -- Actualización de disponibilidad

Al registrar un préstamo, la disponibilidad del libro deberá
actualizarse.

### RN07 -- Devolución

Al registrar una devolución, la disponibilidad deberá actualizarse
nuevamente.

### RN08 -- Multa

La multa se calculará únicamente cuando exista retraso en la devolución.

### RN09 -- Límite máximo de préstamos
No se permitirá realizar un nuevo préstamo a un usuario que ya cuente con 3 o más libros en estado activo/prestado.

### RN10 -- Restricción por morosidad
No se procesarán nuevos préstamos a usuarios que mantengan entregas pendientes con días de retraso o multas no saldadas.

------------------------------------------------------------------------
# 5. CASOS DE USO

## 5.1 Descripción

El diagrama y la especificación de casos de uso describen las interacciones entre los actores del sistema (Bibliotecario / Administrador y Asistente de Biblioteca) y los diferentes módulos funcionales de la aplicación de escritorio. Estas interacciones abarcan la administración del catálogo (libros, autores, categorías), la gestión de usuarios registrados y el ciclo transaccional completo de préstamos, devoluciones y generación de reportes.

## 5.2 Diagrama de casos de uso

```mermaid
graph LR
    subgraph Sistema de Gestion de Biblioteca
        CU01(CU01: Gestionar Libros)
        CU02(CU02: Gestionar Autores)
        CU03(CU03: Gestionar Usuarios)
        CU04(CU04: Registrar Prestamo)
        CU05(CU05: Registrar Devolucion)
        CU06(CU06: Consultar y Generar Reportes)
    end

    Admin[Bibliotecario / Administrador]
    Asistente[Asistente de Biblioteca]

    Admin --> CU01
    Admin --> CU02
    Admin --> CU03
    Admin --> CU04
    Admin --> CU05
    Admin --> CU06

    Asistente --> CU04
    Asistente --> CU05
    Asistente --> CU06