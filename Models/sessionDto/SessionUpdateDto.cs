namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SessionUpdateDto
{
    [Key]
    public int Id { get; set; }
    public int ObraId { get; set; }
    public DateTime Date { get; set; }
   
    public SessionUpdateDto() { }

}
