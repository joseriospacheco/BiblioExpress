using BiblioExpress.Application;
using BiblioExpress.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BiblioExpress.WebApi.Controllers
{
    [Route("api/[controller]")]
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

        [HttpGet]
        public ActionResult<List<Libro>> ConsultarLibros()
       {
            return libroServicee.ConsultarTodos();
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


    }
}
