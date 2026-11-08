# ACA - Programación Avanzada

# Sistema de Gestión de Biblioteca

---

## PORTADA

**CORPORACION UNFICADA NACIONAL DE LA EDUCACION SUPERIOR**

**INGENIERIA DE SISTEMAS / PROGRAMACION AVANZADA**

### ACA - Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**\
Laura ximena Bejarano Acosta y Claudith Beltran Landero

**Docente:**\
Veronica Castro Munar

**Fecha:**\
Bogóta, 07, noviembre 2026

---------------------------------------------------------------------------

# CONTRAPORTADA

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** Laura ximena Bejarano Acosta y Claudith Beltran Landero\
**Grupo:** PROGRAMACION AVANZADA\
**Docente:** Veronica Castro Munar\
**Institución:** Corporacion Unificada Nacional de la Edcucacion Superior - CUN\
**Año:** 2026

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
```
## 5.3 Descripción de casos de uso

### CU01 -- Gestionar libros

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar, consultar, actualizar, eliminar (desactivar) y buscar libros dentro del catálogo bibliográfico de la biblioteca.

**Precondiciones:**
- El usuario debe tener acceso al sistema mediante credenciales válidas y rol asignado.
- Deben existir categorías, autores y editoriales previos cargados en la base de datos para asociar al libro.

**Flujo principal:**
1. El actor ingresa al módulo de gestión de libros desde el menú principal.
2. El sistema despliega la lista actualizada de libros registrados desde la base de datos SQL Server.
3. El actor selecciona la operación que desea realizar (crear, modificar, consultar o desactivar).
4. El actor ingresa o edita la información del libro (Título, ISBN, Autor, Categoría, Editorial, Año de publicación y Stock).
5. El sistema procesa la solicitud mediante la capa de negocio (BLL) y aplica las validaciones requeridas.
6. El sistema guarda la transacción en SQL Server y muestra un mensaje en pantalla confirmando el resultado exitoso.

**Flujos alternativos:**
- **F-Alt 1 (Campos incompletos):** Si el actor deja campos requeridos vacíos (como ISBN o Título), el sistema cancela la operación y notifica al usuario los datos faltantes.
- **F-Alt 2 (ISBN duplicado):** Si se intenta registrar un libro cuyo ISBN ya existe en SQL Server, el sistema cancela el guardado e informa que el código no puede repetirse.
- **F-Alt 3 (Eliminación no permitida):** Si el libro posee préstamos vinculados activos o historial en el sistema, la aplicación bloquea el borrado físico y realiza una inactivación lógica.

**Postcondiciones:**
- El catálogo de libros queda guardado y actualizado en la base de datos SQL Server, disponible inmediatamente para préstamos y búsquedas.

### CU02 -- Registrar préstamo

**Actor principal:** Bibliotecario / Administrador / Asistente de biblioteca

**Descripción:** Permite registrar la salida temporal de uno o varios ejemplares bibliográficos asignados a un usuario registrado en el sistema.

**Precondiciones:**
- El usuario debe estar previamente registrado en la base de datos y en estado "Activo" (sin sanciones pendientes).
- El libro solicitado debe existir en el catálogo y contar con al menos una unidad disponible en el stock.

**Flujo principal:**
1. El actor ingresa al módulo de registro de préstamos.
2. El actor busca y selecciona al usuario mediante su documento de identidad o código.
3. El actor busca y selecciona el libro a prestar utilizando su título o código ISBN.
4. El sistema verifica automáticamente el stock disponible y valida que el usuario no tenga mora ni exceda el límite de préstamos permitidos.
5. El actor confirma la transacción y el sistema calcula la fecha límite de devolución.
6. El sistema descuenta el stock disponible del libro, guarda el registro del préstamo en la base de datos de SQL Server y muestra un mensaje de confirmación en pantalla.

**Flujos alternativos:**
- **F-Alt 1 (Usuario inexistente o inactivo):** Si el usuario no se encuentra registrado o tiene el estado "Inactivo/Sancionado", el sistema deniega la operación y muestra una alerta notificando el impedimento.
- **F-Alt 2 (Libro inexistente o sin stock):** Si el código del libro no existe o su stock actual es igual a cero, el sistema bloquea el registro e informa la indisponibilidad del ejemplar.
- **F-Alt 3 (Límite de préstamos alcanzado):** Si el usuario ya posee el número máximo de libros prestados simultáneamente, el sistema cancela la operación indicando que debe devolver ejemplares antes de solicitar uno nuevo.

**Postcondiciones:**
- El préstamo queda registrado formalmente en la base de datos de SQL Server con estado "Activo".
- El stock disponible del libro prestado se disminuye automáticamente.

---

### CU03 -- Registrar devolución

**Actor principal:** Bibliotecario / Administrador / Asistente de biblioteca

**Descripción:** Permite procesar el retorno de los libros prestados, verificando la fecha de entrega para aplicar sanciones o multas en caso de mora.

**Precondiciones:**
- Debe existir un registro de préstamo activo vinculado al usuario y al libro que se va a devolver.

**Flujo principal:**
1. El actor ingresa al módulo de devoluciones e ingresa el documento del usuario o el código del préstamo.
2. El sistema busca y despliega la lista de préstamos activos correspondientes.
3. El actor selecciona el préstamo o ejemplar que el usuario está entregando.
4. El sistema compara la fecha actual con la fecha límite de devolución y calcula automáticamente si existen días de retraso.
5. El sistema calcula el monto de la multa por mora en caso de aplicar, según la tarifa establecida.
6. El actor confirma la recepción del ejemplar.
7. El sistema incrementa el stock disponible del libro, actualiza el estado del préstamo a "Devuelto" en SQL Server y muestra el resumen de la entrega (con o sin penalización).

**Flujos alternativos:**
- **F-Alt 1 (Préstamo no encontrado):** Si el código ingresado no coincide con ningún préstamo en estado "Activo", el sistema muestra un aviso de error indicando que la devolución no puede procesarse.
- **F-Alt 2 (Devolución con retraso / Generación de multa):** Si la fecha actual supera la fecha pactada, el sistema genera de forma implícita un registro de multa pendiente para el usuario y bloquea sus nuevos préstamos hasta que se gestione el pago.
- **F-Alt 3 (Libro dañado o extraviado):** Si el ejemplar presenta deterioros severos al momento de la entrega, el actor puede marcarlo como "Dañado", lo cual excluye la unidad del stock activo y genera un cargo de reposición.

**Postcondiciones:**
- El estado del préstamo cambia a "Devuelto" (o "Devuelto con mora") en la base de datos de SQL Server.
- El stock disponible del libro incrementa en 1 unidad en el inventario.

# 6. DIAGRAMA DE CLASES

## 6.1 Descripción

El diagrama de clases representa la estructura estática del sistema de gestión de biblioteca (LMS), definiendo los modelos de dominio, sus atributos, métodos principales y las relaciones de asociación, agregación, composición y herencia entre las entidades. Esta estructura desvincula los datos procesados en la capa de interfaz gráfica (UI) de las capas de lógica de negocio (BLL) y acceso a datos (DAL).

## 6.2 Diagrama de clases

```mermaid
classDiagram
    class AUTORES {
        +int IdAutor
        +Varchar 100 Nombre
        +Varchar 100 Apellido
    }

    class EDITORIALES {
        +int IdEditorial
        +Varchar 150 Nombre
    }

    class LIBROS {
        +Varchar 20 ISBN
        +Varchar 200 Titulo
        +int IdAutor
        +int IdEditorial
        +Varchar 100 Categoria
        +int Año
        +int Existencias
    }

    class USUARIOS {
        +int IdUsuario
        +Varchar 100 Nombre
        +Varchar 100 Apellido
        +Varchar 30 Documento
        +Varchar 30 Telefono
        +Varchar 150 Correo
    }

    class PRESTAMOS {
        +int IdPrestamo
        +int IdUsuario
        +Varchar 20 ISBN
        +Date FechaPrestamo
        +Date FechaDevolucion
        +Varchar 20 Estado
    }

    AUTORES "1" --> "0..*" LIBROS : escribe
    EDITORIALES "1" --> "0..*" LIBROS : publica
    USUARIOS "1" --> "0..*" PRESTAMOS : realiza
    LIBROS "1" --> "0..*" PRESTAMOS : se presta
