namespace BiblioExpress.Domain.Entities;
class Prestamo
{
    public required  int Id { get; set; }
    public string Isbn { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaPrestamo { get; init; }
    public DateTime FechaDevolucion { get; set; }
    public DateTime FechaMaximaDevolucion { get; set; }
}


