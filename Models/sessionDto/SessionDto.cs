namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SessionDto
{
    public int Id { get; set; }
    public ObraDto Obra { get; set; }

    public SessionDto() { }

}
