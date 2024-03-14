namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Session
{
    [Key]
    public int Id { get; set; }

    //Clave Foranea de Obra
    public int ObraId { get; set; }
    public Obra Obra { get; set; }
    public DateTime Date { get; set; }

    public int SalaId { get; set; }
    public Sala Sala { get; set; }

    //Esto se lo he puesto de momento por si acaso para en vue por si tenemos que usarlo
    
    public Session() { }

}
