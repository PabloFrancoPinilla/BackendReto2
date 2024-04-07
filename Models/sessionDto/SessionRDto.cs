namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SessionRDto
{
    [Key]
    public int Id { get; set; }
    public SessionRDto() { }

}
