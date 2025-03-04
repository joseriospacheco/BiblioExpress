# BiblioExpress

BiblioExpress es una API web para la gestión de libros. Permite crear, consultar y borrar libros en una biblioteca.

## Requisitos

- .NET 6.0 o superior
- Visual Studio 2022 o superior

## Instalación

1. Clona el repositorio:


2. La API estará disponible en `https://localhost:5001/api/libro`.

## Estructura del Proyecto

El proyecto está dividido en varias capas para mantener una arquitectura limpia y organizada:

### Capa de Aplicación (`BiblioExpress.Application`)

Esta capa contiene la lógica de negocio de la aplicación. Aquí es donde se implementan los servicios que manejan las operaciones principales, como agregar, consultar y borrar libros.

### Capa de Dominio (`BiblioExpress.Domain`)

Esta capa contiene las entidades del dominio y las interfaces. Define los objetos principales y sus comportamientos, como la entidad `Libro`.

### Capa de Presentación (`BiblioExpress.WebApi`)

Esta capa contiene los controladores de la API. Se encarga de recibir las solicitudes HTTP, procesarlas utilizando los servicios de la capa de aplicación y devolver las respuestas adecuadas.

## Endpoints

### Crear un libro

- **URL:** `/api/libro`
- **Método:** `POST`
- **Cuerpo de la solicitud:**

- **Respuesta exitosa:** `200 OK`

### Consultar un libro por ISBN

- **URL:** `/api/libro/{isbn}`
- **Método:** `GET`
- **Respuesta exitosa:** `200 OK`
- **Respuesta en caso de no encontrar el libro:** `404 Not Found`

### Consultar todos los libros

- **URL:** `/api/libro`
- **Método:** `GET`
- **Respuesta exitosa:** `200 OK`

### Borrar un libro por ISBN

- **URL:** `/api/libro/{isbn}`
- **Método:** `DELETE`
- **Respuesta exitosa:** `200 OK`
- **Respuesta en caso de no encontrar el libro:** `404 Not Found`

## Ejemplo de Código

Aquí tienes un ejemplo del controlador `LibroController` que se encuentra en la capa de presentación (`BiblioExpress.WebApi`):

