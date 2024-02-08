namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Seat
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Numero { get; set; }
    [Required]
    [ForeignKey("Obra")]
    public int ObraId { get; set; }
    public Obra Obra { get; set; }
    public Seat(){}

}
