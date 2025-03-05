using BiblioExpress.Domain.Entities;

namespace BiblioExpress.Application;
public class LibroService
{

    private List<Libro> Libros;

    public LibroService()
    {

        Libros = new List<Libro>
{
    new Libro { Isbn = "978-3-16-148410-0", Titulo = "Cien años de soledad", Autor = "Gabriel Garcia Marquez", Editorial = "Editorial Sudamericana", FechaPublicacion = new DateTime(1967, 6, 5), Genero = "Realismo magico", Sinopsis = "Una novela emblemática de la literatura latinoamericana que narra la historia de la familia Buendia.", Idioma = "Espanol" },
    new Libro { Isbn = "978-0-06-112008-4", Titulo = "Matar a un ruisenor", Autor = "Harper Lee", Editorial = "J.B. Lippincott & Co.", FechaPublicacion = new DateTime(1960, 7, 11), Genero = "Ficcion, Drama", Sinopsis = "Una joven nina crece en el sur de los Estados Unidos, aprendiendo sobre el racismo y la moralidad a traves del juicio a un hombre inocente.", Idioma = "Ingles" },
    new Libro { Isbn = "978-0-452-28423-4", Titulo = "1984", Autor = "George Orwell", Editorial = "Secker & Warburg", FechaPublicacion = new DateTime(1949, 6, 8), Genero = "Distopia", Sinopsis = "En un futuro totalitario, el protagonista lucha contra el sistema opresivo dirigido por el Gran Hermano.", Idioma = "Ingles" },
    new Libro { Isbn = "978-0-7432-7356-5", Titulo = "El gran Gatsby", Autor = "F. Scott Fitzgerald", Editorial = "Charles Scribner's Sons", FechaPublicacion = new DateTime(1925, 4, 10), Genero = "Ficcion", Sinopsis = "Una critica a la sociedad estadounidense de la epoca, centrada en el misterioso y millonario Jay Gatsby y su amor no correspondido.", Idioma = "Ingles" },
    new Libro { Isbn = "978-0-14-118776-1", Titulo = "Orgullo y prejuicio", Autor = "Jane Austen", Editorial = "T. Egerton", FechaPublicacion = new DateTime(1813, 1, 28), Genero = "Romantico", Sinopsis = "La historia de Elizabeth Bennet y su relacion con el orgulloso Darcy en la Inglaterra del siglo XIX.", Idioma = "Ingles" },
    new Libro { Isbn = "978-0-307-26348-2", Titulo = "Los pilares de la tierra", Autor = "Ken Follett", Editorial = "Macmillan", FechaPublicacion = new DateTime(1989, 3, 1), Genero = "Historica", Sinopsis = "Una epica novela historica que narra la construccion de una catedral en la Inglaterra medieval, junto con las vidas de sus personajes.", Idioma = "Espanol" },
    new Libro { Isbn = "978-0-307-45541-0", Titulo = "El codigo Da Vinci", Autor = "Dan Brown", Editorial = "Doubleday", FechaPublicacion = new DateTime(2003, 3, 18), Genero = "Thriller", Sinopsis = "Un thriller que combina arte, historia y conspiraciones secretas, todo centrado en un asesinato en el Museo del Louvre.", Idioma = "Ingles" },
    new Libro { Isbn = "978-0-316-03407-0", Titulo = "Harry Potter y la piedra filosofal", Autor = "J.K. Rowling", Editorial = "Bloomsbury", FechaPublicacion = new DateTime(1997, 6, 26), Genero = "Fantasia", Sinopsis = "Un nino huerfano descubre que es un mago y se embarca en una aventura llena de magia, amistad y misterio en la escuela Hogwarts.", Idioma = "Ingles" },
    new Libro { Isbn = "978-0-06-112241-3", Titulo = "El aliento de los dioses", Autor = "Brandon Sanderson", Editorial = "Tor Books", FechaPublicacion = new DateTime(2013, 3, 12), Genero = "Fantasia epica", Sinopsis = "En un mundo gobernado por dioses y fuerzas sobrenaturales, un joven debe tomar decisiones que cambiaren su destino y el de su mundo.", Idioma = "Ingles" },
    new Libro { Isbn = "978-1-4012-8857-3", Titulo = "La casa de los espiritus", Autor = "Isabel Allende", Editorial = "Plaza & Janes", FechaPublicacion = new DateTime(1982, 9, 8), Genero = "Realismo magico", Sinopsis = "Una novela que abarca varias generaciones de una familia en Chile, entrelazando lo personal con lo historico y lo sobrenatural.", Idioma = "Espanol" },
    new Libro { Isbn = "978-0-123-45678-9", Titulo = "El Principito", Autor = "Antoine de Saint-Exupery", Editorial = "Reynal & Hitchcock", FechaPublicacion = new DateTime(1943, 4, 6), Genero = "Fantasia", Sinopsis = "Una historia poetica y filosofica sobre un nino que viaja por distintos planetas y aprende sobre la naturaleza humana.", Idioma = "Espanol" },
    new Libro { Isbn = "978-0-987-65432-1", Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes", Editorial = "Francisco de Robles", FechaPublicacion = new DateTime(1605, 1, 16), Genero = "Novela", Sinopsis = "Las aventuras de un hidalgo que se vuelve loco y se dedica a luchar contra molinos de viento en nombre de la justicia.", Idioma = "Espanol" },
    new Libro { Isbn = "978-0-316-12345-6", Titulo = "Fahrenheit 451", Autor = "Ray Bradbury", Editorial = "Ballantine Books", FechaPublicacion = new DateTime(1953, 10, 19), Genero = "Ciencia ficcion", Sinopsis = "En un futuro distopico, los libros estan prohibidos y los 'bomberos' queman cualquier evidencia de conocimiento.", Idioma = "Ingles" },
    new Libro { Isbn = "978-0-345-67890-7", Titulo = "El senor de los anillos", Autor = "J.R.R. Tolkien", Editorial = "Allen & Unwin", FechaPublicacion = new DateTime(1954, 7, 29), Genero = "Fantasia epica", Sinopsis = "Una epica aventura en la Tierra Media, donde un hobbit se embarca en una peligrosa mision para destruir un anillo maldito.", Idioma = "Ingles" }
};
    }

    public void Agregar(Libro libro)
    {

        Libros.Add(libro);

    }

    public List<Libro> ConsultarTodos()
    {

        return Libros;

    }

    public Libro Consultar(string isbn)
    {

        return Libros.FirstOrDefault(x => x.Isbn.Equals(isbn));

    }


    public bool Borrar(string isbn)
    {

        var encontrado = Libros.FirstOrDefault(x => x.Isbn.Equals(isbn));

        if (encontrado is not null)
        {

            return Libros.Remove(encontrado);
        }

        return false;
    }

}
