using BiblioExpress.Domain.Entities;

namespace BiblioExpress.Application;
public class LibroService
{

    private List<Libro> Libros = []; 

    public void Agregar(Libro libro) {

        Libros.Add(libro);
    
    }

    public List<Libro> ConsultarTodos() {

        return Libros;

    }

    public Libro Consultar(string isbn)
    {  

        return Libros.FirstOrDefault(x => x.Isbn.Equals(isbn));

    }


    public bool Borrar(string isbn)
    {

        var encontrado = Libros.FirstOrDefault(x => x.Isbn.Equals(isbn));

        if (encontrado is not null) {

          return  Libros.Remove(encontrado);
        }

        return false;
    }

}
