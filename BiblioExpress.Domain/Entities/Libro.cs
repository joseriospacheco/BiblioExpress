using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioExpress.Domain.Entities
{
    public class Libro
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Genero { get; set; }
        public string Sinopsis { get; set; }
        public string Idioma { get; set; }
    }
}
