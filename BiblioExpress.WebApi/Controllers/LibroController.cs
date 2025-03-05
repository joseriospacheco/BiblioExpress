using BiblioExpress.Application;
using BiblioExpress.Application.Dtos;
using BiblioExpress.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BiblioExpress.WebApi.Controllers
{

    [Route("api/[controller]s")]
    [ApiController]
    public class LibroController : ControllerBase
    {

        private readonly LibroService libroServicee = new LibroService();

        [HttpPost]
        public ActionResult<string> CrearLibro(Libro libro) {


            libroServicee.Agregar(libro);
            return Ok("El libro se ha creado de forma correcta");

        }


        [HttpGet("{isbn}")]
        public ActionResult<Libro> ConsultarLibro(string isbn)
        {

            if (!String.IsNullOrWhiteSpace(isbn))
            {

                var encontrado = libroServicee.Consultar(isbn);


                if (encontrado is not null)
                {

                    return Ok(encontrado);

                }
                 
            }

            return NotFound("El libro que intenta consultar no se encuentra");

        }


        [HttpDelete("{isbn}")]
        public ActionResult<string> BorrarLibro(string isbn)
        {

            if (!String.IsNullOrWhiteSpace(isbn))
            {


                libroServicee.Borrar(isbn);

                return Ok("El libro se borrado de forma correcta");

            }

            return NotFound("El libro que intenta borrar no se encuentra");
    

        }


        [HttpGet]
        public ActionResult<List<Libro>> Consultar([FromQuery] FiltroConsulta filtro)
        {
            bool sinAutor = string.IsNullOrWhiteSpace(filtro.Autor);
            bool sinGenero = string.IsNullOrWhiteSpace(filtro.Genero);

            // Si ambos filtros están vacíos, retorna todos los libros.
            if (sinAutor && sinGenero)
            {
                return Ok(libroServicee.ConsultarTodos());
            }

            // Comienza con la lista completa de libros.
            var librosFiltrados = libroServicee.ConsultarTodos();

            // Aplica el filtro de Autor si se proporcionó.
            if (!sinAutor)
            {
                librosFiltrados = librosFiltrados
                    .Where(libro => libro.Autor.Contains(filtro.Autor, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Aplica el filtro de Género si se proporcionó.
            if (!sinGenero)
            {
                librosFiltrados = librosFiltrados
                    .Where(libro => libro.Genero.Contains(filtro.Genero, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (librosFiltrados.Any())
            {
                return Ok(librosFiltrados);
            }
            else
            {
                return NotFound("No se encontraron libros con los filtros proporcionados");
            }
        }



    }
}