```
## 6.3 Principales clases

| Clase | Responsabilidad |
| :--- | :--- |
| **Libros** | Representar y gestionar la información del catálogo bibliográfico y sus existencias (ISBN, Título, Categoría, Año, Existencias). |
| **Autores** | Representar y gestionar la información de los autores registrados en la base de datos (IdAutor, Nombre, Apellido). |
| **Editoriales** | Representar y gestionar las casas editoriales publicadoras (IdEditorial, Nombre). |
| **Usuarios** | Representar los datos personales de los lectores habilitados para realizar préstamos (IdUsuario, Nombre, Apellido, Documento, Teléfono, Correo). |
| **Prestamos** | Gestionar las transacciones de préstamo, fechas de salida/devolución y control de estado de la entrega (IdPrestamo, IdUsuario, ISBN, FechaPrestamo, FechaDevolucion, Estado). |

## 6.4 Aplicación de POO

En el desarrollo del sistema en C# se aplicaron los siguientes principios y conceptos de la Programación Orientada a Objetos:

- **Clases:** Se crearon plantillas o modelos conceptuales en la capa de entidades (`Entities`) para estructurar los datos del sistema (`Usuarios`, `Prestamos`, `Libros`, `Autores`, `Editoriales`).
- **Objetos:** Se instancian en memoria desde los formularios WinForms para manipular la información procesada por la lógica de negocio antes de ser enviada a SQL Server.
- **Constructores:** Se implementaron constructores por defecto y parametrizados para instanciar objetos asignando valores iniciales directamente desde los registros cargados de la base de datos.
- **Métodos:** Se definieron métodos de acción y validación dentro de las clases de negocio (ej. `ValidarExistencias()`, `RegistrarPrestamo()`, `CalcularFechaDevolucion()`).
- **Propiedades:** Se utilizaron propiedades auto-implementadas con accesores `get` y `set` para exponer los valores de cada atributo de forma estructurada.
- **Encapsulamiento:** Se protegió el acceso directo a las variables internas definiendo modificadores de acceso (`private` / `public`), garantizando que la modificación de datos pase obligatoriamente por la capa de negocio (BLL).
- **Colecciones:** Uso de listas genéricas (`List<Libros>`, `List<Prestamos>`) para manipular conjuntos de datos en memoria y alimentar las listas desplegables y controles `DataGridView` de la interfaz.
- **Herencia:** No aplica directamente en las entidades base del modelo actual, ya que cada entidad representa una tabla independiente de la base de datos relacional.
- **Polimorfismo:** Se aplicó mediante la implementación de interfaces estándar de persistencia (ej. `ICrud<T>`) para reutilizar firmas de métodos como `Insertar()`, `Actualizar()` y `Eliminar()` según el tipo de objeto.
- **Sobrecarga:** Implementada en métodos de búsqueda (ej. `BuscarLibro(string isbn)` y `BuscarLibro(string titulo)`), permitiendo ejecutar operaciones de consulta bajo diferentes parámetros.

# 7. MODELO ENTIDAD-RELACIÓN

## 7.1 Descripción

El Modelo Entidad-Relación (MER) define la estructura lógica de la base de datos relacional implementada en Microsoft SQL Server para el Sistema de Gestión de Biblioteca (LMS). El modelo está optimizado en Tercera Forma Normal (3FN) para garantizar la integridad referencial, evitar la duplicidad de datos y dar soporte a las operaciones transaccionales consumidas desde la capa de acceso a datos (DAL).

## 7.2 Diagrama entidad-relación

```mermaid
erDiagram
    AUTORES ||--o{ LIBROS : "escribe"
    EDITORIALES ||--o{ LIBROS : "publica"
    USUARIOS ||--o{ PRESTAMOS : "realiza"
    LIBROS ||--o{ PRESTAMOS : "se presta"

    AUTORES {
        INT IdAutor PK
        VARCHAR_100 Nombre
        VARCHAR_100 Apellido
    }

    EDITORIALES {
        INT IdEditorial PK
        VARCHAR_150 Nombre
    }

    LIBROS {
        VARCHAR_20 ISBN PK
        VARCHAR_200 Titulo
        INT IdAutor FK
        INT IdEditorial FK
        VARCHAR_100 Categoria
        INT Anio
        INT Existencias
    }

    USUARIOS {
        INT IdUsuario PK
        VARCHAR_100 Nombre
        VARCHAR_100 Apellido
        VARCHAR_30 Documento
        VARCHAR_30 Telefono
        VARCHAR_150 Correo
    }

    PRESTAMOS {
        INT IdPrestamo PK
        INT IdUsuario FK
        VARCHAR_20 ISBN FK
        DATE FechaPrestamo
        DATE FechaDevolucion
        VARCHAR_20 Estado
    }
```
# 8. DICCIONARIO DE DATOS

## 8.1 Convenciones

| Abreviatura | Significado |
| :--- | :--- |
| **PK** | Clave primaria |
| **FK** | Clave foránea |
| **UQ** | Campo con valor único |
| **NULL** | Campo que permite valores nulos (opcional) |
| **NOT NULL** | Campo obligatorio (no permite valores nulos) |

## 8.2 Tabla: AUTORES

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| **IdAutor** | INT | PK | NOT NULL | Identificador único del autor (Identity). |
| **Nombre** | VARCHAR(100) | - | NOT NULL | Nombre del autor. |
| **Apellido** | VARCHAR(100) | - | NOT NULL | Apellido del autor. |

## 8.3 Tabla: EDITORIALES

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| **IdEditorial** | INT | PK | NOT NULL | Identificador único de la editorial (Identity). |
| **Nombre** | VARCHAR(150) | - | NOT NULL | Nombre de la casa editorial. |

## 8.4 Tabla: LIBROS

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| **ISBN** | VARCHAR(20) | PK | NOT NULL | Código único internacional del libro. |
| **Título** | VARCHAR(200) | - | NOT NULL | Título de la obra bibliográfica. |
| **IdAutor** | INT | FK | NOT NULL | Clave foránea referenciada a `AUTORES(IdAutor)`. |
| **IdEditorial** | INT | FK | NOT NULL | Clave foránea referenciada a `EDITORIALES(IdEditorial)`. |
| **Categoría** | VARCHAR(100) | - | NOT NULL | Género o área temática del libro. |
| **Año** | INT | - | NOT NULL | Año de publicación de la obra. |
| **Existencias** | INT | - | NOT NULL | Cantidad de ejemplares disponibles en inventario. |

## 8.5 Tabla: USUARIOS

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| **IdUsuario** | INT | PK | NOT NULL | Identificador único del usuario (Identity). |
| **Nombre** | VARCHAR(100) | - | NOT NULL | Nombres del usuario registrado. |
| **Apellido** | VARCHAR(100) | - | NOT NULL | Apellidos del usuario registrado. |
| **Documento** | VARCHAR(30) | UQ | NOT NULL | Documento de identidad (Único). |
| **Teléfono** | VARCHAR(30) | - | NULL | Número telefónico de contacto. |
| **Correo** | VARCHAR(150) | - | NOT NULL | Dirección de correo electrónico. |

## 8.6 Tabla: PRÉSTAMOS

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| **IdPréstamo** | INT | PK | NOT NULL | Identificador único de la transacción (Identity). |
| **IdUsuario** | INT | FK | NOT NULL | Clave foránea referenciada a `USUARIOS(IdUsuario)`. |
| **ISBN** | VARCHAR(20) | FK | NOT NULL | Clave foránea referenciada a `LIBROS(ISBN)`. |
| **FechaPréstamo** | DATE | - | NOT NULL | Fecha en que se genera el préstamo. |
| **FechaDevolución** | DATE | - | NULL | Fecha real de retorno del libro prestado. |
| **Estado** | VARCHAR(20) | - | NOT NULL | Estado del préstamo (`Disponible`, `Prestado`, `Devuelto`).

## 8.7 Tabla: DetallePrestamo

  ---------------------------------------------------------------------------------------
  Campo                     Tipo de dato    Clave          Nulo           Descripción
  ------------------------- --------------- -------------- -------------- ---------------
  idDetalle                 INT             PK             No             Identificador
                                                                          único del
                                                                          detalle.

  idPrestamo                INT             FK             No             Préstamo al que
                                                                          pertenece.

  idLibro                   INT             FK             No             Libro prestado.

  fechaDevolucionEstimada   DATE            \-             No             Fecha estimada
                                                                          de devolución.

  fechaDevolucionReal       DATE            \-             Sí             Fecha real de
                                                                          devolución.

  valor                     DECIMAL(10,2)   \-             No             Valor asociado
                                                                          al préstamo, si
                                                                          aplica.

  multa                     DECIMAL(10,2)   \-             Sí             Valor de la
                                                                          multa generada.

  estado                    VARCHAR(20)     \-             No             Estado del
                                                                          detalle.
  ---------------------------------------------------------------------------------------

## 8.8 Tabla: Devolucion

  Campo             Tipo de dato    Clave   Nulo   Descripción
  ----------------- --------------- ------- ------ ---------------------------------------
  idDevolucion      INT             PK      No     Identificador único de la devolución.
  idDetalle         INT             FK      No     Detalle del préstamo devuelto.
  fechaDevolucion   DATETIME        \-      No     Fecha de devolución.
  diasRetraso       INT             \-      No     Número de días de retraso.
  multa             DECIMAL(10,2)   \-      Sí     Valor de la multa, si aplica.

> **IMPORTANTE:** El diccionario debe coincidir exactamente con el
> script SQL final. Si los nombres, tipos o campos de la base de datos
> son diferentes, actualizar esta sección.