# 🐾 Administrador de Mascotas

Aplicación de escritorio desarrollada en **C# (.NET / Windows Forms)** como ejercicio práctico de **gestión de datos y bases de datos relacionales**.

El proyecto implementa un **CRUD completo** y muestra **dos enfoques distintos de acceso a datos** dentro de una misma solución:
ADO.NET clásico y DataSet tipado.

---

## 📌 Descripción

La aplicación permite administrar:

* Animales
* Razas (asociadas a animales)
* Mascotas (asociadas a razas)

Desde la interfaz se pueden realizar operaciones de alta, baja, modificación y consulta, mostrando los datos en grillas y formularios.

---

## 🧱 Estructura de la solución

La solución está compuesta por tres proyectos:

### 📚 Biblioteca de Clases

Contiene la lógica de negocio y el acceso a datos, utilizada por ambas aplicaciones.

Clases principales:

* `Animal`
* `Raza`
* `Mascota`
* `CadenaConexion`

---

### 🖥️ Mascotas (ADO.NET)

Aplicación Windows Forms que accede a la base de datos utilizando ADO.NET clásico (`SqlConnection`, `SqlCommand`, `SqlDataReader`).

---

### 🧩 Mascotas DS (DataSet)

Aplicación Windows Forms con la misma funcionalidad, implementada utilizando DataSet tipado y TableAdapters.

Ambas aplicaciones resuelven el mismo problema con enfoques distintos de acceso a datos.

---

## 🗄️ Base de datos

* Motor: SQL Server
* Tipo: Relacional
* Entidades: Animales, Razas y Mascotas

Se utilizan vistas y stored procedures para las operaciones CRUD, con borrado lógico mediante el campo `FechaBaja`.

---

## 📸 Capturas de pantalla

### Menú principal

<img width="633" height="468" alt="2" src="https://github.com/user-attachments/assets/b18a3ede-cd54-4c59-9ea9-c2e08076561d" />

### Gestión de Animales

<img width="730" height="616" alt="3" src="https://github.com/user-attachments/assets/dd697c9b-9ca5-4b4f-95e2-04149d064056" />

### Gestión de Razas

<img width="732" height="617" alt="4" src="https://github.com/user-attachments/assets/0e339ffe-4552-4386-a477-48cfcc54fb0a" />

### Gestión de Mascotas

<img width="858" height="615" alt="5" src="https://github.com/user-attachments/assets/e185510f-20cb-4a57-b5e5-6aecf0444426" />
<img width="849" height="611" alt="6" src="https://github.com/user-attachments/assets/47f57903-04ee-409b-968d-722ed19953da" />

### Explorador de soluciones

<img width="321" height="749" alt="1" src="https://github.com/user-attachments/assets/b81a2c03-c0d2-4a62-ac8d-ec252286256e" />

---

## ▶️ Ejecución

1. Ejecutar script de la base de datos en SQL Server
2. Verificar la cadena de conexión en la clase `CadenaConexion`
3. Abrir la solución en Visual Studio
4. Ejecutar cualquiera de los proyectos:

   * `Mascotas`
   * `Mascotas DS`

---

## 📝 Notas

* Proyecto desarrollado con fines académicos y de práctica.
* Se incluye para demostrar manejo de C#, SQL Server y acceso a datos.
