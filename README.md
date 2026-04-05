# 🐾 Administrador de Mascotas

Sistema de gestión de escritorio desarrollado en **C# (.NET / Windows Forms)** que permite administrar animales, razas y mascotas con un CRUD completo. El proyecto demuestra dos enfoques de acceso a datos: **ADO.NET clásico** y **DataSet tipado**, aplicando una arquitectura de N‑Capas.

---

## 📸 Capturas de pantalla

**Menú principal**  
<img src="https://github.com/user-attachments/assets/b18a3ede-cd54-4c59-9ea9-c2e08076561d" width="500" />

**Gestión de Animales**  
<img src="https://github.com/user-attachments/assets/dd697c9b-9ca5-4b4f-95e2-04149d064056" width="500" />

**Gestión de Razas**  
<img src="https://github.com/user-attachments/assets/0e339ffe-4552-4386-a477-48cfcc54fb0a" width="500" />

**Gestión de Mascotas**  
<img src="https://github.com/user-attachments/assets/e185510f-20cb-4a57-b5e5-6aecf0444426" width="500" />

**Gestión de Mascotas (con un elemento seleccionado)**  
<img src="https://github.com/user-attachments/assets/47f57903-04ee-409b-968d-722ed19953da" width="500" />

---

## 📁 Estructura del proyecto

```
└── tobiascrocus-administrador-mascotas/
    ├── README.md
    ├── database/
    │   └── Script_Administrador_Mascotas.sql
    └── src/
        ├── Administrador de Mascotas.sln
        ├── Biblioteca De Clases IEFI/
        │   ├── Animal.cs
        │   ├── Biblioteca De Clases.csproj
        │   ├── CadenaConexion.cs
        │   ├── Mascota.cs
        │   ├── Raza.cs
        │   └── Properties/
        │       └── AssemblyInfo.cs
        ├── IEFI Mascotas/
        │   ├── 1 - Menu.cs
        │   ├── 1 - Menu.Designer.cs
        │   ├── 1 - Menu.resx
        │   ├── 2 - Animales.cs
        │   ├── 2 - Animales.Designer.cs
        │   ├── 2 - Animales.resx
        │   ├── 3 - Razas.cs
        │   ├── 3 - Razas.Designer.cs
        │   ├── 3 - Razas.resx
        │   ├── 4 - Mascotas.cs
        │   ├── 4 - Mascotas.Designer.cs
        │   ├── 4 - Mascotas.resx
        │   ├── App.config
        │   ├── Mascotas.csproj
        │   ├── Program.cs
        │   └── Properties/
        │       ├── AssemblyInfo.cs
        │       ├── Resources.Designer.cs
        │       ├── Resources.resx
        │       ├── Settings.Designer.cs
        │       └── Settings.settings
        └── IEFI Mascotas DS/
            ├── 1 - Menu.cs
            ├── 1 - Menu.Designer.cs
            ├── 1 - Menu.resx
            ├── 2 - Animales.cs
            ├── 2 - Animales.Designer.cs
            ├── 2 - Animales.resx
            ├── 3 - Razas.cs
            ├── 3 - Razas.Designer.cs
            ├── 3 - Razas.resx
            ├── 4 - Mascotas.cs
            ├── 4 - Mascotas.Designer.cs
            ├── 4 - Mascotas.resx
            ├── App.config
            ├── IEFI_MascotasDataSet.Designer.cs
            ├── IEFI_MascotasDataSet.xsc
            ├── IEFI_MascotasDataSet.xsd
            ├── IEFI_MascotasDataSet.xss
            ├── Mascotas DS.csproj
            ├── Program.cs
            └── Properties/
                ├── AssemblyInfo.cs
                ├── Resources.Designer.cs
                ├── Resources.resx
                ├── Settings.Designer.cs
                └── Settings.settings
```

---

## 🏗️ Arquitectura del proyecto

La solución está dividida en **tres proyectos** que separan la lógica de negocio, el acceso a datos y la interfaz de usuario:

- **Biblioteca De Clases IEFI** – Capa de acceso a datos (DAL) y entidades.
- **IEFI Mascotas** – UI con ADO.NET clásico (`SqlConnection`, `SqlCommand`).
- **IEFI Mascotas DS** – UI con DataSet tipado y TableAdapters.

Ambas aplicaciones consumen la misma biblioteca de clases y resuelven el mismo problema con enfoques distintos, demostrando flexibilidad en el acceso a datos.

---

## 🗄️ Modelo de datos y persistencia

**Motor:** SQL Server  
**Tipo:** Relacional con borrado lógico (`FechaBaja`)

| Entidad | Descripción |
| :--- | :--- |
| **Animal** | Define el tipo de animal (ej. Perro, Gato). |
| **Raza** | Clasifica a los animales según su estirpe (relacionado con Animal). |
| **Mascota** | Registro individual con nombre, apodo y dueño (relacionado con Raza). |

### Componentes de base de datos utilizados

- **Procedimientos almacenados** – Para operaciones de inserción, modificación y eliminación lógica.
- **Vistas** – Para consultas optimizadas que combinan múltiples tablas.
- **Baja lógica** – Se preserva la integridad histórica mediante el campo `FechaBaja`.

---

## ✨ Funcionalidades

- **CRUD completo** para Animales, Razas y Mascotas.
- **Búsquedas** por nombre o dueño.
- **Arquitectura desacoplada** – La lógica de negocio está centralizada en una DLL independiente.
- **Doble implementación** – Ejemplo práctico de `SqlDataReader` vs `DataSet`.

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET Framework 4.8
- **Interfaz:** Windows Forms (WinForms)
- **Base de datos:** SQL Server
- **Acceso a datos:** ADO.NET (SqlClient)

---

## 🚀 Configuración e instalación

### Requisitos previos
- Visual Studio 2022 (o superior)
- SQL Server Express / LocalDB / Developer Edition

### 1. Base de datos
Ejecutá el script `database/Script_Administrador_Mascotas.sql` en tu instancia de SQL Server.  
Esto creará la base de datos `IEFI Mascotas`, tablas, vistas y procedimientos almacenados.

### 2. Conexión
Verificá la cadena de conexión en `src/Biblioteca De Clases IEFI/CadenaConexion.cs`.  
Por defecto apunta a `Data Source=.;Initial Catalog=IEFI Mascotas;Integrated Security=true;`.

### 3. Ejecución
1. Abrí la solución `src/Administrador de Mascotas.sln` en Visual Studio.
2. Elegí como proyecto de inicio:
   - `IEFI Mascotas` (ADO.NET clásico)
   - `IEFI Mascotas DS` (DataSet tipado)
3. Presioná `F5`.

---

## 📝 Notas

- Proyecto desarrollado con fines académicos y de práctica.
