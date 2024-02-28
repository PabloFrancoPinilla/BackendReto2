namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SessionsDto
{
    [Key]
    public int ObraId { get; set; }
    public Obra Obra { get; set; }

    //Esto se lo he puesto de momento por si acaso para en vue por si tenemos que usarlo
    public SessionsDto() { }

}   