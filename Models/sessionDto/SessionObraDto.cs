namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SessionObraDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public int SalaNumber { get; set; }

    public SessionObraDto() { }

}
